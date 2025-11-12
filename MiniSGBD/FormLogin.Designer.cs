namespace MiniSGBD
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_MotorBdd = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pb_Cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(277, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 75);
            this.panel1.TabIndex = 0;
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::MiniSGBD.Properties.Resources._54b09d95986f55c91a5b3cc094256b6b;
            this.pb_Cerrar.Location = new System.Drawing.Point(445, 3);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(15, 14);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 1;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 26.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "L O G I N";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.tb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Usuario.Location = new System.Drawing.Point(447, 143);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(100, 24);
            this.tb_Usuario.TabIndex = 1;
            this.tb_Usuario.Text = "USUARIO";
            this.tb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Usuario.Enter += new System.EventHandler(this.tb_Usuario_Enter);
            this.tb_Usuario.Leave += new System.EventHandler(this.tb_Usuario_Leave);
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.tb_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contraseña.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Contraseña.Location = new System.Drawing.Point(414, 173);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.Size = new System.Drawing.Size(162, 24);
            this.tb_Contraseña.TabIndex = 2;
            this.tb_Contraseña.Text = "CONTRASEÑA";
            this.tb_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Contraseña.TextChanged += new System.EventHandler(this.tb_Contraseña_TextChanged);
            this.tb_Contraseña.Enter += new System.EventHandler(this.tb_Contraseña_Enter);
            this.tb_Contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Contraseña_KeyUp);
            this.tb_Contraseña.Leave += new System.EventHandler(this.tb_Contraseña_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "POTAXIO",
            "DESKTOP-OJPGJ86"});
            this.comboBox1.Location = new System.Drawing.Point(434, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.btn_Conectar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.btn_Conectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.btn_Conectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btn_Conectar.Location = new System.Drawing.Point(267, 227);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(473, 32);
            this.btn_Conectar.TabIndex = 4;
            this.btn_Conectar.Text = "CONECTAR";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::MiniSGBD.Properties.Resources.Uusario2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 291);
            this.panel2.TabIndex = 6;
            // 
            // cb_MotorBdd
            // 
            this.cb_MotorBdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_MotorBdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.cb_MotorBdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_MotorBdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.cb_MotorBdd.FormattingEnabled = true;
            this.cb_MotorBdd.Items.AddRange(new object[] {
            "SQL Server",
            "MySql"});
            this.cb_MotorBdd.Location = new System.Drawing.Point(434, 116);
            this.cb_MotorBdd.Name = "cb_MotorBdd";
            this.cb_MotorBdd.Size = new System.Drawing.Size(130, 21);
            this.cb_MotorBdd.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(740, 291);
            this.Controls.Add(this.cb_MotorBdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_Contraseña);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO DE SESIÓN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_MotorBdd;
    }
}

