using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;
using opConexión.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace opConexión.MotoresBdd
{
    public class MotorMySql : IMotorBdd
    {
        public  string Motor => "MySql";
        public static bool ProbarConexion(string servidor, string usuario, string contraseña, string baseDatos = "mysql")
        {
            string cadenaConexion = $"Server={servidor};Database={baseDatos};Uid={usuario};Pwd={contraseña};";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    return true;
                }
                catch (MySqlException)
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
            return $"Server={servidor};Database=master;Uid={usuario};Pwd={contraseña};";
        }

        public bool ProbarConexion(string servidor, string usuario, string contraseña, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (MySqlConnection con = new MySqlConnection(CadenaConexion(servidor, usuario, contraseña)))
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
            string query = "SHOW DATABASES;";
            return EjecutarConsultaInterna(servidor, usuario, contraseña, query, out mensaje);
        }

        public DataTable ObtenerTablas(string servidor, string usuario, string contraseña, string baseDatos, out string mensaje)
        {
            string query = $@"SHOW FULL TABLES IN `{baseDatos}`;";
            return EjecutarConsultaInterna(servidor, usuario, contraseña, query, out mensaje, baseDatos);
        }

        public DataTable ObtenerCampos(string servidor, string usuario, string contraseña, string baseDatos, string tabla, out string mensaje)
        {
            string query = $@"
            SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
            FROM INFORMATION_SCHEMA.COLUMNS
            WHERE TABLE_SCHEMA = @BD AND TABLE_NAME = @Tabla;";

            DataTable resultado = new DataTable();
            mensaje = "";
            try
            {
                using (MySqlConnection con = new MySqlConnection(CadenaConexion(servidor, usuario, contraseña)))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BD", baseDatos);
                        cmd.Parameters.AddWithValue("@Tabla", tabla);
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
            return EjecutarConsultaInterna(servidor, usuario, contraseña, query, out mensaje, baseDatos);
        }

        private DataTable EjecutarConsultaInterna(string servidor, string usuario, string contraseña, string query, out string mensaje, string baseDatos = "mysql")
        {
            mensaje = "";
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(CadenaConexion(servidor, usuario, contraseña)))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
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
