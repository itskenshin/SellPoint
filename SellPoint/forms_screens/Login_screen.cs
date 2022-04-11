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
using Transacciones;

namespace SellPoint.forms_screens
{
    public partial class Login_screen : Form
    {

        
        public Transacciones.Transacciones _transacciones = new Transacciones.Transacciones();

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
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(1500);

            InitializeComponent();
            t.Abort();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Login_screen login = this;

        }


        public void StartForm()
        {
            Application.Run(new Splash());

        }

        private void Login_screen_Load(object sender, EventArgs e)
        {
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 1000, SellPoint.animation.winapi.BLEND);
            label_validator_username.Parent = pictureBox1;
            label_validator_username.BackColor = Color.Transparent;
            label_pass_vali.Parent = pictureBox1;
            label_pass_vali.BackColor = Color.Transparent;
            uservalidlabel.Parent = pictureBox1;
            uservalidlabel.BackColor = Color.Transparent;

        }


        //boton click login 
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (username_box.Texts == "")
            {
                label_validator_username.Visible = true;
            }

            if (pass_field.Texts == "")
            {
                label_pass_vali.Visible = true;
            }

            if (username_box.Texts != String.Empty && pass_field.Texts != String.Empty)
            {
                var result = _transacciones.Autenticacion(user: username_box.Texts, password: pass_field.Texts);
                if (result != null)
                {
                    if (result.UserNameEntidad == username_box.Texts && result.PasswordEntidad == pass_field.Texts)
                    {
                        this.Hide();
                        Main_Screen main = new Main_Screen();
                        main.Show();

                    }
                    else
                    {
                        uservalidlabel.Visible = true;
                    }
                }
            }

        }
        //boton para salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // boton para ir a la pantalla de registro
        private void regibtn_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Main_Screen r = new Main_Screen();
            r.Show();
        }


        }

     

    }

