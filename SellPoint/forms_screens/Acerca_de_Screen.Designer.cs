namespace SellPoint.forms_screens
{
    partial class Acerca_de_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acerca_de_Screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Salirbtn = new SellPoint.widgets.RJControls();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Salirbtn
            // 
            this.Salirbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Salirbtn.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Salirbtn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Salirbtn.BorderRadius = 1;
            this.Salirbtn.BorderSize = 2;
            this.Salirbtn.FlatAppearance.BorderSize = 0;
            this.Salirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salirbtn.ForeColor = System.Drawing.Color.White;
            this.Salirbtn.Location = new System.Drawing.Point(786, 0);
            this.Salirbtn.Name = "Salirbtn";
            this.Salirbtn.Size = new System.Drawing.Size(60, 29);
            this.Salirbtn.TabIndex = 1;
            this.Salirbtn.Text = "SALIR";
            this.Salirbtn.TextColor = System.Drawing.Color.White;
            this.Salirbtn.UseVisualStyleBackColor = false;
            this.Salirbtn.Click += new System.EventHandler(this.rjControls1_Click);
            // 
            // Acerca_de_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(844, 505);
            this.ControlBox = false;
            this.Controls.Add(this.Salirbtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acerca_de_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Acerca_de_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private widgets.RJControls Salirbtn;
    }
}