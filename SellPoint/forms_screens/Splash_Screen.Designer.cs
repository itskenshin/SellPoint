﻿namespace SellPoint
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Splashbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Splashbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Splashbox
            // 
            this.Splashbox.Image = ((System.Drawing.Image)(resources.GetObject("Splashbox.Image")));
            this.Splashbox.Location = new System.Drawing.Point(1, 1);
            this.Splashbox.Name = "Splashbox";
            this.Splashbox.Size = new System.Drawing.Size(907, 579);
            this.Splashbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Splashbox.TabIndex = 0;
            this.Splashbox.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 581);
            this.ControlBox = false;
            this.Controls.Add(this.Splashbox);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Splashbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Splashbox;
    }
}

