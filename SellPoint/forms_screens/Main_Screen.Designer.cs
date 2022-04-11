namespace SellPoint.forms_screens
{
    partial class Main_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            this.Hora = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsert = new SellPoint.widgets.RJControls();
            this.btnActualizar = new SellPoint.widgets.RJControls();
            this.btnDelete = new SellPoint.widgets.RJControls();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.usernameField = new SellPoint.widgets.textBox();
            this.passField = new SellPoint.widgets.textBox();
            this.phoneField = new SellPoint.widgets.textBox();
            this.descripcionField = new SellPoint.widgets.textBox();
            this.numeroDocField = new SellPoint.widgets.textBox();
            this.localidadField = new SellPoint.widgets.textBox();
            this.direccionField = new SellPoint.widgets.textBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblerror = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.BtnSalirr = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnEntidades = new System.Windows.Forms.Button();
            this.btnTipoEntidades = new System.Windows.Forms.Button();
            this.btnGrupoEntidades = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.White;
            this.Hora.Location = new System.Drawing.Point(84, 93);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(33, 13);
            this.Hora.TabIndex = 1;
            this.Hora.Text = "Hora";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.SystemColors.Control;
            this.Fecha.Location = new System.Drawing.Point(94, 77);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(41, 13);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "Fecha";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(907, 535);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsert.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderRadius = 20;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(279, 468);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 40);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "INSERTAR";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualizar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 20;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(486, 468);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(698, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(12, 503);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(23, 21);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnback.TabIndex = 6;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(64, 53);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(136, 17);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "aqui va el username";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameField.BorderFocusColor = System.Drawing.Color.Red;
            this.usernameField.BorderSize = 2;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameField.Location = new System.Drawing.Point(12, 145);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameField.Multiline = false;
            this.usernameField.Name = "usernameField";
            this.usernameField.Padding = new System.Windows.Forms.Padding(7);
            this.usernameField.PasswordChar = false;
            this.usernameField.Size = new System.Drawing.Size(209, 31);
            this.usernameField.TabIndex = 8;
            this.usernameField.Texts = "";
            this.usernameField.UnderlineStyle = false;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passField.BorderFocusColor = System.Drawing.Color.Red;
            this.passField.BorderSize = 2;
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.ForeColor = System.Drawing.SystemColors.Control;
            this.passField.Location = new System.Drawing.Point(13, 200);
            this.passField.Margin = new System.Windows.Forms.Padding(4);
            this.passField.Multiline = false;
            this.passField.Name = "passField";
            this.passField.Padding = new System.Windows.Forms.Padding(7);
            this.passField.PasswordChar = true;
            this.passField.Size = new System.Drawing.Size(209, 31);
            this.passField.TabIndex = 9;
            this.passField.Texts = "";
            this.passField.UnderlineStyle = false;
            // 
            // phoneField
            // 
            this.phoneField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneField.BorderFocusColor = System.Drawing.Color.Red;
            this.phoneField.BorderSize = 2;
            this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneField.ForeColor = System.Drawing.SystemColors.Control;
            this.phoneField.Location = new System.Drawing.Point(12, 252);
            this.phoneField.Margin = new System.Windows.Forms.Padding(4);
            this.phoneField.Multiline = false;
            this.phoneField.Name = "phoneField";
            this.phoneField.Padding = new System.Windows.Forms.Padding(7);
            this.phoneField.PasswordChar = false;
            this.phoneField.Size = new System.Drawing.Size(209, 31);
            this.phoneField.TabIndex = 10;
            this.phoneField.Texts = "";
            this.phoneField.UnderlineStyle = false;
            // 
            // descripcionField
            // 
            this.descripcionField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descripcionField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descripcionField.BorderFocusColor = System.Drawing.Color.Red;
            this.descripcionField.BorderSize = 2;
            this.descripcionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionField.ForeColor = System.Drawing.SystemColors.Control;
            this.descripcionField.Location = new System.Drawing.Point(12, 305);
            this.descripcionField.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionField.Multiline = false;
            this.descripcionField.Name = "descripcionField";
            this.descripcionField.Padding = new System.Windows.Forms.Padding(7);
            this.descripcionField.PasswordChar = false;
            this.descripcionField.Size = new System.Drawing.Size(209, 31);
            this.descripcionField.TabIndex = 11;
            this.descripcionField.Texts = "";
            this.descripcionField.UnderlineStyle = false;
            // 
            // numeroDocField
            // 
            this.numeroDocField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numeroDocField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numeroDocField.BorderFocusColor = System.Drawing.Color.Red;
            this.numeroDocField.BorderSize = 2;
            this.numeroDocField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDocField.ForeColor = System.Drawing.SystemColors.Control;
            this.numeroDocField.Location = new System.Drawing.Point(12, 357);
            this.numeroDocField.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDocField.Multiline = false;
            this.numeroDocField.Name = "numeroDocField";
            this.numeroDocField.Padding = new System.Windows.Forms.Padding(7);
            this.numeroDocField.PasswordChar = false;
            this.numeroDocField.Size = new System.Drawing.Size(209, 31);
            this.numeroDocField.TabIndex = 12;
            this.numeroDocField.Texts = "";
            this.numeroDocField.UnderlineStyle = false;
            // 
            // localidadField
            // 
            this.localidadField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.localidadField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.localidadField.BorderFocusColor = System.Drawing.Color.Red;
            this.localidadField.BorderSize = 2;
            this.localidadField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadField.ForeColor = System.Drawing.SystemColors.Control;
            this.localidadField.Location = new System.Drawing.Point(12, 406);
            this.localidadField.Margin = new System.Windows.Forms.Padding(4);
            this.localidadField.Multiline = false;
            this.localidadField.Name = "localidadField";
            this.localidadField.Padding = new System.Windows.Forms.Padding(7);
            this.localidadField.PasswordChar = false;
            this.localidadField.Size = new System.Drawing.Size(209, 31);
            this.localidadField.TabIndex = 13;
            this.localidadField.Texts = "";
            this.localidadField.UnderlineStyle = false;
            // 
            // direccionField
            // 
            this.direccionField.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.direccionField.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.direccionField.BorderFocusColor = System.Drawing.Color.Red;
            this.direccionField.BorderSize = 2;
            this.direccionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionField.ForeColor = System.Drawing.SystemColors.Control;
            this.direccionField.Location = new System.Drawing.Point(12, 459);
            this.direccionField.Margin = new System.Windows.Forms.Padding(4);
            this.direccionField.Multiline = false;
            this.direccionField.Name = "direccionField";
            this.direccionField.Padding = new System.Windows.Forms.Padding(7);
            this.direccionField.PasswordChar = false;
            this.direccionField.Size = new System.Drawing.Size(209, 31);
            this.direccionField.TabIndex = 14;
            this.direccionField.Texts = "";
            this.direccionField.UnderlineStyle = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(243, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(634, 385);
            this.dataGridView.TabIndex = 15;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(240, 53);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(184, 17);
            this.lblerror.TabIndex = 16;
            this.lblerror.Text = "Completa todos los campos!";
            this.lblerror.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSistema);
            this.panel2.Controls.Add(this.btnAcerca);
            this.panel2.Controls.Add(this.BtnSalirr);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Location = new System.Drawing.Point(551, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(115, 126);
            this.panel2.MinimumSize = new System.Drawing.Size(115, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 27);
            this.panel2.TabIndex = 19;
            // 
            // btnSistema
            // 
            this.btnSistema.BackColor = System.Drawing.Color.Transparent;
            this.btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSistema.Location = new System.Drawing.Point(0, 0);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(115, 27);
            this.btnSistema.TabIndex = 5;
            this.btnSistema.Text = "SISTEMA";
            this.btnSistema.UseVisualStyleBackColor = false;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click_1);
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.Transparent;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcerca.Location = new System.Drawing.Point(0, 32);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(115, 27);
            this.btnAcerca.TabIndex = 1;
            this.btnAcerca.Text = "Acerca de Nosotros";
            this.btnAcerca.UseVisualStyleBackColor = false;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // BtnSalirr
            // 
            this.BtnSalirr.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalirr.Location = new System.Drawing.Point(0, 96);
            this.BtnSalirr.Name = "BtnSalirr";
            this.BtnSalirr.Size = new System.Drawing.Size(115, 28);
            this.BtnSalirr.TabIndex = 3;
            this.BtnSalirr.Text = "Salir";
            this.BtnSalirr.UseVisualStyleBackColor = false;
            this.BtnSalirr.Click += new System.EventHandler(this.BtnSalirr_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(0, 65);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnArchivos);
            this.panel1.Controls.Add(this.btnEntidades);
            this.panel1.Controls.Add(this.btnTipoEntidades);
            this.panel1.Controls.Add(this.btnGrupoEntidades);
            this.panel1.Location = new System.Drawing.Point(439, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(115, 126);
            this.panel1.MinimumSize = new System.Drawing.Size(115, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 27);
            this.panel1.TabIndex = 20;
            // 
            // btnArchivos
            // 
            this.btnArchivos.BackColor = System.Drawing.Color.Transparent;
            this.btnArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArchivos.Location = new System.Drawing.Point(0, 0);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(115, 27);
            this.btnArchivos.TabIndex = 4;
            this.btnArchivos.Text = "ARCHIVOS";
            this.btnArchivos.UseVisualStyleBackColor = false;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click_1);
            // 
            // btnEntidades
            // 
            this.btnEntidades.BackColor = System.Drawing.Color.Transparent;
            this.btnEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntidades.Location = new System.Drawing.Point(0, 32);
            this.btnEntidades.Name = "btnEntidades";
            this.btnEntidades.Size = new System.Drawing.Size(115, 27);
            this.btnEntidades.TabIndex = 1;
            this.btnEntidades.Text = "Entidades";
            this.btnEntidades.UseVisualStyleBackColor = false;
            this.btnEntidades.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTipoEntidades
            // 
            this.btnTipoEntidades.BackColor = System.Drawing.Color.Transparent;
            this.btnTipoEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoEntidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTipoEntidades.Location = new System.Drawing.Point(0, 96);
            this.btnTipoEntidades.Name = "btnTipoEntidades";
            this.btnTipoEntidades.Size = new System.Drawing.Size(115, 28);
            this.btnTipoEntidades.TabIndex = 3;
            this.btnTipoEntidades.Text = "Tipo Entidades";
            this.btnTipoEntidades.UseVisualStyleBackColor = false;
            this.btnTipoEntidades.Click += new System.EventHandler(this.btnTipoEntidades_Click);
            // 
            // btnGrupoEntidades
            // 
            this.btnGrupoEntidades.BackColor = System.Drawing.Color.Transparent;
            this.btnGrupoEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupoEntidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrupoEntidades.Location = new System.Drawing.Point(0, 65);
            this.btnGrupoEntidades.Name = "btnGrupoEntidades";
            this.btnGrupoEntidades.Size = new System.Drawing.Size(115, 25);
            this.btnGrupoEntidades.TabIndex = 2;
            this.btnGrupoEntidades.Text = "Grupo Entidades";
            this.btnGrupoEntidades.UseVisualStyleBackColor = false;
            this.btnGrupoEntidades.Click += new System.EventHandler(this.btnGrupoEntidades_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.direccionField);
            this.Controls.Add(this.localidadField);
            this.Controls.Add(this.numeroDocField);
            this.Controls.Add(this.descripcionField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Screen";
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private widgets.RJControls btnInsert;
        private widgets.RJControls btnActualizar;
        private widgets.RJControls btnDelete;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Label labelUsername;
        private widgets.textBox usernameField;
        private widgets.textBox passField;
        private widgets.textBox phoneField;
        private widgets.textBox descripcionField;
        private widgets.textBox numeroDocField;
        private widgets.textBox localidadField;
        private widgets.textBox direccionField;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button BtnSalirr;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEntidades;
        private System.Windows.Forms.Button btnTipoEntidades;
        private System.Windows.Forms.Button btnGrupoEntidades;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnArchivos;
    }
}