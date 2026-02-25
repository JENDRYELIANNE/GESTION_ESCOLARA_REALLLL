using CAPA_DATOS;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class EstudianteMateriaBLL
    {
      
            private EstudianteMateriaDAL dal = new EstudianteMateriaDAL();

          
   
        private string connectionString = "Data Source=JendryJ\\ELISQL;Initial Catalog=GESTION_ESCOLAR;Integrated Security=True";

        public DataTable ObtenerReporteAsignaciones(int estudianteId)
        {
            return dal.ReporteAsignacionesPorEstudiante(estudianteId);
        }



        // Otra consulta: materias que aún no tienen profesor asignado
        public DataTable ObtenerOtraConsulta(int estudianteId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT m.Nombre AS Materia, 'Sin profesor' AS Profesor
                FROM Estudiante_Materia em
                INNER JOIN Materia m ON em.ID_Materia = m.ID_Materia
                WHERE em.ID_Estudiante = @EstudianteId
                  AND em.ID_Profesor IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EstudianteId", estudianteId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }


        public List<EstudianteMateria> ObtenerAsignaciones()
            {
                DataTable dt = dal.ObtenerAsignaciones();
                List<EstudianteMateria> lista = new List<EstudianteMateria>();

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new EstudianteMateria
                    {
                        ID_Estudiantes_Mat = (int)row["id_Estudiantes_Mat"],
                        NombreEstudiante = row["Estudiante"].ToString(),
                        NombreAreaTecnica = row["AreaTecnica"].ToString(),
                        NombreMateria = row["Materia"].ToString(),
                        NombreProfesor = row["Profesor"].ToString()
                    });
                }

                return lista;
            }

            public void GuardarAsignacion(EstudianteMateria asignacion)
            {
                dal.InsertarAsignacion(asignacion.ID_Estudiante, asignacion.ID_Materia, asignacion.ID_Profesor);
            }

            public void EliminarAsignacion(int idAsignacion)
            {
                dal.EliminarAsignacion(idAsignacion);
            }

    }
}




   



