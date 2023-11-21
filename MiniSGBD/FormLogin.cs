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
using Microsoft.SqlServer.Management.Smo;

namespace MiniSGBD
{
    public partial class FormLogin : Form
    {
        public int iVeces = 0;
        public string sInstancia = string.Empty;
        public string sUsuario = string.Empty;
        public string sContra = string.Empty;
        public TreeView tv_MenuBd = new TreeView();
        public Boolean Entradas = false;
        List<FormPrincipal> lista = new List<FormPrincipal>();

        public FormLogin( int nVeces)
        {
            InitializeComponent();
            iVeces = nVeces;
        }
        



        private void tb_Usuario_Enter(object sender, EventArgs e)
        {

            if (tb_Usuario.Text == "USUARIO")
            {
                tb_Usuario.Text = "";
                tb_Usuario.ForeColor = Color.White;
                
            }

          
        }

        private void tb_Usuario_Leave(object sender, EventArgs e)
        {
            if (tb_Usuario.Text == "")
            {
                tb_Usuario.Text = "USUARIO";
                tb_Usuario.ForeColor = Color.LightGray;
              
            }
        }

        private void tb_Contraseña_Enter(object sender, EventArgs e)
        {
            if(tb_Contraseña.Text=="CONTRASEÑA")
            {
                tb_Contraseña.Text = "";
                tb_Contraseña.UseSystemPasswordChar = true;
                tb_Contraseña.ForeColor=Color.White;
            }
        }

        private void tb_Contraseña_Leave(object sender, EventArgs e)
        {
            if(tb_Contraseña.Text=="")
            {

                tb_Contraseña.UseSystemPasswordChar = false;
                tb_Contraseña.Text = "CONTRASEÑA";
                tb_Contraseña.ForeColor = Color.LightGray;
            }
        }

        private void pb_Cerrar_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tb_Usuario.Text = "USUARIO";
            tb_Usuario.ForeColor = Color.LightGray;

            if (tb_Contraseña.Text != "CONTRASEÑA")
            {
                tb_Contraseña.UseSystemPasswordChar = false;
                tb_Contraseña.Text = "CONTRASEÑA";
                tb_Contraseña.ForeColor = Color.LightGray;
            }


            this.FindForm().Close();
        }

        private void tb_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (opConexion.Conexion(comboBox1.Text, tb_Usuario.Text, tb_Contraseña.Text))
                {
                    sInstancia = comboBox1.Text;
                    FormPrincipal formPrincipal = new FormPrincipal();
                    if (iVeces == 0)
                    {
                        this.Hide();
                        formPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {

                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            Entradas = true;
            
            if (opConexion.Conexion(comboBox1.Text, tb_Usuario.Text, tb_Contraseña.Text))
            {
                

                //if (iVeces == 0)
                //{
                    
                //    this.Hide();
                //    this.Close();
                    opConexión.InicioSesionDatos.servidor= comboBox1.Text;
                    opConexión.InicioSesionDatos.usuario = tb_Usuario.Text;
                    opConexión.InicioSesionDatos.contra = tb_Contraseña.Text;
                    this.Close();
                    comboBox1.Text = "";
                //iVeces++;
                //}
                //else
                //{
                //    opConexión.InicioSesionDatos.servidor = comboBox1.Text;
                //    opConexión.InicioSesionDatos.usuario = tb_Usuario.Text;
                //    opConexión.InicioSesionDatos.contra = tb_Contraseña.Text;
                //    this.Hide();
                //    this.Close();
                //}

                tb_Usuario.Text = "USUARIO";
                tb_Usuario.ForeColor = Color.LightGray;

                if (tb_Contraseña.Text != "CONTRASEÑA")
                {
                    tb_Contraseña.UseSystemPasswordChar = false;
                    tb_Contraseña.Text = "CONTRASEÑA";
                    tb_Contraseña.ForeColor = Color.LightGray;
                }

            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void tb_Contraseña_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
