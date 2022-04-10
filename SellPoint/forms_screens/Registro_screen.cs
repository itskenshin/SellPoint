using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPoint.forms_screens
{
    public partial class Registro_screen : Form
    {
        public Registro_screen()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            
            Login_screen nl = new Login_screen();
            nl.Show();
            this.Visible = false;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (btnusername.Texts == "")
            {
                label_validator_username.Visible = true;
            }

            if (btnpassword.Texts == "")
            {
                label_pass_vali.Visible = true;
            }
        }

        private void Registro_screen_Load(object sender, EventArgs e)
        {
            label_validator_username.Parent = pictureBox1;
            label_validator_username.BackColor = Color.Transparent;
            label_pass_vali.Parent = pictureBox1;
            label_pass_vali.BackColor = Color.Transparent;
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 2000, SellPoint.animation.winapi.VER_POSTIVE);
            
            
        }
    }
}
