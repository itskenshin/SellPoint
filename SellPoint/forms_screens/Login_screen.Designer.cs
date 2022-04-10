namespace SellPoint.forms_screens
{
    partial class Login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_validator_username = new System.Windows.Forms.Label();
            this.label_pass_vali = new System.Windows.Forms.Label();
            this.uservalidlabel = new System.Windows.Forms.Label();
            this.regibtn = new SellPoint.widgets.RJControls();
            this.btnSalir = new SellPoint.widgets.RJControls();
            this.btnlogin = new SellPoint.widgets.RJControls();
            this.pass_field = new SellPoint.widgets.textBox();
            this.username_box = new SellPoint.widgets.textBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_validator_username
            // 
            this.label_validator_username.AutoSize = true;
            this.label_validator_username.BackColor = System.Drawing.Color.Transparent;
            this.label_validator_username.ForeColor = System.Drawing.Color.Red;
            this.label_validator_username.Location = new System.Drawing.Point(928, 238);
            this.label_validator_username.Name = "label_validator_username";
            this.label_validator_username.Size = new System.Drawing.Size(104, 13);
            this.label_validator_username.TabIndex = 6;
            this.label_validator_username.Text = "Introduce tu usuario!";
            this.label_validator_username.Visible = false;
            // 
            // label_pass_vali
            // 
            this.label_pass_vali.AutoSize = true;
            this.label_pass_vali.BackColor = System.Drawing.Color.Transparent;
            this.label_pass_vali.ForeColor = System.Drawing.Color.Red;
            this.label_pass_vali.Location = new System.Drawing.Point(912, 321);
            this.label_pass_vali.Name = "label_pass_vali";
            this.label_pass_vali.Size = new System.Drawing.Size(123, 13);
            this.label_pass_vali.TabIndex = 7;
            this.label_pass_vali.Text = "Introduce tu contraseña!";
            this.label_pass_vali.Visible = false;
            // 
            // uservalidlabel
            // 
            this.uservalidlabel.AutoSize = true;
            this.uservalidlabel.BackColor = System.Drawing.Color.Transparent;
            this.uservalidlabel.ForeColor = System.Drawing.Color.Red;
            this.uservalidlabel.Location = new System.Drawing.Point(808, 413);
            this.uservalidlabel.Name = "uservalidlabel";
            this.uservalidlabel.Size = new System.Drawing.Size(85, 13);
            this.uservalidlabel.TabIndex = 10;
            this.uservalidlabel.Text = "Usuario invalido!";
            this.uservalidlabel.Visible = false;
            // 
            // regibtn
            // 
            this.regibtn.BackColor = System.Drawing.Color.DimGray;
            this.regibtn.BackgroundColor = System.Drawing.Color.DimGray;
            this.regibtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.regibtn.BorderRadius = 15;
            this.regibtn.BorderSize = 0;
            this.regibtn.FlatAppearance.BorderSize = 0;
            this.regibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regibtn.ForeColor = System.Drawing.Color.White;
            this.regibtn.Location = new System.Drawing.Point(772, 476);
            this.regibtn.Name = "regibtn";
            this.regibtn.Size = new System.Drawing.Size(135, 47);
            this.regibtn.TabIndex = 13;
            this.regibtn.Text = "Registrate";
            this.regibtn.TextColor = System.Drawing.Color.White;
            this.regibtn.UseVisualStyleBackColor = false;
            this.regibtn.Click += new System.EventHandler(this.regibtn_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 15;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(37, 582);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 29);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.SystemColors.Control;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Gray;
            this.btnlogin.BackgroundColor = System.Drawing.Color.Gray;
            this.btnlogin.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.BorderRadius = 15;
            this.btnlogin.BorderSize = 0;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(711, 357);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(273, 53);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "Acceder";
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pass_field
            // 
            this.pass_field.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pass_field.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pass_field.BorderFocusColor = System.Drawing.Color.Red;
            this.pass_field.BorderSize = 2;
            this.pass_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_field.ForeColor = System.Drawing.Color.White;
            this.pass_field.Location = new System.Drawing.Point(711, 273);
            this.pass_field.Margin = new System.Windows.Forms.Padding(4);
            this.pass_field.Multiline = false;
            this.pass_field.Name = "pass_field";
            this.pass_field.Padding = new System.Windows.Forms.Padding(7);
            this.pass_field.PasswordChar = true;
            this.pass_field.Size = new System.Drawing.Size(273, 31);
            this.pass_field.TabIndex = 2;
            this.pass_field.Texts = "";
            this.pass_field.UnderlineStyle = true;
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.username_box.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.username_box.BorderFocusColor = System.Drawing.Color.Red;
            this.username_box.BorderSize = 2;
            this.username_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.ForeColor = System.Drawing.Color.White;
            this.username_box.Location = new System.Drawing.Point(711, 203);
            this.username_box.Margin = new System.Windows.Forms.Padding(4);
            this.username_box.Multiline = false;
            this.username_box.Name = "username_box";
            this.username_box.Padding = new System.Windows.Forms.Padding(7);
            this.username_box.PasswordChar = false;
            this.username_box.Size = new System.Drawing.Size(273, 31);
            this.username_box.TabIndex = 1;
            this.username_box.Texts = "";
            this.username_box.UnderlineStyle = true;
            // 
            // Login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 623);
            this.ControlBox = false;
            this.Controls.Add(this.regibtn);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.uservalidlabel);
            this.Controls.Add(this.label_pass_vali);
            this.Controls.Add(this.label_validator_username);
            this.Controls.Add(this.pass_field);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private widgets.textBox username_box;
        private widgets.textBox pass_field;
        private System.Windows.Forms.Label label_validator_username;
        private System.Windows.Forms.Label label_pass_vali;
        private System.Windows.Forms.Label uservalidlabel;
        private widgets.RJControls btnlogin;
        private widgets.RJControls btnSalir;
        private widgets.RJControls regibtn;
    }
}