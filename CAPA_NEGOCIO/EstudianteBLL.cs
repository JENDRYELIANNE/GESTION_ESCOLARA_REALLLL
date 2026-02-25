using CAPA_DATOS;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class EstudianteBLL
    {
        EstudianteDAL dal = new EstudianteDAL();

        public DataTable MostrarEstudiantes()
        {
            return dal.MostrarEstudiantes();
        }
        public void Guardar(Estudiante est)
        {
            dal.Insertar(est);
        }

        public void Actualizar(Estudiante est)
        {
            dal.Actualizar(est);
        }

        public void Eliminar(int id)
        {
            dal.Eliminar(id);
        }

        public DataTable BuscarEstudiantes(string texto)
        { return dal.Buscar(texto); }

    
    public DataTable MostrarAreas() { return dal.ObtenerAreas(); }
    }

}
