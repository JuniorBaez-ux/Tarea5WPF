using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5WPF.Entidades
{
    public class RegistroEstudiantil
    {
        public string NombreEstudiante { get; set; }
        public int EdadEstudiante { get; set; }
        public string AulaEstudiante { get; set; }
        public DateTime FechaDeNacimientoEstudiante { get; set; }

        public RegistroEstudiantil()
        {
            NombreEstudiante = "";
            EdadEstudiante = 0;
            AulaEstudiante = "";
            FechaDeNacimientoEstudiante = DateTime.Now; 
        }

        public RegistroEstudiantil(string nombreestudiante, int edadestudiante, string aulaestudiante, DateTime fechadenacimientoestudiante)
        {
            NombreEstudiante = nombreestudiante;
            EdadEstudiante = edadestudiante;
            AulaEstudiante = aulaestudiante;
            FechaDeNacimientoEstudiante = fechadenacimientoestudiante;
        }
    }
}
