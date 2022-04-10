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
            this.textBox1 = new SellPoint.widgets.textBox();
            this.textBox2 = new SellPoint.widgets.textBox();
            this.textBox3 = new SellPoint.widgets.textBox();
            this.textBox4 = new SellPoint.widgets.textBox();
            this.textBox5 = new SellPoint.widgets.textBox();
            this.textBox6 = new SellPoint.widgets.textBox();
            this.textBox7 = new SellPoint.widgets.textBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnback.BackColor = System.Drawing.Color.DimGray;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(12, 503);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(23, 21);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnback.TabIndex = 6;
            this.btnback.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox1.BorderSize = 2;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(12, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox1.PasswordChar = false;
            this.textBox1.Size = new System.Drawing.Size(209, 31);
            this.textBox1.TabIndex = 8;
            this.textBox1.Texts = "";
            this.textBox1.UnderlineStyle = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox2.BorderSize = 2;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(13, 200);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(7);
            this.textBox2.PasswordChar = false;
            this.textBox2.Size = new System.Drawing.Size(209, 31);
            this.textBox2.TabIndex = 9;
            this.textBox2.Texts = "";
            this.textBox2.UnderlineStyle = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox3.BorderSize = 2;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(12, 252);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.Padding = new System.Windows.Forms.Padding(7);
            this.textBox3.PasswordChar = false;
            this.textBox3.Size = new System.Drawing.Size(209, 31);
            this.textBox3.TabIndex = 10;
            this.textBox3.Texts = "";
            this.textBox3.UnderlineStyle = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox4.BorderSize = 2;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(12, 305);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = false;
            this.textBox4.Name = "textBox4";
            this.textBox4.Padding = new System.Windows.Forms.Padding(7);
            this.textBox4.PasswordChar = false;
            this.textBox4.Size = new System.Drawing.Size(209, 31);
            this.textBox4.TabIndex = 11;
            this.textBox4.Texts = "";
            this.textBox4.UnderlineStyle = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox5.BorderSize = 2;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(12, 357);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = false;
            this.textBox5.Name = "textBox5";
            this.textBox5.Padding = new System.Windows.Forms.Padding(7);
            this.textBox5.PasswordChar = false;
            this.textBox5.Size = new System.Drawing.Size(209, 31);
            this.textBox5.TabIndex = 12;
            this.textBox5.Texts = "";
            this.textBox5.UnderlineStyle = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox6.BorderSize = 2;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(12, 406);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = false;
            this.textBox6.Name = "textBox6";
            this.textBox6.Padding = new System.Windows.Forms.Padding(7);
            this.textBox6.PasswordChar = false;
            this.textBox6.Size = new System.Drawing.Size(209, 31);
            this.textBox6.TabIndex = 13;
            this.textBox6.Texts = "";
            this.textBox6.UnderlineStyle = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox7.BorderSize = 2;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox7.Location = new System.Drawing.Point(12, 459);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = false;
            this.textBox7.Name = "textBox7";
            this.textBox7.Padding = new System.Windows.Forms.Padding(7);
            this.textBox7.PasswordChar = false;
            this.textBox7.Size = new System.Drawing.Size(209, 31);
            this.textBox7.TabIndex = 14;
            this.textBox7.Texts = "";
            this.textBox7.UnderlineStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 385);
            this.dataGridView1.TabIndex = 15;
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 536);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private widgets.textBox textBox1;
        private widgets.textBox textBox2;
        private widgets.textBox textBox3;
        private widgets.textBox textBox4;
        private widgets.textBox textBox5;
        private widgets.textBox textBox6;
        private widgets.textBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}