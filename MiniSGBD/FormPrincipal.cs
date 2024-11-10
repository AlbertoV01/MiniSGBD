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

namespace MiniSGBD
{
    public partial class FormPrincipal : Form
    {
        public string instancia = string.Empty;
        public string usuario = string.Empty;
        public string contraseña = string.Empty;
        //public List<FormLogin> Datos = new List<FormLogin>();
        //public List<string> Lista = new List<string>();
        public string servidor = "";

        //TreeView PruebaTreeView = new TreeView(); 
        public FormLogin formLogin = new FormLogin(0);
        int a = 0;
        string seleccion=string.Empty;
        public FormPrincipal()
        {
         
            InitializeComponent();

        }      
     
      
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_BasesdeDatos_DropDown(object sender, EventArgs e)
        {
         

            //cb_BasesdeDatos.DataSource = opConexion.ConsultarBDD(instancia, usuario, contraseña);
            //cb_BasesdeDatos.ValueMember = "name";
        }
        public string SeleccionarConsulta()
        {
            
            string Consulta = rtb_Consultas.SelectedText;
            if (Consulta=="")
            {
                Consulta = rtb_Consultas.Text;

            }
            else
            {

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
                DataTable DatosDGV = opConexion.RealizarConsultas(InicioSesionDatos.servidor, InicioSesionDatos.usuario, InicioSesionDatos.contra, SeleccionarConsulta(), cb_BasesdeDatos.Text);
                lb_error.Text = opConexion.error;
                dgv_Resultados.DataSource = DatosDGV;
            }
            

            //string consulta = tb_Consultas.Text;
            //SqlConnection cnn;
            //SqlCommand cmd;
            //cnn = new SqlConnection(opConexion.CadenaConexion(instancia, usuario, contraseña));
            //cmd = new SqlCommand(consulta, cnn);
            
        }

        public void MarcarPalabrasR()
        {
            string texto = rtb_Consultas.Text;


            //switch(tb_Consultas)
            //{
            //     case "select":

            //         break;



            //}

            rtb_Consultas.ForeColor = System.Drawing.Color.Red;

        }
      
        private void tv_MenuBD_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            string servidor =tv_MenuBD.SelectedNode.Text;
            if (servidor == opConexión.InicioSesionDatos.servidor)
            {
                cb_BasesdeDatos.DataSource = OpTreeView.ConsultarBDD(InicioSesionDatos.servidor,InicioSesionDatos.usuario,InicioSesionDatos.contra);
                cb_BasesdeDatos.DisplayMember = "name";
            }

        }

     

        private void rtb_Consultas_TextChanged(object sender, EventArgs e)
        {
            //DML
            opConexión.PlabrasReservadasSql.Select(rtb_Consultas);
            opConexión.PlabrasReservadasSql.From(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Insert(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Update(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Delete(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Database(rtb_Consultas);
            //opConexión.PlabrasReservadasSql.Asterisco(rtb_Consultas);
            //DDL
            opConexión.PlabrasReservadasSql.Create(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Alter(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Drop(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Truncate(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Comment(rtb_Consultas);
            opConexión.PlabrasReservadasSql.Rename(rtb_Consultas);

        }

        private void btn_Conect_Click(object sender, EventArgs e)
        {


           formLogin.ShowDialog();
           if(formLogin.Entradas==true)
            {
                InicioSesionDatos.CargarTreeView(tv_MenuBD);
                formLogin.Entradas = false;
                btn_Actualizar.Enabled = true;
                btn_Disconnect.Enabled = true;
            }
           else
            {

            }

            //formLogin.sInstancia = instancia;
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                if ((tv_MenuBD.SelectedNode.Text == null))
                {
                    MessageBox.Show("Selecciona el servidor del cual te quieres desconectar");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccion el servidor para desoncetarte","Vaya . . ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                
            string seleccion = tv_MenuBD.SelectedNode.Text;
                
          
               

            cb_BasesdeDatos.DataSource = null;
            if (a == 0)
            { 
                if (seleccion == InicioSesionDatos.servidor)
                {
                    tv_MenuBD.Nodes.Remove(tv_MenuBD.SelectedNode);
                    a++;
                }
               
            }
            btn_Disconnect.Enabled = false;

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if(tv_MenuBD.SelectedNode.Text!= null)
                seleccion = tv_MenuBD.SelectedNode.Text;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecciona servidor que se actualizará","Selección de servidor",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            tv_MenuBD.Nodes.Clear();
            if (seleccion==InicioSesionDatos.servidor)
            {
                opConexión.InicioSesionDatos.CargarTreeView(tv_MenuBD);

            }
          
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
                    File.WriteAllText(Nombre_Del_Archivo,rtb_Consultas.Text);
                    

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
