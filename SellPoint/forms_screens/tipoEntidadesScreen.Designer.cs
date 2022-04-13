namespace SellPoint.forms_screens
{
    partial class tipoEntidadesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipoEntidadesScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelvali = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.insertBtn = new SellPoint.widgets.RJControls();
            this.rjControls1 = new SellPoint.widgets.RJControls();
            this.comboBoxtipoEntidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelvali
            // 
            this.labelvali.AutoSize = true;
            this.labelvali.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvali.ForeColor = System.Drawing.Color.Red;
            this.labelvali.Location = new System.Drawing.Point(82, 354);
            this.labelvali.Name = "labelvali";
            this.labelvali.Size = new System.Drawing.Size(109, 18);
            this.labelvali.TabIndex = 4;
            this.labelvali.Text = "Campos Vacio!";
            this.labelvali.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(92, 72);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(110, 20);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "usernameaqui";
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insertBtn.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insertBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.insertBtn.BorderRadius = 20;
            this.insertBtn.BorderSize = 0;
            this.insertBtn.FlatAppearance.BorderSize = 0;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(344, 344);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(403, 40);
            this.insertBtn.TabIndex = 6;
            this.insertBtn.Text = "INSERTAR";
            this.insertBtn.TextColor = System.Drawing.Color.White;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // rjControls1
            // 
            this.rjControls1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rjControls1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rjControls1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjControls1.BorderRadius = 10;
            this.rjControls1.BorderSize = 0;
            this.rjControls1.FlatAppearance.BorderSize = 0;
            this.rjControls1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjControls1.ForeColor = System.Drawing.Color.White;
            this.rjControls1.Location = new System.Drawing.Point(730, 0);
            this.rjControls1.Name = "rjControls1";
            this.rjControls1.Size = new System.Drawing.Size(49, 46);
            this.rjControls1.TabIndex = 9;
            this.rjControls1.Text = "Salir";
            this.rjControls1.TextColor = System.Drawing.Color.White;
            this.rjControls1.UseVisualStyleBackColor = false;
            this.rjControls1.Click += new System.EventHandler(this.rjControls1_Click);
            // 
            // comboBoxtipoEntidad
            // 
            this.comboBoxtipoEntidad.FormattingEnabled = true;
            this.comboBoxtipoEntidad.Items.AddRange(new object[] {
            "ejmeplo",
            "ejemplo"});
            this.comboBoxtipoEntidad.Location = new System.Drawing.Point(26, 203);
            this.comboBoxtipoEntidad.Name = "comboBoxtipoEntidad";
            this.comboBoxtipoEntidad.Size = new System.Drawing.Size(230, 21);
            this.comboBoxtipoEntidad.TabIndex = 10;
            // 
            // tipoEntidadesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 401);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxtipoEntidad);
            this.Controls.Add(this.rjControls1);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelvali);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tipoEntidadesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.tipoEntidadesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelvali;
        private System.Windows.Forms.Label labelUsername;
        private widgets.RJControls insertBtn;
        private widgets.RJControls rjControls1;
        private System.Windows.Forms.ComboBox comboBoxtipoEntidad;
    }
}