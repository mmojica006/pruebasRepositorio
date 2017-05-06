using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Eempleado
    {
        public int idEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string dni { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }
}
