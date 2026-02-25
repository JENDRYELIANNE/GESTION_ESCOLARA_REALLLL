using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace CAPA_DATOS
{
    public class EstudianteMateriaDAL
    {

        private string connectionString =
            "Data Source=JendryJ\\ELISQL;Initial Catalog=GESTION_ESCOLAR;Integrated Security=True;TrustServerCertificate=True;";

       
        public DataTable ReporteAsignacionesPorEstudiante(int estudianteId)
        {
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ReporteAsignaciones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Estudiante", estudianteId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        


        public DataTable ObtenerAsignaciones()
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT em.id_Estudiantes_Mat,
                           e.Nombre + ' ' + e.Apellido AS Estudiante,
                           at.NombreArea AS AreaTecnica,
                           m.Nombre AS Materia,
                           p.Nombre + ' ' + p.Apellido AS Profesor
                    FROM Estudiante_Materia em
                    JOIN Estudiante e ON em.id_Estudiante = e.ID_Estudiante
                    JOIN AreaTecnica at ON e.ID_AreaTecnica = at.ID_AreaTecnica
                    JOIN Materia m ON em.id_Materia = m.ID_Materia
                    JOIN Profesor p ON em.id_Profesor = p.ID_Profesor", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public void InsertarAsignacion(int estudianteId, int materiaId, int profesorId)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Estudiante_Materia (id_Estudiante, id_Materia, id_Profesor) VALUES (@est, @mat, @prof)", con);
                    cmd.Parameters.AddWithValue("@est", estudianteId);
                    cmd.Parameters.AddWithValue("@mat", materiaId);
                    cmd.Parameters.AddWithValue("@prof", profesorId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            public void EliminarAsignacion(int idAsignacion)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Estudiante_Materia WHERE id_Estudiantes_Mat=@id", con);
                    cmd.Parameters.AddWithValue("@id", idAsignacion);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
       

    }
}






