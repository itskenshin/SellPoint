using System;
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
        private bool isCollapse;
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
            lblerror.Parent = pictureBox1;
            lblerror.BackColor = Color.Transparent;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (usernameField.Texts == String.Empty || passField.Texts == String.Empty ||
                phoneField.Texts == String.Empty || direccionField.Texts == String.Empty ||
                numeroDocField.Texts == String.Empty || localidadField.Texts == String.Empty || descripcionField.Texts == String.Empty)
            {
                lblerror.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel1.Height += 100;
                if(panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panel1.Height -= 100;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapse = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrupoEntidades_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoEntidades_Click(object sender, EventArgs e)
        {

        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalirr_Click(object sender, EventArgs e)
        {

        }

      

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel2.Height += 100;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panel2.Height -= 100;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapse = true;
                }
            }
        }

        private void btnArchivos_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSistema_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }

       
    }

