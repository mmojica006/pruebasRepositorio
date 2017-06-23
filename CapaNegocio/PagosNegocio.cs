using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data; 


namespace CapaNegocio
{
    public class PagosNegocio
    {
        PagosDatos _pagosDatos = new PagosDatos();
        public DataTable listaPagosPendientes(int idMatricula)
        {
            return _pagosDatos.listarConceptos(idMatricula);
        }
    }
}
