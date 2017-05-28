using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EMatricula
    {
        public int idMatricula { get; set; }
        public int idAlumno { get; set; }
        public int idNivel { get; set; }
        public string periodo { get; set; }
        public string seccion { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public string mensajeResp { get; set; }




    }
}
