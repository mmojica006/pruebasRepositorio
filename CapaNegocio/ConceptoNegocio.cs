using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
   public  class ConceptoNegocio
    {
        ConceptoDatos _conceptoDatos = new ConceptoDatos();

        public bool AgregarConcepto (EConcepto econcepto)
        {
            return _conceptoDatos.insertarConcepto(econcepto);
        }

        public  bool editarConcepto(EConcepto econcepto)
        {
            return _conceptoDatos.actualizarConcepto(econcepto);
        }
        public bool eliminarConcepto(int id)
        {
            return _conceptoDatos.eliminarConcepto(id);
        }

        public DataTable listarconcepto(int idConcepto=0)
        {
            return _conceptoDatos.listarConcepto(idConcepto);
        }



    }
}
