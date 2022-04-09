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
            this.pass_field = new SellPoint.widgets.textBox();
            this.username_box = new SellPoint.widgets.textBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.pass_field.Load += new System.EventHandler(this.pass_field_Load);
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
            this.username_box.Load += new System.EventHandler(this.username_box_Load_1);
            // 
            // Login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 623);
            this.ControlBox = false;
            this.Controls.Add(this.pass_field);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private widgets.textBox username_box;
        private widgets.textBox pass_field;
    }
}