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



    }
}
