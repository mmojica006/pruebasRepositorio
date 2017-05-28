using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class NivelesDatos
    {
        SqlConnection cnx;
        ENiveles mNiveles = new ENiveles();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool v_exito;

       public NivelesDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }


        public bool insertarNivel(ENiveles mNiveles)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_nivel_insert";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_idtutor", SqlDbType.Int));
                cmd.Parameters["@p_idtutor"].Value = mNiveles.idTutor;

                cmd.Parameters.Add(new SqlParameter("@p_grado", SqlDbType.VarChar,100));
                cmd.Parameters["@p_grado"].Value = mNiveles.grado;


                cmd.Parameters.Add(new SqlParameter("@p_orden", SqlDbType.VarChar,100));
                cmd.Parameters["@p_orden"].Value = mNiveles.orden;

                cmd.Parameters.Add(new SqlParameter("@p_vacante", SqlDbType.Int));
                cmd.Parameters["@p_vacante"].Value = mNiveles.vacantes;


                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                mNiveles.respuestaMsg = ex.Message;

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
        public bool actualizarrNivel(ENiveles mNiveles)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_nivel_edit";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_idnivel", SqlDbType.Int));
                cmd.Parameters["@p_idnivel"].Value = mNiveles.idTutor;

                cmd.Parameters.Add(new SqlParameter("@p_idtutor", SqlDbType.Int));
                cmd.Parameters["@p_idtutor"].Value = mNiveles.idTutor;

                cmd.Parameters.Add(new SqlParameter("@p_grado", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_grado"].Value = mNiveles.grado;


                cmd.Parameters.Add(new SqlParameter("@p_orden", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_orden"].Value = mNiveles.orden;

                cmd.Parameters.Add(new SqlParameter("@p_vacante", SqlDbType.Int));
                cmd.Parameters["@p_vacante"].Value = mNiveles.vacantes;


                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                mNiveles.respuestaMsg = ex.Message;

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
        public bool eliminarNivel(int idNivel)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_nivel_del";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_idNivel", SqlDbType.Int));
                cmd.Parameters["@p_idNivel"].Value = idNivel;
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                mNiveles.respuestaMsg = ex.Message;
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

        public DataTable listarNivel(int idNivel = 0, string Descripcion = null)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_nivel_buscar";

                cmd.Parameters.Add(new SqlParameter("@p_idNivel", idNivel));
                cmd.Parameters.Add(new SqlParameter("@p_descripcion", Descripcion));


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

        public DataTable nivelCombo(int idNivel = 0, string Descripcion = null)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_nivel_list";         

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
