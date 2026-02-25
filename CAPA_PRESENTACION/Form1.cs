using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;
using System.Security.Cryptography;
namespace CAPA_PRESENTACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarAreas();
        }
        EstudianteBLL bll = new EstudianteBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource =
                bll.MostrarEstudiantes();
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtdireccio.Text,
                Telefono = teltxt.Text,
                Email = emailtxt.Text,
                ID_AreaTecnica = Convert.ToInt32(cmbAreaTecnica.SelectedValue)
            };
            bll.Guardar(est);
            dgvDatos.DataSource = bll.MostrarEstudiantes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Estudiante est = new Estudiante
                {
                    ID_Estudiante = Convert.ToInt32(dgvDatos.CurrentRow.Cells["ID_Estudiante"].Value),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtdireccio.Text,
                    Telefono = teltxt.Text,
                    Email = emailtxt.Text,
                    ID_AreaTecnica = Convert.ToInt32(cmbAreaTecnica.SelectedValue)

                };

                bll.Actualizar(est);
                dgvDatos.DataSource = bll.MostrarEstudiantes(); // refresca el grid

            }
        }




        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["ID_Estudiante"].Value);
            bll.Eliminar(id);
            dgvDatos.DataSource = bll.MostrarEstudiantes();
        }


        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatos.Rows[e.RowIndex];


                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                teltxt.Text = row.Cells["Telefono"].Value.ToString();
                txtdireccio.Text = row.Cells["Direccion"].Value.ToString();
                emailtxt.Text = row.Cells["Email"].Value.ToString();

                cmbAreaTecnica.Text = row.Cells["NombreArea"].Value.ToString();


            }

            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.MultiSelect = false;

        }


        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            string texto = Buscartxt.Text.Trim();
            dgvDatos.DataSource = bll.BuscarEstudiantes(texto);
        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            teltxt.Clear();
            txtApellido.Clear();
            txtdireccio.Clear();
            txtNombre.Clear();
            emailtxt.Clear();
            cmbAreaTecnica.SelectedIndex = -1;
        }

        private void Cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarAreas()
        {
            EstudianteBLL bll = new EstudianteBLL();

            cmbAreaTecnica.DataSource = bll.MostrarAreas();
            cmbAreaTecnica.DisplayMember = "NombreArea";
            cmbAreaTecnica.ValueMember = "ID_AreaTecnica";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Estudiante est = new Estudiante
                {
                    ID_Estudiante = Convert.ToInt32(dgvDatos.CurrentRow.Cells["ID_Estudiante"].Value),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtdireccio.Text,
                    Telefono = teltxt.Text,
                    Email = emailtxt.Text,
                    ID_AreaTecnica = Convert.ToInt32(cmbAreaTecnica.SelectedValue)

                };

                bll.Actualizar(est);
                dgvDatos.DataSource = bll.MostrarEstudiantes();

            }
        }

        private void cmbAreaTecnica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMaestro1 ventana = new frmMaestro1();
            ventana.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
