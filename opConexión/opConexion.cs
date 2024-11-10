using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

using StructureMap.Pipeline;

namespace opConexión
{
    public static class opConexion
    {
        public static string error;
        public static bool Conexion(string instancia, string sUsuario, string sContraseña)
        {
            bool exito = false;
            string CadenaConexion = $"Data Source={instancia};Initial Catalog=master;User ID={sUsuario};Password={sContraseña}";
            SqlConnection ConexionBD = new SqlConnection(CadenaConexion);

            try
            {
                ConexionBD.Open();
                exito = true;

            }
            catch
            {

            }

            finally
            {
                ConexionBD.Close();
            }

            return exito;

        }

        public static string CadenaConexion(string instancia, string sUsuario, string sContraseña)
        {

            string CadenaConexion = $"Data Source={instancia};Initial Catalog=master;User ID={sUsuario};Password={sContraseña}";
            SqlConnection ConexionBD = new SqlConnection(CadenaConexion);

            try
            {
                ConexionBD.Open();

            }
            catch
            {

            }

            finally
            {
                ConexionBD.Close();
            }

            return CadenaConexion;

        }

        public static DataTable ConsultarBDD(string instancia, string usuario, string contraseña)
        {
            string Mensaje = string.Empty;
            DataTable BaseDeDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(opConexion.CadenaConexion(instancia, usuario, contraseña));
            try
            {
                conexion.Open();
                string Query = $"select name from sys.databases order by name ASC";
                SqlCommand comando = new SqlCommand(Query, conexion);
                BaseDeDatos.Load(comando.ExecuteReader());
            }
            catch (Exception r)
            {
                Mensaje = r.Message;
            }
            finally
            {
                conexion.Close();
            }
            return BaseDeDatos;
        }


        public static DataTable ConsultarServidores(string instancia, string usuario, string contraseña)
        {

            System.Data.DataTable dtServidores = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();

            return dtServidores;

        }

        public static DataTable RealizarConsultas(string instancia, string usuario, string contraseña, string query, string BDD)
        {

            string Mensaje;
            DataTable Consultas = new DataTable();
            SqlConnection conexion = new SqlConnection(opConexion.CadenaConexion(instancia, usuario, contraseña));
            try
            {
                conexion.Open();
                string Query = $"use {BDD} " + query;



                SqlCommand comando = new SqlCommand(Query, conexion);

                if (Query.ToLower().Contains("select"))
                {
                    Consultas.Load(comando.ExecuteReader());
                }
                else
                {
                    comando.ExecuteNonQuery();
                }
                               

                error = "";
            }
            catch (Exception r)
            {
                error = r.Message;
                
            }
            finally
            {
                conexion.Close();
            }

            return Consultas;

        }

    }
   
  




    
}
