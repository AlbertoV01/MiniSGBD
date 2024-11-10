using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using opConexión;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace opConexión
{
    public static class OpTreeView
    {
        static string Mensaje = "";

        public static DataTable ConsultarBDD(string instancia, string usuario, string contraseña)
        {
            DataTable BaseDeDatos = new DataTable();
            SqlConnection conexion = new SqlConnection(opConexion.CadenaConexion(instancia, usuario, contraseña));
            try
            {
                conexion.Open();
                string Query = $"select name from sys.databases";
                SqlCommand comando = new SqlCommand(Query,conexion);
                BaseDeDatos.Load(comando.ExecuteReader());
            }
            catch(Exception r)
            {
                Mensaje = r.Message;
            }
            finally
            {
                conexion.Close();
            }
            return BaseDeDatos;
        }

        public static DataTable ObtenerTablas(string instancia, string usuario, string contraseña,string BDD)
        {
            DataTable Tablas = new DataTable();
            SqlConnection conexion = new SqlConnection(opConexion.CadenaConexion(instancia, usuario, contraseña));
            try
            {
                conexion.Open();
                string Query = $" use {BDD} select s.name+'.'+tab.name as EsquemaTabla, tab.name as Tabla, s.name as Esquema "+
                $"from sys.tables as tab inner join sys.schemas as s on tab.schema_id = s.schema_id "+
                $"group by tab.name,s.name order by Esquema";
                SqlCommand comando = new SqlCommand(Query, conexion);
                Tablas.Load(comando.ExecuteReader());
            }
            catch (Exception r)
            {
                Mensaje = r.Message;
            }
            finally
            {
                conexion.Close();
            }
            return Tablas;
        }

        public static DataTable ObtenerCampos(string instancia, string usuario, string contraseña,string BDD,  string TablaBDD)

        {
            DataTable Campos = new DataTable();
            SqlConnection conexion = new SqlConnection(opConexion.CadenaConexion(instancia, usuario, contraseña));
            try
            {
                conexion.Open();
                string[] pal = TablaBDD.Split('.');
                string Query = $"USE {BDD} SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{pal[1]}'";
                SqlCommand comando = new SqlCommand(Query, conexion);
                Campos.Load(comando.ExecuteReader());
            }
            catch (Exception r)
            {
                Mensaje = r.Message;
            }
            finally
            {
                conexion.Close();
            }
            return Campos;

        }

       


    }
}
