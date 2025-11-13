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
using opConexión.GestorMotores;
using opConexión.MotoresBdd;

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
       readonly MotorSqlServer motorSql = new MotorSqlServer();
       readonly MotorMySql  motorMysql = new MotorMySql();
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
                InicioSesionDatos.Servidor = comboBox1.Text;
                InicioSesionDatos.Usuario = tb_Usuario.Text;
                InicioSesionDatos.Contra = tb_Contraseña.Text;
                InicioSesionDatos.Motor = cb_MotorBdd.Text;
                this.Close();
            }
        }
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            if(motorSql.Motor==cb_MotorBdd.Text)
            {

            if(MotorSqlServer.ProbarConexion(comboBox1.Text,tb_Usuario.Text, tb_Contraseña.Text))
            {
                // Guardar datos de conexión para usar en el formulario principal
                InicioSesionDatos.Servidor = comboBox1.Text;
                InicioSesionDatos.Usuario = tb_Usuario.Text;
                InicioSesionDatos.Contra = tb_Contraseña.Text;
                InicioSesionDatos.Motor = cb_MotorBdd.Text;
                // Limpieza de campos
                tb_Usuario.Text = "USUARIO";
                tb_Usuario.ForeColor = Color.LightGray;
                tb_Contraseña.UseSystemPasswordChar = false;
                tb_Contraseña.Text = "CONTRASEÑA";
                tb_Contraseña.ForeColor = Color.LightGray;

                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ha sucedido un error en la conexión");
                return;
            }
            }
            if(motorMysql.Motor==cb_MotorBdd.Text)
            {
                if (MotorMySql.ProbarConexion(comboBox1.Text, tb_Usuario.Text, tb_Contraseña.Text))
                {
                    // Guardar datos de conexión para usar en el formulario principal
                    InicioSesionDatos.Servidor = comboBox1.Text;
                    InicioSesionDatos.Usuario = tb_Usuario.Text;
                    InicioSesionDatos.Contra = tb_Contraseña.Text;
                    InicioSesionDatos.Motor = cb_MotorBdd.Text;
                    // Limpieza de campos
                    tb_Usuario.Text = "USUARIO";
                    tb_Usuario.ForeColor = Color.LightGray;
                    tb_Contraseña.UseSystemPasswordChar = false;
                    tb_Contraseña.Text = "CONTRASEÑA";
                    tb_Contraseña.ForeColor = Color.LightGray;

                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error en la conexión");
                    return;
                }


            }
            this.Close();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }
        private void tb_Contraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            return;
        }
    }
}
