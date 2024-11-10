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
    public static class InicioSesionDatos
    {
        public static string servidor { get; set; }
        public static string usuario { get ; set; }
        public static string contra { get;set; }

        
        static int numVeces = 0;
        public static void CargarTreeView(TreeView tv_MenuBD)
        {


            if (numVeces == 0)
            {
                numVeces++;
                TreeNode NodoPadre = new TreeNode();
                NodoPadre.Name = servidor;
                NodoPadre.Text = servidor;
                tv_MenuBD.Nodes.Add(NodoPadre);
                DataTable BDD = OpTreeView.ConsultarBDD(servidor, usuario, contra);
                foreach (DataRow FilaBDD in BDD.Rows)
                {
                    TreeNode NodoFilasBDD = new TreeNode();
                    NodoFilasBDD.Name = FilaBDD[0].ToString();
                    NodoFilasBDD.Text = FilaBDD[0].ToString();
                    tv_MenuBD.Nodes[NodoPadre.Name].Nodes.Add(NodoFilasBDD);
                    DataTable TablasBDD = OpTreeView.ObtenerTablas(servidor, usuario, contra, NodoFilasBDD.Name);
                    //  string x = NodoTablasBDD.Name.Remove(0, NodoTablasBDD.Name.IndexOf('.'));

                    foreach (DataRow FilaTablasBDD in TablasBDD.Rows)
                    {
                        TreeNode NodoTablasBDD = new TreeNode();
                        NodoTablasBDD.Name = FilaTablasBDD[0].ToString();
                        NodoTablasBDD.Text = FilaTablasBDD[0].ToString();
                        tv_MenuBD.Nodes[NodoPadre.Name].Nodes[NodoFilasBDD.Name].Nodes.Add(NodoTablasBDD);
                        DataTable CamposBDD = OpTreeView.ObtenerCampos(servidor, usuario, contra, NodoFilasBDD.Name, NodoTablasBDD.Name);

                        foreach (DataRow FilaCampos in CamposBDD.Rows)
                        {
                            TreeNode NodoCamposTablas = new TreeNode();
                            string TipoDeDato = FilaCampos[1].ToString();
                            string Longitud = FilaCampos[2].ToString();
                            NodoCamposTablas.Name = FilaCampos[0].ToString();
                            NodoCamposTablas.Text = FilaCampos[0].ToString() + $" ({TipoDeDato})  " + $" ({Longitud})";
                            tv_MenuBD.Nodes[NodoPadre.Name].Nodes[NodoFilasBDD.Name].Nodes[NodoTablasBDD.Name].Nodes.Add(NodoCamposTablas);

                        }
                    }

                }


            }
            else
            {
                TreeNode NodoPadre = new TreeNode();
                NodoPadre.Name = servidor;
                NodoPadre.Text = servidor;
                tv_MenuBD.Nodes.Add(NodoPadre);
                DataTable BDD = OpTreeView.ConsultarBDD(servidor, usuario, contra);
                foreach (DataRow FilaBDD in BDD.Rows)
                {
                    TreeNode NodoFilasBDD = new TreeNode();
                    NodoFilasBDD.Name = FilaBDD[0].ToString();
                    NodoFilasBDD.Text = FilaBDD[0].ToString();
                    tv_MenuBD.Nodes[NodoPadre.Name].Nodes.Add(NodoFilasBDD);
                    DataTable TablasBDD = OpTreeView.ObtenerTablas(servidor, usuario, contra, NodoFilasBDD.Name);
                    

                    foreach (DataRow FilaTablasBDD in TablasBDD.Rows)
                    {
                        TreeNode NodoTablasBDD = new TreeNode();
                        NodoTablasBDD.Name = FilaTablasBDD[0].ToString();
                        NodoTablasBDD.Text = FilaTablasBDD[0].ToString();
                        tv_MenuBD.Nodes[NodoPadre.Name].Nodes[NodoFilasBDD.Name].Nodes.Add(NodoTablasBDD);
                        DataTable CamposBDD = OpTreeView.ObtenerCampos(servidor, usuario, contra, NodoFilasBDD.Name, NodoTablasBDD.Name);

                        foreach (DataRow FilaCampos in CamposBDD.Rows)
                        {
                            TreeNode NodoCamposTablas = new TreeNode();
                            string TipoDeDato = FilaCampos[1].ToString();
                            string Longitud = FilaCampos[2].ToString();
                            NodoCamposTablas.Name = FilaCampos[0].ToString();
                            NodoCamposTablas.Text = FilaCampos[0].ToString() + $" ({TipoDeDato})  " + $" ({Longitud})";
                            tv_MenuBD.Nodes[NodoPadre.Name].Nodes[NodoFilasBDD.Name].Nodes[NodoTablasBDD.Name].Nodes.Add(NodoCamposTablas);

                        }
                    }

                }

            }

        }

    }
}
