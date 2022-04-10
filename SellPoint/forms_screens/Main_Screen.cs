﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SellPoint.forms_screens
{
    public partial class Main_Screen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (   // para poner las esquinas redondas
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Main_Screen()
        {   
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToShortTimeString();
            Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 2000, SellPoint.animation.winapi.BLEND);
            Hora.Parent = pictureBox1;
            Hora.BackColor = Color.Transparent;
            Fecha.Parent = pictureBox1;
            Fecha.BackColor = Color.Transparent;
            labelUsername.Parent = pictureBox1;
            labelUsername.BackColor = Color.Transparent;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }

       
    }

