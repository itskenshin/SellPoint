namespace SellPoint.forms_screens
{
    partial class grupoEntidadesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grupoEntidadesScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btninsert = new SellPoint.widgets.RJControls();
            this.btndelete = new SellPoint.widgets.RJControls();
            this.btnactualizar = new SellPoint.widgets.RJControls();
            this.descripcionbox = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelValidation = new System.Windows.Forms.Label();
            this.atrasbtn = new SellPoint.widgets.RJControls();
            this.comentarioField = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxNoElimini = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 363);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 215);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btninsert.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btninsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btninsert.BorderRadius = 20;
            this.btninsert.BorderSize = 0;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(358, 300);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(92, 40);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "INSERTAR";
            this.btninsert.TextColor = System.Drawing.Color.White;
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btndelete.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btndelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndelete.BorderRadius = 20;
            this.btndelete.BorderSize = 0;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(492, 300);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 40);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "ELIMINAR";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnactualizar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnactualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnactualizar.BorderRadius = 20;
            this.btnactualizar.BorderSize = 0;
            this.btnactualizar.FlatAppearance.BorderSize = 0;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Location = new System.Drawing.Point(624, 300);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(83, 40);
            this.btnactualizar.TabIndex = 6;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.TextColor = System.Drawing.Color.White;
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // descripcionbox
            // 
            this.descripcionbox.Location = new System.Drawing.Point(12, 142);
            this.descripcionbox.Multiline = true;
            this.descripcionbox.Name = "descripcionbox";
            this.descripcionbox.Size = new System.Drawing.Size(266, 41);
            this.descripcionbox.TabIndex = 7;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsuario.Location = new System.Drawing.Point(67, 63);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(143, 18);
            this.labelUsuario.TabIndex = 8;
            this.labelUsuario.Text = "nombre usuario aqui";
            // 
            // labelValidation
            // 
            this.labelValidation.AutoSize = true;
            this.labelValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidation.ForeColor = System.Drawing.Color.Red;
            this.labelValidation.Location = new System.Drawing.Point(474, 279);
            this.labelValidation.Name = "labelValidation";
            this.labelValidation.Size = new System.Drawing.Size(115, 18);
            this.labelValidation.TabIndex = 9;
            this.labelValidation.Text = "Campos vacios!";
            this.labelValidation.Visible = false;
            // 
            // atrasbtn
            // 
            this.atrasbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.atrasbtn.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.atrasbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.atrasbtn.BorderRadius = 20;
            this.atrasbtn.BorderSize = 0;
            this.atrasbtn.FlatAppearance.BorderSize = 0;
            this.atrasbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atrasbtn.ForeColor = System.Drawing.Color.White;
            this.atrasbtn.Location = new System.Drawing.Point(706, -1);
            this.atrasbtn.Name = "atrasbtn";
            this.atrasbtn.Size = new System.Drawing.Size(54, 48);
            this.atrasbtn.TabIndex = 10;
            this.atrasbtn.Text = "Cerrar";
            this.atrasbtn.TextColor = System.Drawing.Color.White;
            this.atrasbtn.UseVisualStyleBackColor = false;
            this.atrasbtn.Click += new System.EventHandler(this.atrasbtn_Click);
            // 
            // comentarioField
            // 
            this.comentarioField.Location = new System.Drawing.Point(12, 214);
            this.comentarioField.Multiline = true;
            this.comentarioField.Name = "comentarioField";
            this.comentarioField.Size = new System.Drawing.Size(266, 31);
            this.comentarioField.TabIndex = 11;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.comboBoxStatus.Location = new System.Drawing.Point(70, 256);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 12;
            this.comboBoxStatus.Text = "Activa ";
            // 
            // comboBoxNoElimini
            // 
            this.comboBoxNoElimini.FormattingEnabled = true;
            this.comboBoxNoElimini.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxNoElimini.Location = new System.Drawing.Point(112, 319);
            this.comboBoxNoElimini.Name = "comboBoxNoElimini";
            this.comboBoxNoElimini.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoElimini.TabIndex = 13;
            this.comboBoxNoElimini.Text = "False";
            // 
            // grupoEntidadesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 362);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxNoElimini);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comentarioField);
            this.Controls.Add(this.atrasbtn);
            this.Controls.Add(this.labelValidation);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.descripcionbox);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "grupoEntidadesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grupoEntidadesScreen";
            this.Load += new System.EventHandler(this.grupoEntidadesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private widgets.RJControls btninsert;
        private widgets.RJControls btndelete;
        private widgets.RJControls btnactualizar;
        private System.Windows.Forms.TextBox descripcionbox;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelValidation;
        private widgets.RJControls atrasbtn;
        private System.Windows.Forms.TextBox comentarioField;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxNoElimini;
    }
}