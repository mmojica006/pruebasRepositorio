using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ENiveles
    {
        public int idNivel { get; set; }
        public int idTutor { get; set; }
        public string grado { get; set; }
        public string orden { get; set; }
        public int vacantes { get; set; }
        public string estado { get; set; }

        public int noMsg { get; set; }
        public string respuestaMsg { get; set; }


    }
}
