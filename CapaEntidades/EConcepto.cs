using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public  class EConcepto
    {
        public int IdConcepto { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaVenc { get; set; }
        public decimal Precio { get; set; }
        public String Estado { get; set; }

        public string msgResp { get; set; }

    }
}
