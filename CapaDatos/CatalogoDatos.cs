using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaDatos
{


    public  class CatalogoDatos
    {
        SqlConnection cnx;
        EConcepto mcConcepto = new EConcepto();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool v_exito;

        public CatalogoDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }

        public DataTable consultarPperiodo()
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_listar_Concepto";
             
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "data");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["data"]);
        }




    }
}
