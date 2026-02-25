using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
    

    public class EstudianteDAL
    {
        private SqlConnection conn = new SqlConnection("Server=JENDRYJ\\ELISQL;Database=GESTION_ESCOLAR;Trusted_Connection=True;");

        public void Insertar(Estudiante est)
        { SqlCommand cmd = new SqlCommand("sp_InsertarEstudiante", conn);
            cmd.CommandType = CommandType.StoredProcedure; cmd.Parameters.AddWithValue("@Nombre", est.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", est.Apellido); cmd.Parameters.AddWithValue("@Direccion", est.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", est.Telefono); cmd.Parameters.AddWithValue("@Email", est.Email);
            cmd.Parameters.AddWithValue("@ID_AreaTecnica", est.ID_AreaTecnica); conn.Open(); cmd.ExecuteNonQuery(); conn.Close(); }
        public DataTable MostrarEstudiantes() { SqlDataAdapter da = new SqlDataAdapter
                ("SELECT e.ID_Estudiante, e.Nombre, e.Apellido, e.Telefono, e.Direccion, e.Email, a.NombreArea " +
                "FROM Estudiante e INNER JOIN AreaTecnica a ON e.ID_AreaTecnica = a.ID_AreaTecnica WHERE e.Activo = 1", 
                conn); DataTable dt = new DataTable(); da.Fill(dt); return dt; }

        public void Actualizar(Estudiante est)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarEstudiante", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Estudiante", est.ID_Estudiante);
            cmd.Parameters.AddWithValue("@Nombre", est.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", est.Apellido);
            cmd.Parameters.AddWithValue("@Direccion", est.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", est.Telefono);
            cmd.Parameters.AddWithValue("@Email", est.Email);
            cmd.Parameters.AddWithValue("@ID_AreaTecnica", est.ID_AreaTecnica);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarEstudiante", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Estudiante", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public DataTable Buscar(string texto)
        {
            SqlCommand cmd = new SqlCommand("sp_BuscarEstudiante", conn);
            cmd.CommandType = CommandType.StoredProcedure; cmd.Parameters.AddWithValue("@Texto", texto);
            SqlDataAdapter da =
                new SqlDataAdapter(cmd); DataTable dt = new DataTable(); da.Fill(dt); return dt;
        }

        public DataTable ObtenerAreas()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_AreaTecnica, NombreArea FROM AreaTecnica", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
} 
