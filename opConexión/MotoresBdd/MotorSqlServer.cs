using opConexión.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opConexión.MotoresBdd
{
    public class MotorSqlServer : IMotorBdd
    {
        public string Motor => "SQL Server";

        public static bool ProbarConexion(string servidor, string usuario, string contraseña, string baseDatos = "master")
        {
            string cadenaConexion = $"Server={servidor};Database={baseDatos};User Id={usuario};Password={contraseña};";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    return true; 
                }
                catch (SqlException)
                {
                    return false; 
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string CadenaConexion(string servidor, string usuario, string contraseña)
        {
            return $"Data Source={servidor};Initial Catalog=master;User ID={usuario};Password={contraseña}";
        }

        public bool ProbarConexion(string servidor, string usuario, string contraseña, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion(servidor, usuario, contraseña)))
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        public DataTable ObtenerBases(string servidor, string usuario, string contraseña, out string mensaje)
        {
            return EjecutarConsultaInterna(servidor, usuario, contraseña, "SELECT name FROM sys.databases ORDER BY name ASC", out mensaje);
        }

        public DataTable ObtenerTablas(string servidor, string usuario, string contraseña, string baseDatos, out string mensaje)
        {
            string query = $@"
                USE [{baseDatos}];
                SELECT s.name + '.' + t.name AS EsquemaTabla, t.name AS Tabla, s.name AS Esquema
                FROM sys.tables AS t
                INNER JOIN sys.schemas AS s ON t.schema_id = s.schema_id
                ORDER BY Esquema, Tabla;";
            return EjecutarConsultaInterna(servidor, usuario, contraseña, query, out mensaje);
        }

        public DataTable ObtenerCampos(string servidor, string usuario, string contraseña, string baseDatos, string tabla, out string mensaje)
        {
            string[] partes = tabla.Split('.');
            string nombreTabla = partes.Length > 1 ? partes[1] : partes[0];
            string query = $@"
                USE [{baseDatos}];
                SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_NAME = @Tabla;";

            DataTable resultado = new DataTable();
            mensaje = "";
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion(servidor, usuario, contraseña)))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Tabla", nombreTabla);
                        resultado.Load(cmd.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return resultado;
        }

        public DataTable EjecutarConsulta(string servidor, string usuario, string contraseña, string baseDatos, string query, out string mensaje)
        {
            mensaje = "";
            string fullQuery = $"USE [{baseDatos}]; {query}";
            return EjecutarConsultaInterna(servidor, usuario, contraseña, fullQuery, out mensaje);
        }

        private DataTable EjecutarConsultaInterna(string servidor, string usuario, string contraseña, string query, out string mensaje)
        {
            mensaje = "";
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion(servidor, usuario, contraseña)))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return dt;
        }
    }
}

