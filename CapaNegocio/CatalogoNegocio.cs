using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CatalogoNegocio
    {

        CatalogoDatos cataDatos = new CatalogoDatos();

        public DataTable getPeriodo(){

            return cataDatos.getCatalogo();
        } 
    }
}
