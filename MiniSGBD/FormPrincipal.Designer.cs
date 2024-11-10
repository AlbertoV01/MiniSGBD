namespace MiniSGBD
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tv_MenuBD = new System.Windows.Forms.TreeView();
            this.dgv_Resultados = new System.Windows.Forms.DataGridView();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.pb_Minimizar = new System.Windows.Forms.PictureBox();
            this.pb_Restaurar = new System.Windows.Forms.PictureBox();
            this.pb_Maximizar = new System.Windows.Forms.PictureBox();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.pnl_SuperiorDch = new System.Windows.Forms.Panel();
            this.mStp_Opciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.cb_BasesdeDatos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolS_Menu = new System.Windows.Forms.ToolStrip();
            this.btn_Conect = new System.Windows.Forms.ToolStripButton();
            this.btn_Disconnect = new System.Windows.Forms.ToolStripButton();
            this.btn_Actualizar = new System.Windows.Forms.ToolStripButton();
            this.pnl_Dgv_Resultado = new System.Windows.Forms.Panel();
            this.lb_error = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtb_Consultas = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).BeginInit();
            this.pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            this.pnl_SuperiorDch.SuspendLayout();
            this.mStp_Opciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ToolS_Menu.SuspendLayout();
            this.pnl_Dgv_Resultado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_MenuBD
            // 
            this.tv_MenuBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_MenuBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.tv_MenuBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv_MenuBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_MenuBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tv_MenuBD.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.tv_MenuBD.Location = new System.Drawing.Point(0, 28);
            this.tv_MenuBD.Name = "tv_MenuBD";
            this.tv_MenuBD.Size = new System.Drawing.Size(137, 788);
            this.tv_MenuBD.TabIndex = 0;
            this.tv_MenuBD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_MenuBD_AfterSelect);
            // 
            // dgv_Resultados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.dgv_Resultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Resultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.dgv_Resultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Resultados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Resultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Resultados.Enabled = false;
            this.dgv_Resultados.EnableHeadersVisualStyles = false;
            this.dgv_Resultados.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Resultados.Location = new System.Drawing.Point(0, 0);
            this.dgv_Resultados.MultiSelect = false;
            this.dgv_Resultados.Name = "dgv_Resultados";
            this.dgv_Resultados.ReadOnly = true;
            this.dgv_Resultados.RowHeadersVisible = false;
            this.dgv_Resultados.Size = new System.Drawing.Size(1438, 283);
            this.dgv_Resultados.TabIndex = 0;
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.pnl_Superior.Controls.Add(this.pb_Minimizar);
            this.pnl_Superior.Controls.Add(this.pb_Restaurar);
            this.pnl_Superior.Controls.Add(this.pb_Maximizar);
            this.pnl_Superior.Controls.Add(this.pb_Cerrar);
            this.pnl_Superior.Controls.Add(this.pnl_SuperiorDch);
            this.pnl_Superior.Controls.Add(this.btn_Ejecutar);
            this.pnl_Superior.Controls.Add(this.cb_BasesdeDatos);
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(1584, 42);
            this.pnl_Superior.TabIndex = 5;
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::MiniSGBD.Properties.Resources._13163828031556282346_256;
            this.pb_Minimizar.Location = new System.Drawing.Point(1356, 3);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(71, 36);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimizar.TabIndex = 11;
            this.pb_Minimizar.TabStop = false;
            this.pb_Minimizar.Click += new System.EventHandler(this.pb_Minimizar_Click_1);
            // 
            // pb_Restaurar
            // 
            this.pb_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Restaurar.Image = global::MiniSGBD.Properties.Resources._111017710816362694595003_512;
            this.pb_Restaurar.Location = new System.Drawing.Point(1433, 3);
            this.pb_Restaurar.Name = "pb_Restaurar";
            this.pb_Restaurar.Size = new System.Drawing.Size(71, 36);
            this.pb_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Restaurar.TabIndex = 10;
            this.pb_Restaurar.TabStop = false;
            this.pb_Restaurar.Visible = false;
            this.pb_Restaurar.Click += new System.EventHandler(this.pb_Minimizar_Click);
            // 
            // pb_Maximizar
            // 
            this.pb_Maximizar.Image = global::MiniSGBD.Properties.Resources._159134281016362694555003_512;
            this.pb_Maximizar.Location = new System.Drawing.Point(1433, 0);
            this.pb_Maximizar.Name = "pb_Maximizar";
            this.pb_Maximizar.Size = new System.Drawing.Size(71, 36);
            this.pb_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Maximizar.TabIndex = 9;
            this.pb_Maximizar.TabStop = false;
            this.pb_Maximizar.Click += new System.EventHandler(this.pb_Actualizar_Click);
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::MiniSGBD.Properties.Resources._14192472521537355434_512;
            this.pb_Cerrar.Location = new System.Drawing.Point(1510, 3);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(71, 36);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 8;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // pnl_SuperiorDch
            // 
            this.pnl_SuperiorDch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.pnl_SuperiorDch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SuperiorDch.Controls.Add(this.mStp_Opciones);
            this.pnl_SuperiorDch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_SuperiorDch.Location = new System.Drawing.Point(0, 0);
            this.pnl_SuperiorDch.Name = "pnl_SuperiorDch";
            this.pnl_SuperiorDch.Size = new System.Drawing.Size(137, 42);
            this.pnl_SuperiorDch.TabIndex = 6;
            // 
            // mStp_Opciones
            // 
            this.mStp_Opciones.BackColor = System.Drawing.Color.Black;
            this.mStp_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mStp_Opciones.Location = new System.Drawing.Point(0, 0);
            this.mStp_Opciones.Name = "mStp_Opciones";
            this.mStp_Opciones.Size = new System.Drawing.Size(135, 24);
            this.mStp_Opciones.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarComoToolStripMenuItem,
            this.guardarComoToolStripMenuItem1});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.guardarComoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.guardarComoToolStripMenuItem.Text = "Abrir";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem1
            // 
            this.guardarComoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.guardarComoToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.guardarComoToolStripMenuItem1.Name = "guardarComoToolStripMenuItem1";
            this.guardarComoToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.guardarComoToolStripMenuItem1.Text = "Guardar Como . . .";
            this.guardarComoToolStripMenuItem1.Click += new System.EventHandler(this.guardarComoToolStripMenuItem1_Click);
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Ejecutar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.btn_Ejecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(149)))), ((int)(((byte)(59)))));
            this.btn_Ejecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.btn_Ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ejecutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btn_Ejecutar.Location = new System.Drawing.Point(289, 3);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(58, 23);
            this.btn_Ejecutar.TabIndex = 7;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // cb_BasesdeDatos
            // 
            this.cb_BasesdeDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.cb_BasesdeDatos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_BasesdeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BasesdeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_BasesdeDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.cb_BasesdeDatos.FormattingEnabled = true;
            this.cb_BasesdeDatos.Location = new System.Drawing.Point(162, 3);
            this.cb_BasesdeDatos.Name = "cb_BasesdeDatos";
            this.cb_BasesdeDatos.Size = new System.Drawing.Size(121, 21);
            this.cb_BasesdeDatos.TabIndex = 0;
            this.cb_BasesdeDatos.DropDown += new System.EventHandler(this.cb_BasesdeDatos_DropDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ToolS_Menu);
            this.panel1.Controls.Add(this.tv_MenuBD);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 819);
            this.panel1.TabIndex = 7;
            // 
            // ToolS_Menu
            // 
            this.ToolS_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.ToolS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Conect,
            this.btn_Disconnect,
            this.btn_Actualizar});
            this.ToolS_Menu.Location = new System.Drawing.Point(0, 0);
            this.ToolS_Menu.Name = "ToolS_Menu";
            this.ToolS_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolS_Menu.Size = new System.Drawing.Size(137, 25);
            this.ToolS_Menu.TabIndex = 0;
            // 
            // btn_Conect
            // 
            this.btn_Conect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Conect.Image = global::MiniSGBD.Properties.Resources.icons8_connected_50;
            this.btn_Conect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Conect.Name = "btn_Conect";
            this.btn_Conect.Size = new System.Drawing.Size(23, 22);
            this.btn_Conect.Text = "Conectar";
            this.btn_Conect.Click += new System.EventHandler(this.btn_Conect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Disconnect.Enabled = false;
            this.btn_Disconnect.Image = global::MiniSGBD.Properties.Resources.icons8_logout_rounded_down_50;
            this.btn_Disconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(23, 22);
            this.btn_Disconnect.Text = "Desconectar";
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Actualizar.Enabled = false;
            this.btn_Actualizar.Image = global::MiniSGBD.Properties.Resources.icons8_refresh_64;
            this.btn_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(23, 22);
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // pnl_Dgv_Resultado
            // 
            this.pnl_Dgv_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Dgv_Resultado.BackColor = System.Drawing.Color.RosyBrown;
            this.pnl_Dgv_Resultado.Controls.Add(this.lb_error);
            this.pnl_Dgv_Resultado.Controls.Add(this.dgv_Resultados);
            this.pnl_Dgv_Resultado.Location = new System.Drawing.Point(143, 575);
            this.pnl_Dgv_Resultado.Name = "pnl_Dgv_Resultado";
            this.pnl_Dgv_Resultado.Size = new System.Drawing.Size(1438, 283);
            this.pnl_Dgv_Resultado.TabIndex = 8;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.BackColor = System.Drawing.Color.RosyBrown;
            this.lb_error.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(3, 11);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 25);
            this.lb_error.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.rtb_Consultas);
            this.panel2.Location = new System.Drawing.Point(143, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1441, 521);
            this.panel2.TabIndex = 9;
            // 
            // rtb_Consultas
            // 
            this.rtb_Consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.rtb_Consultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Consultas.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Consultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.rtb_Consultas.Location = new System.Drawing.Point(0, 0);
            this.rtb_Consultas.Name = "rtb_Consultas";
            this.rtb_Consultas.Size = new System.Drawing.Size(1441, 521);
            this.rtb_Consultas.TabIndex = 0;
            this.rtb_Consultas.Text = "";
            this.rtb_Consultas.TextChanged += new System.EventHandler(this.rtb_Consultas_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Dgv_Resultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).EndInit();
            this.pnl_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            this.pnl_SuperiorDch.ResumeLayout(false);
            this.pnl_SuperiorDch.PerformLayout();
            this.mStp_Opciones.ResumeLayout(false);
            this.mStp_Opciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ToolS_Menu.ResumeLayout(false);
            this.ToolS_Menu.PerformLayout();
            this.pnl_Dgv_Resultado.ResumeLayout(false);
            this.pnl_Dgv_Resultado.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_MenuBD;
        private System.Windows.Forms.DataGridView dgv_Resultados;
        private System.Windows.Forms.Panel pnl_Superior;
        private System.Windows.Forms.Panel pnl_SuperiorDch;
        private System.Windows.Forms.ComboBox cb_BasesdeDatos;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Dgv_Resultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.RichTextBox rtb_Consultas;
        private System.Windows.Forms.ToolStrip ToolS_Menu;
        private System.Windows.Forms.ToolStripButton btn_Conect;
        private System.Windows.Forms.ToolStripButton btn_Disconnect;
        private System.Windows.Forms.ToolStripButton btn_Actualizar;
        private System.Windows.Forms.MenuStrip mStp_Opciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Restaurar;
        private System.Windows.Forms.PictureBox pb_Maximizar;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pb_Minimizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}