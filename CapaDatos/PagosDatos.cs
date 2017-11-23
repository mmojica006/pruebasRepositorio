using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;     
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PagosDatos
    {
        SqlConnection cnx;
        Epagos _epagos = new Epagos();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool exito;

        public PagosDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }

        public bool agregarPago(Epagos _epagos)
        {

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_pagos_new";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@idConcepto", SqlDbType.Int));
                cmd.Parameters["@idConcepto"].Value = _epagos.idConcepto;


                cmd.Parameters.Add(new SqlParameter("@idmatricula", SqlDbType.Int));
                cmd.Parameters["@idmatricula"].Value = _epagos.idMatricula;

                cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
                cmd.Parameters["@fecha"].Value = _epagos.fecha ;


                cmd.Parameters.Add(new SqlParameter("@hora", SqlDbType.VarChar,10));
                cmd.Parameters["@hora"].Value = _epagos.hora;

                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
                cmd.Parameters["@total"].Value = _epagos.Total;

                   

                                               
                cnx.Open();
                cmd.ExecuteNonQuery();
               

                exito = true;



            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return exito;




        }


        public DataTable listarConceptos(int idMatricula)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_pagos_pendientes";

                cmd.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));
               


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

        public DataTable listAlumnosMatriculados(int idAlumno, string nombre)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_pagos_alum_mat";

                cmd.Parameters.Add(new SqlParameter("@id_alumno", idAlumno));

                if (nombre == null){
                    cmd.Parameters.Add(new SqlParameter("@p_nombre", null));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@p_nombre", nombre));
                }

              



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
