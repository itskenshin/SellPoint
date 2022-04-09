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
using System.Threading;

namespace SellPoint.forms_screens
{
    public partial class Login_screen : Form
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
        public Login_screen()
        { Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(4000);
            
            InitializeComponent();
            t.Abort();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        public void StartForm()
        {
            Application.Run(new Splash());

        }

        private void username_box_Load(object sender, EventArgs e)
        {

        }

        private void username_box_Load_1(object sender, EventArgs e)
        {

        }

        private void pass_field_Load(object sender, EventArgs e)
        {

        }
    }
}
