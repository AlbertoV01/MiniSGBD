using opConexión;
using opConexión.MotoresBdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniSGBD
{
    public partial class FormPrincipal : Form
    {
        public string instancia = string.Empty;
        public FormLogin formLogin = new FormLogin(0);
        readonly MotorSqlServer MotorSqlServer = new MotorSqlServer();
        public FormPrincipal()
        {
            InitializeComponent();
        }      

        private void cb_BasesdeDatos_DropDown(object sender, EventArgs e)
        {
            if(cb_BasesdeDatos.Text == "")
            {
                MessageBox.Show("Conectate a un servirdor o Selecciona un servidor primero");
                return;
            }
            cb_BasesdeDatos.DataSource = MotorSqlServer.ObtenerBases(InicioSesionDatos.Servidor,InicioSesionDatos.Usuario , InicioSesionDatos.Contra, out string mensaje);
            cb_BasesdeDatos.ValueMember = "name";
        }
        public string SeleccionarConsulta()
        {
            
            string Consulta = rtb_Consultas.SelectedText;
            if (Consulta=="")
            {
                Consulta = rtb_Consultas.Text;
            }
            
            return Consulta;
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            SeleccionarConsulta();

            if (cb_BasesdeDatos.Text=="")
            {
                errorProvider1.SetError(cb_BasesdeDatos, "Seleccione la base de datos");
            }
            else
            {
               DataTable DatosDGV = MotorSqlServer.EjecutarConsulta(InicioSesionDatos.Servidor, InicioSesionDatos.Usuario, InicioSesionDatos.Contra, cb_BasesdeDatos.Text, rtb_Consultas.Text, out string mensaje);
                lb_error.Text = mensaje;
                dgv_Resultados.DataSource = DatosDGV;
            }
        }      
        private void tv_MenuBD_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            string servidor =tv_MenuBD.SelectedNode.Text;
            if (servidor == opConexión.InicioSesionDatos.Servidor)
            {
                cb_BasesdeDatos.DataSource = MotorSqlServer.ObtenerBases(InicioSesionDatos.Servidor, InicioSesionDatos.Usuario, InicioSesionDatos.Contra, out string mensaje);
                cb_BasesdeDatos.DisplayMember = "name";
            }
        }

        private void rtb_Consultas_TextChanged(object sender, EventArgs e)
        { 
            opConexión.PlabrasReservadasSql.Resaltar(rtb_Consultas);
        }

        private void btn_Conect_Click(object sender, EventArgs e)
        {
           formLogin.ShowDialog();
           InicioSesionDatos.CargarTreeView(tv_MenuBD);

            btn_Actualizar.Enabled = true;
            btn_Disconnect.Enabled = true;

            formLogin.sInstancia = instancia;
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {

            if (tv_MenuBD.SelectedNode == null)
            {
                MessageBox.Show("Selecciona un servidor para desconectar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TreeNode nodoSeleccionado = tv_MenuBD.SelectedNode;

            // Solo permitir desconectar si es nodo raíz (servidor)
            if (nodoSeleccionado.Parent == null)
            {
                // Eliminar el nodo raíz (servidor)
                tv_MenuBD.Nodes.Remove(nodoSeleccionado);
                MessageBox.Show($"Servidor '{nodoSeleccionado.Text}' desconectado correctamente.", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Solo puedes desconectar servidores completos, no bases de datos o tablas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btn_Disconnect.Enabled = false;
            btn_Actualizar.Enabled = false;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            TreeNode nodoSeleccionado = tv_MenuBD.SelectedNode;

            if (tv_MenuBD.SelectedNode == null)
            {
                MessageBox.Show("Selecciona un nodo para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tv_MenuBD.Nodes.Remove(nodoSeleccionado);

            InicioSesionDatos.CargarTreeView(tv_MenuBD);
        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de programa |*.txt|.sql||.docx|";
            if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                if (File.Exists(saveFileDialog.FileName))
                {
                    string Nombre_Del_Archivo = saveFileDialog.FileName;

                    File.Create(Nombre_Del_Archivo);
                    File.WriteAllText(Nombre_Del_Archivo, rtb_Consultas.Text);
                }
                else
                {
                    string Nombre_Del_Archivo = saveFileDialog.FileName;
                    //File.Create(Nombre_Del_Archivo);
                    File.WriteAllText(Nombre_Del_Archivo, rtb_Consultas.Text);
                    //string texto = saveFileDialog.FileName;
                    //StreamWriter textoguardar = File.CreateText(texto);
                    //textoguardar.Write(rtb_Consultas.Text);
                    //textoguardar.Flush();
                    //textoguardar.Close();

                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de programa |*.txt|.sql||.docx|";
            openFileDialog.Title = "Buscar Archivo";
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                string Archivo = openFileDialog.FileName;
                TextReader LeerTextoDeArchivo = new StreamReader(Archivo);
                rtb_Consultas.Text = LeerTextoDeArchivo.ReadToEnd();
                LeerTextoDeArchivo.Close();
            }
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Actualizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_Maximizar.Visible = false;
            pb_Restaurar.Visible = true;
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_Restaurar.Visible=false;
            pb_Maximizar.Visible = true;
        }

        private void pb_Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState =FormWindowState.Minimized;
        }
    }
}
