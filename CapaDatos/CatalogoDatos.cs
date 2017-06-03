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

        public DataTable getCatalogo()
        {
            DataTable dt = new DataTable();

            string query = "select value from catalogo where id_value=10";
            //Inicializa la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(miConex.getConex()))
            {
                //Inicializa el comando que se va a ejecutar
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //Se agregan los parámetros
                  //  cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            //Se abre la conexión
                            cmd.Connection.Open();
                            //Se cargan los datos en el DataTable
                            da.Fill(dt);
                        }
                        catch (SqlException sqlEx)
                        {
                            string error = sqlEx.Message;
                            throw;
                        }
                    }
                }
            }
            return dt;
        }
           




    }
}
