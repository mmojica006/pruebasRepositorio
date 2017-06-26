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
   public  class MatriculaNegocio
    {
        MatriculaDatos matriculaDatos = new MatriculaDatos();

        public bool agregar (EMatricula mcMatricula)
        {
            return matriculaDatos.insertarMatricula(mcMatricula);
        }

        public bool editar(EMatricula mcMatricula)
        {
            return matriculaDatos.modificarMatricula(mcMatricula);
        }

        public bool borrar(int idMatricula)
        {
            return matriculaDatos.eliminarMatricula(idMatricula);
        }

        public DataTable listar(int idNivel)
        {
            return matriculaDatos.listarMatriculas(idNivel);
        }

        public DataTable BuscarMatriculoAlumno(int Alumno)
        {
            return matriculaDatos.BuscarMatricula(Alumno);
        }


    }
}
