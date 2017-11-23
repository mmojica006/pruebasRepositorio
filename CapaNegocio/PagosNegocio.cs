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

     public bool addPago(Epagos epagos)
        {
            return _pagosDatos.agregarPago(epagos);
        }

        public DataTable consultaMatAlumno(int idAlumno, string nombre) {

            return _pagosDatos.listAlumnosMatriculados(idAlumno, nombre);
        }

    }
}
