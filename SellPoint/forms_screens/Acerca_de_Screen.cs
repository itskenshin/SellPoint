﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SellPoint.forms_screens
{
    public partial class Acerca_de_Screen : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Acerca_de_Screen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void rjControls1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Acerca_de_Screen_Load(object sender, EventArgs e)
        {
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 1000, SellPoint.animation.winapi.BLEND);
        }
    }

    }
}

