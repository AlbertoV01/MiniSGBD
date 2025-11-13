using opConexión;
using opConexión.GestorMotores;
using opConexión.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace opConexión
{
    public static class InicioSesionDatos
    {
        public static string Servidor { get; set; }
        public static string Usuario { get; set; }
        public static string Contra { get; set; }
        public static string Motor { get; set; } 

        public static void CargarTreeView(TreeView tv_MenuBD)
        {
            try
            {
                string mensaje;
                IMotorBdd motor = ManejadorDeConexion.ObtenerMotor(Motor);

                // Evita duplicar servidores
                TreeNode nodoServidor = tv_MenuBD.Nodes[Servidor] ?? new TreeNode(Servidor) { Name = Servidor };
                if (tv_MenuBD.Nodes[Servidor] == null)
                    tv_MenuBD.Nodes.Add(nodoServidor);
                // Bases de datos
                DataTable bases = motor.ObtenerBases(Servidor, Usuario, Contra, out  mensaje);
                foreach (DataRow db in bases.Rows)
                {
                    string nombreBDD = db[0].ToString();
                    if (!nodoServidor.Nodes.ContainsKey(nombreBDD))
                    {
                        TreeNode nodoBDD = new TreeNode(nombreBDD) { Name = nombreBDD };
                        nodoServidor.Nodes.Add(nodoBDD);

                        DataTable tablas = motor.ObtenerTablas(Servidor, Usuario, Contra, nombreBDD, out mensaje);
                        foreach (DataRow tabla in tablas.Rows)
                        {
                            TreeNode nodoTabla = new TreeNode(tabla[0].ToString()) { Name = tabla[0].ToString() };
                            nodoBDD.Nodes.Add(nodoTabla);

                            DataTable campos = motor.ObtenerCampos(Servidor, Usuario, Contra, nombreBDD, nodoTabla.Name, out mensaje);
                            foreach (DataRow campo in campos.Rows)
                            {
                                nodoTabla.Nodes.Add($"{campo[0]} ({campo[1]}) ({campo[2]})");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                
            }
        }

    }
}
