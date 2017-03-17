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
    public class AlumnoNegocio
    {
        AlumnoDatos _AlumnoDatos = new AlumnoDatos();

        public bool insertarAlumno(EAlumnos alumNegocio)
        {
            return _AlumnoDatos.insertarAlumno(alumNegocio);
        }
        public bool actualizrAlumno(EAlumnos alumNegocio)
        {
            return _AlumnoDatos.actualizarAlumno(alumNegocio);
        }
        public bool eliminarAlumno(EAlumnos alumNegocio)
        {
            return _AlumnoDatos.eliminarAlumno(alumNegocio);
        }

        public DataTable consultarAlumno(String parameter)
        {
            return _AlumnoDatos.ConsultarAlumno(parameter);
        }


    }
}
