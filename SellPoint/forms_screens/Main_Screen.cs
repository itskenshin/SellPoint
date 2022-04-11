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
using Transacciones;
using Datos.Modelos;
namespace SellPoint.forms_screens
{
    public partial class Main_Screen : Form
    {
        Transacciones.Transacciones Transacciones = new Transacciones.Transacciones();
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
        // fecha y hora actual
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToShortTimeString();
            Fecha.Text = DateTime.Now.ToShortDateString();
        }


        private void Main_Screen_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Login_screen.guardar;
            // TODO: This line of code loads data into the 'sellPointDataSet1.Entidades' table. You can move, or remove it, as needed.
            this.entidadesTableAdapter.Fill(this.sellPointDataSet1.Entidades);
            // TODO: This line of code loads data into the 'sellPointDataSet.Entidades' table. You can move, or remove it, as needed.
            this.entidadesTableAdapter.Fill(this.sellPointDataSet.Entidades);
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
        // boton delete para la tabla de base datos
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = this.dataGridView.SelectedCells[0];
        }
        // Boton insertar en la tabla base de datos
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (usernameField.Texts == String.Empty || passField.Texts == String.Empty ||
                phoneField.Texts == String.Empty || direccionField.Texts == String.Empty ||
                numeroDocField.Texts == String.Empty || localidadField.Texts == String.Empty || descripcionField.Texts == String.Empty)
            {
                lblerror.Visible = true;
            }
            if (usernameField.Texts != String.Empty || passField.Texts != String.Empty ||
              phoneField.Texts != String.Empty || direccionField.Texts != String.Empty ||
              numeroDocField.Texts != String.Empty || localidadField.Texts != String.Empty || descripcionField.Texts != String.Empty)
            {
                Datos.Modelos.Entidades entidades = new Entidades();
                entidades.UserNameEntidad = usernameField.Texts;
                entidades.PasswordEntidad = passField.Texts;
                entidades.Telefonos = phoneField.Texts;
                entidades.Direccion = direccionField.Texts;
                entidades.NumeroDocumento = int.Parse(numeroDocField.Texts);
                entidades.Localidad = localidadField.Texts;
                entidades.Descripcion = descripcionField.Texts;
                Transacciones.AgregarEntidad(entidades);
                ActualizarTabla();
            }





        }
        // esto es para hacer el dropdown de los botones sistema y archivos
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel1.Height += 100;
                if (panel1.Size == panel1.MaximumSize)
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
        // va al mainscreen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen main_Screen = new Main_Screen();
            main_Screen.Show();

        }

        private void btnGrupoEntidades_Click(object sender, EventArgs e)
        {
            // ir al form grupo entidades
            grupoEntidadesScreen gr = new grupoEntidadesScreen();
            gr.Show();
        }

        private void btnTipoEntidades_Click(object sender, EventArgs e)
        {
            // ir al form tipoentidades
            tipoEntidadesScreen ts = new tipoEntidadesScreen();
            ts.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            // ir al form acerca de
            Acerca_de_Screen ac = new Acerca_de_Screen();
            ac.Show();
        }

        // boton que lleva al login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen ma = new Main_Screen();
            ma.Show();
        }
        // boton para salir del programa
        private void BtnSalirr_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // esto es para hacer el dropdown de los botones sistema y archivos
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
        // boton para abrir el dropdown de archivos
        private void btnArchivos_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // boton para abrir el dropdown de sistema
        private void btnSistema_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }
       

        private void getEntidadesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.entidadesTableAdapter.GetEntidades(this.sellPointDataSet.Entidades);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getEntiedadesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.entidadesTableAdapter.GetEntiedades(this.sellPointDataSet.Entidades);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();


        }


        private void ActualizarTabla()
        {
            var dataSource = Transacciones.ListaEntidades();
            this.dataGridView.DataSource = dataSource;
        }

        private void numeroDocField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       
    }
}




