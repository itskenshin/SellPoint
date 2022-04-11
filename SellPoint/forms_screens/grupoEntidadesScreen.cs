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
    public partial class grupoEntidadesScreen : Form
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
        public grupoEntidadesScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void grupoEntidadesScreen_Load(object sender, EventArgs e)
        {
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 1000, SellPoint.animation.winapi.BLEND);
            labelValidation.Parent = pictureBox1;
            labelValidation.BackColor = Color.Transparent;
            labelUsuario.Parent = pictureBox1;
            labelUsuario.BackColor = Color.Transparent;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (idGrupoFieldtext.Texts == String.Empty || descripcionbox.Text == String.Empty)
            {
                labelValidation.Visible = true;
            }
        }

        private void atrasbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
