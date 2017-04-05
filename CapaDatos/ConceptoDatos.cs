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
    public class ConceptoDatos
    {
        SqlConnection cnx;
        EConcepto mcConcepto = new EConcepto();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool v_exito;

        public ConceptoDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }

        public bool insertarConcepto(EConcepto mcConcepto)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_concepto_add";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_nombre", SqlDbType.VarChar, 500));
                cmd.Parameters["@p_nombre"].Value = mcConcepto.Nombre;

                cmd.Parameters.Add(new SqlParameter("@p_fechaVenc", SqlDbType.Date));
                cmd.Parameters["@p_fechaVenc"].Value = mcConcepto.FechaVenc;


                cmd.Parameters.Add(new SqlParameter("@p_precio", SqlDbType.Decimal));
                cmd.Parameters["@p_precio"].Value = mcConcepto.Precio;


                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch(SqlException ex)
            {
                v_exito = false;
                mcConcepto.msgResp = ex.Message;

            }
            finally
            {
                if (cnx.State==ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return v_exito;


        }

        public bool actualizarConcepto(EConcepto mcConcepto)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_concepto_edit";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_id", SqlDbType.Int));
                cmd.Parameters["@p_id"].Value = mcConcepto.IdConcepto;

                cmd.Parameters.Add(new SqlParameter("@p_nombre", SqlDbType.VarChar, 500));
                cmd.Parameters["@p_nombre"].Value = mcConcepto.Nombre;

                cmd.Parameters.Add(new SqlParameter("@p_fechaVenc", SqlDbType.Date));
                cmd.Parameters["@p_fechaVenc"].Value = mcConcepto.FechaVenc;


                cmd.Parameters.Add(new SqlParameter("@p_precio", SqlDbType.Decimal));
                cmd.Parameters["@p_precio"].Value = mcConcepto.Precio;


                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                mcConcepto.msgResp = ex.Message;

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return v_exito;


        }

       public bool eliminarConcepto(int idConcepto)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_concepto_del";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_id", SqlDbType.Int));
                cmd.Parameters["@p_id"].Value = idConcepto;

            }
            catch(SqlException ex)
            {
                v_exito = false;
                mcConcepto.msgResp = ex.Message;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();

            }

            return v_exito;


        }

        public DataTable listarConcepto()
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
