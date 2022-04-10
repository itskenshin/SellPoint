namespace SellPoint.forms_screens
{
    partial class Registro_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new SellPoint.widgets.RJControls();
            this.btnsalir = new SellPoint.widgets.RJControls();
            this.btnusername = new SellPoint.widgets.textBox();
            this.btnpassword = new SellPoint.widgets.textBox();
            this.label_validator_username = new System.Windows.Forms.Label();
            this.label_pass_vali = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 598);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegister.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegister.BorderRadius = 20;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(37, 349);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(229, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Registrate";
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsalir.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnsalir.BorderRadius = 20;
            this.btnsalir.BorderSize = 0;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(46, 518);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(59, 40);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Atras";
            this.btnsalir.TextColor = System.Drawing.Color.White;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnusername
            // 
            this.btnusername.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnusername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnusername.BorderFocusColor = System.Drawing.Color.Red;
            this.btnusername.BorderSize = 2;
            this.btnusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusername.ForeColor = System.Drawing.Color.White;
            this.btnusername.Location = new System.Drawing.Point(13, 158);
            this.btnusername.Margin = new System.Windows.Forms.Padding(4);
            this.btnusername.Multiline = false;
            this.btnusername.Name = "btnusername";
            this.btnusername.Padding = new System.Windows.Forms.Padding(7);
            this.btnusername.PasswordChar = false;
            this.btnusername.Size = new System.Drawing.Size(283, 31);
            this.btnusername.TabIndex = 3;
            this.btnusername.Texts = "";
            this.btnusername.UnderlineStyle = true;
            // 
            // btnpassword
            // 
            this.btnpassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnpassword.BorderFocusColor = System.Drawing.Color.Red;
            this.btnpassword.BorderSize = 2;
            this.btnpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpassword.ForeColor = System.Drawing.Color.White;
            this.btnpassword.Location = new System.Drawing.Point(13, 243);
            this.btnpassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnpassword.Multiline = false;
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.Padding = new System.Windows.Forms.Padding(7);
            this.btnpassword.PasswordChar = true;
            this.btnpassword.Size = new System.Drawing.Size(283, 31);
            this.btnpassword.TabIndex = 4;
            this.btnpassword.Texts = "";
            this.btnpassword.UnderlineStyle = true;
            // 
            // label_validator_username
            // 
            this.label_validator_username.AutoSize = true;
            this.label_validator_username.BackColor = System.Drawing.Color.Transparent;
            this.label_validator_username.ForeColor = System.Drawing.Color.Red;
            this.label_validator_username.Location = new System.Drawing.Point(186, 193);
            this.label_validator_username.Name = "label_validator_username";
            this.label_validator_username.Size = new System.Drawing.Size(104, 13);
            this.label_validator_username.TabIndex = 7;
            this.label_validator_username.Text = "Introduce tu usuario!";
            this.label_validator_username.Visible = false;
            
            // 
            // label_pass_vali
            // 
            this.label_pass_vali.AutoSize = true;
            this.label_pass_vali.BackColor = System.Drawing.Color.Transparent;
            this.label_pass_vali.ForeColor = System.Drawing.Color.Red;
            this.label_pass_vali.Location = new System.Drawing.Point(186, 278);
            this.label_pass_vali.Name = "label_pass_vali";
            this.label_pass_vali.Size = new System.Drawing.Size(123, 13);
            this.label_pass_vali.TabIndex = 8;
            this.label_pass_vali.Text = "Introduce tu contraseña!";
            this.label_pass_vali.Visible = false;
            // 
            // Registro_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 582);
            this.ControlBox = false;
            this.Controls.Add(this.label_pass_vali);
            this.Controls.Add(this.label_validator_username);
            this.Controls.Add(this.btnpassword);
            this.Controls.Add(this.btnusername);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Registro_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private widgets.RJControls btnRegister;
        private widgets.RJControls btnsalir;
        private widgets.textBox btnusername;
        private widgets.textBox btnpassword;
        private System.Windows.Forms.Label label_validator_username;
        private System.Windows.Forms.Label label_pass_vali;
    }
}