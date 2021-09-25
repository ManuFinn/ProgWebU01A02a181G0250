using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U01A02a181G0250.Models
{
    public class CalificacionesViewModel
    {
        public int Calificacion01 { get; set; }
        public int Calificacion02 { get; set; }
        public int Calificacion03 { get; set; }

        public int CalificacionFinal { 
            get { return (Calificacion01 + Calificacion02 + Calificacion03) / 3; } 
        }

        public string Estado { 
            get
            {
                if(CalificacionFinal >= 70) { return "Aprobado"; }
                if(CalificacionFinal < 70) { return "Reprobado"; }
                return " ";
            }
        }
    }
}
