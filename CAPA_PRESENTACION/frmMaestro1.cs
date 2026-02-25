using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CAPA_ENTIDAD.EstudianteMateria;

namespace CAPA_PRESENTACION
{
    public partial class frmMaestro1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JendryJ\\ELISQL;Initial Catalog=GESTION_ESCOLAR;Integrated Security=True");

        

        public frmMaestro1()
        {
            InitializeComponent();
            CargarCombos();
            CargarGrid();
        }

        private void CargarCombos()
        { 

       SqlDataAdapter daEst = new SqlDataAdapter("SELECT ID_Estudiante, Nombre + ' ' + Apellido AS NombreCompleto FROM Estudiante WHERE Activo=1", con);
       DataTable dtEst = new DataTable();
       daEst.Fill(dtEst);
      estudiantecmb.DataSource = dtEst;
       estudiantecmb.DisplayMember ="NombreCompleto";
        estudiantecmb.ValueMember = "ID_Estudiante";


       SqlDataAdapter daProf = new SqlDataAdapter("SELECT ID_Profesor, Nombre + ' ' + Apellido AS NombreCompleto FROM Profesor WHERE Estado=1", con); 
       DataTable dtProf = new DataTable(); daProf.Fill(dtProf);
       maestrocmb.DataSource = dtProf; 
       maestrocmb.DisplayMember = "NombreCompleto";
       maestrocmb.ValueMember = "ID_Profesor";

       SqlDataAdapter daMat = new SqlDataAdapter("SELECT ID_Materia, Nombre FROM Materia", con);
       DataTable dtMat = new DataTable(); 
       daMat.Fill(dtMat);
       materiacmb.DataSource = dtMat;
       materiacmb.DisplayMember = "Nombre";
       materiacmb.ValueMember = "ID_Materia";
     
      SqlDataAdapter daArea = new SqlDataAdapter("SELECT ID_AreaTecnica, NombreArea FROM AreaTecnica WHERE Estado=1", con); 
      DataTable dtArea = new DataTable();
      daArea.Fill(dtArea); areacmb.DataSource = dtArea; areacmb.DisplayMember = "NombreArea";
      areacmb.ValueMember = "ID_AreaTecnica"; 
       }

        private void CargarGrid() { 
          SqlDataAdapter da = new SqlDataAdapter(@" SELECT em.id_Estudiantes_Mat, e.Nombre + ' ' + e.Apellido AS Estudiante, at.NombreArea AS AreaTecnica, m.Nombre AS Materia, p.Nombre + ' ' + p.Apellido AS Profesor FROM Estudiante_Materia em JOIN Estudiante e ON em.id_Estudiante = e.ID_Estudiante JOIN AreaTecnica at ON e.ID_AreaTecnica = at.ID_AreaTecnica JOIN Materia m ON em.id_Materia = m.ID_Materia JOIN Profesor p ON em.id_Profesor = p.ID_Profesor", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMaterias.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            estudiantecmb.SelectedIndex = -1;
            areacmb.SelectedIndex = -1;
            materiacmb.SelectedIndex = -1;
            maestrocmb.SelectedIndex = -1;

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void frmMaestro1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Estudiante_Materia (id_Estudiante, id_Materia, id_Profesor) VALUES (@est, @mat, @prof)", con); 
            cmd.Parameters.AddWithValue("@est", estudiantecmb.SelectedValue);
            cmd.Parameters.AddWithValue("@mat", materiacmb.SelectedValue);
            cmd.Parameters.AddWithValue("@prof", maestrocmb.SelectedValue);
            con.Open(); cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Asignación guardada correctamente.");
            CargarGrid();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow != null) { int id = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["id_Estudiantes_Mat"].Value);
                SqlCommand cmd = new SqlCommand("DELETE FROM Estudiante_Materia WHERE id_Estudiantes_Mat=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery(); 
                con.Close();
                MessageBox.Show("Asignación eliminada.");
                CargarGrid(); }
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verReportebtn_Click(object sender, EventArgs e)
        {
 
            if (dgvMaterias.CurrentRow != null)
            {
                int estudianteId = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["id_Estudiantes_Mat"].Value);

                using (FrmReporte frm = new FrmReporte(estudianteId))
                {
                    frm.ShowDialog();
                }
            }
        }

    }


}







