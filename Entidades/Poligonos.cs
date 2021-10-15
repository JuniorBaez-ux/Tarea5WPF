using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5WPF.Entidades
{
    public class Poligonos
    {
        public int Lados { get; set; }
        public int Longitud { get; set; }
        public int Area { get; set; }

        public Poligonos()
        {
            Lados = 0;
            Longitud = 0;
            Area = 0;
        }

        public Poligonos(int lados, int longitud, int area)
        {
            Lados = lados;
            Longitud = longitud;
            Area = area;
        }

        
            
    }
}
