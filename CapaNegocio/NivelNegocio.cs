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
    public class NivelNegocio
    {
        NivelesDatos _nivelesDatos = new NivelesDatos();

        public bool agregarNivel(ENiveles eNivel)
        {
            return _nivelesDatos.insertarNivel(eNivel);
        }
        public bool editarrNivel(ENiveles eNivel)
        {
            return _nivelesDatos.actualizarrNivel(eNivel);
        }

        public bool eliminarNivel(int idNivel)
        {
            return _nivelesDatos.eliminarNivel(idNivel);
        }

        public DataTable listarNivel(int idNivel = 0, string descripion = null)
        {
            return _nivelesDatos.listarNivel(idNivel, descripion);
        }

        public DataTable nivelCombo()
        {
            return _nivelesDatos.nivelCombo();
        }
  


    }
}
