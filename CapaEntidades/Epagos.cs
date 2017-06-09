using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public  class Epagos
    {

        public int idPago { get; set; }
        public int idMatricula { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public decimal Total { get; set; }
    }
}
