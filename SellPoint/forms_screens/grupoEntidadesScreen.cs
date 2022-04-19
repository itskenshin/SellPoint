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
using Datos.Modelos;

namespace SellPoint.forms_screens
{
    public partial class grupoEntidadesScreen : Form
    {
        Transacciones.Transacciones Transacciones = new Transacciones.Transacciones();
        public string _Descripcion{ get; set; }
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
        public grupoEntidadesScreen(string user = "")
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dataGridView1.DataSource = Transacciones.GrupoEntidadesLista();
            labelUsuario.Text = user;
            var value = Transacciones.GetGrupoIdByUsuario(user);

            //idGrupoFieldtext.Texts = value.Item1.ToString(); este campo lo elimine por que es el primary key se incrementa solo
            descripcionbox.Text = value.Item2.ToString();
        }

        private void grupoEntidadesScreen_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = Login_screen.guardar;
            SellPoint.animation.winapi.AnimateWindow(this.Handle, 1000, SellPoint.animation.winapi.BLEND);
            labelValidation.Parent = pictureBox1;
            labelValidation.BackColor = Color.Transparent;
            labelUsuario.Parent = pictureBox1;
            labelUsuario.BackColor = Color.Transparent;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (comentarioField.Text == String.Empty || descripcionbox.Text == String.Empty || comboBoxStatus.Text == String.Empty || comboBoxNoElimini.Text == String.Empty)
            {
                labelValidation.Visible = true;
            }
            var datos = CapturarDatos();

            var resutl = Transacciones.InsertarGrupoEntidad(datos);
            //agregar message box 

            ActualizarTabla();
        }

        private void atrasbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            var datos = CapturarDatos();
            var result = Transacciones.EliminarGrupoEntidad(datos.Descripcion);
            ActualizarTabla();
        }

        GruposEntidades CapturarDatos()
        {
            GruposEntidades entidades = new GruposEntidades();
            entidades.Descripcion = descripcionbox.Text;
            entidades.Comentario = comentarioField.Text;
            entidades.Status = comboBoxStatus.SelectedItem.ToString();
            if(comboBoxNoElimini.SelectedItem.ToString() == "False")
            {
                entidades.NoEliminable = "0";
            }
            else
            {
                entidades.NoEliminable = "1";
            }
            





            ActualizarTabla();
            return entidades;

        }
        private void ActualizarTabla()
        {
            var dataSource = Transacciones.GrupoEntidadesLista();
            this.dataGridView1.DataSource = dataSource;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            var datos = CapturarDatos();
            var resultados = Transacciones.ActulizarGrupoEntidad(datos,_Descripcion);
            //mostrar messagebox que se actualizo 
            ActualizarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var d = dataGridView1.Rows[e.RowIndex];
            var IdGrupoEntidad = d.Cells[0].Value.ToString();
            var Descripcion = d.Cells[1].Value.ToString();
            var Comentario = d.Cells[2].Value.ToString();
            var Status = d.Cells[3].Value.ToString();
            var NoEliminable = d.Cells[4].Value.ToString();
          _Descripcion= d.Cells[1].Value.ToString();
            descripcionbox.Text = Descripcion;
            comentarioField.Text = Comentario;
            comboBoxStatus.SelectedItem = Status;
            if(NoEliminable == "0")
            {
                comboBoxNoElimini.SelectedItem = "False";
            }
            else
            {
                comboBoxNoElimini.SelectedItem = "True";
            }
            
        }

    }
}
