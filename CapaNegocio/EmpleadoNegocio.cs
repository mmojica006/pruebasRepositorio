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
    public class EmpleadoNegocio
    {
        empleadoDatos _empleadoDatos = new empleadoDatos();


        public bool agregarEmpleado(Eempleado _empleado)
        {
            return _empleadoDatos.agregarEmpleado(_empleado);
        }
        public bool editarEmpleado(Eempleado _empleado)
        {
            return _empleadoDatos.editarEmpleado(_empleado);
        }

        public bool eliminarEmpleado(int idempleado)
        {
            return _empleadoDatos.eliminarEmpleado(idempleado);
        }
        public DataTable listarEmpleado(int idEmpleado=0)
        {
            return _empleadoDatos.listarEmpleado(idEmpleado);
        }



    }
}
