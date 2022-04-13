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
    public partial class tipoEntidadesScreen : Form
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
        public tipoEntidadesScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void tipoEntidadesScreen_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Login_screen.guardar;
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 1000, SellPoint.animation.winapi.BLEND);
            labelUsername.Parent = pictureBox1;
            labelUsername.BackColor = Color.Transparent;
            labelvali.Parent = pictureBox1;
            labelvali.BackColor = Color.Transparent;

        }
        // boton insertar en tabla
        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxtipoEntidad.Text == String.Empty)
            {
                labelvali.Visible = true;
            }
        }
        // boton actualizar
        private void actualiozabtn_Click(object sender, EventArgs e)
        {

        }
        //boton delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void rjControls1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
