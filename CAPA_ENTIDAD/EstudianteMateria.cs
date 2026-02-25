using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{

       
        public class AreaTecnica
        {
            public int ID_AreaTecnica { get; set; }
            public string NombreArea { get; set; }
            public bool Estado { get; set; }
        }

        public class Estudiante
        {
            public int ID_Estudiante { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public int ID_AreaTecnica { get; set; }
        }

        public class Materia
        {
            public int ID_Materia { get; set; }
            public string Nombre { get; set; }
        }

        public class Profesor
        {
            public int ID_Profesor { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public int ID_AreaTecnica { get; set; }
            public bool Estado { get; set; }
        }

        public class EstudianteMateria
        {
            public int ID_Estudiantes_Mat { get; set; }
            public int ID_Estudiante { get; set; }
            public int ID_Materia { get; set; }
            public int ID_Profesor { get; set; }


            public string NombreEstudiante { get; set; }
            public string NombreMateria { get; set; }
            public string NombreProfesor { get; set; }
            public string NombreAreaTecnica { get; set; }
        }
    }



