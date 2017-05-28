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
   public  class MatriculaDatos
    {
        SqlConnection cnx;
        EMatricula eMatricula = new EMatricula();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool v_exito;

        public MatriculaDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }

        public bool insertarMatricula(EMatricula eMatricula)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_matricula_add";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@idAlumno", SqlDbType.Int));
                cmd.Parameters["@idAlumno"].Value = eMatricula.idAlumno;

                cmd.Parameters.Add(new SqlParameter("@idNivel", SqlDbType.Int));
                cmd.Parameters["@idNivel"].Value = eMatricula.idNivel;
      
                        
                cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.VarChar,100));
                cmd.Parameters["@periodo"].Value = eMatricula.periodo;

                cmd.Parameters.Add(new SqlParameter("@seccion", SqlDbType.VarChar, 20));
                cmd.Parameters["@seccion"].Value = eMatricula.seccion;


                cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                cmd.Parameters["@fecha"].Value = eMatricula.fecha;

                cmd.Parameters.Add(new SqlParameter("@hora", SqlDbType.Date));
                cmd.Parameters["@hora"].Value = eMatricula.hora;


                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                eMatricula.mensajeResp = ex.Message;

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

        public bool modificarMatricula(EMatricula eMatricula)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_matricula_edit";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@idMatricula", SqlDbType.Int));
                cmd.Parameters["@idMatricula"].Value = eMatricula.idMatricula;

                cmd.Parameters.Add(new SqlParameter("@idAlumno", SqlDbType.Int));
                cmd.Parameters["@idAlumno"].Value = eMatricula.idAlumno;

                cmd.Parameters.Add(new SqlParameter("@idNivel", SqlDbType.Int));
                cmd.Parameters["@idNivel"].Value = eMatricula.idNivel;


                cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.VarChar, 100));
                cmd.Parameters["@periodo"].Value = eMatricula.periodo;

                cmd.Parameters.Add(new SqlParameter("@seccion", SqlDbType.VarChar, 20));
                cmd.Parameters["@seccion"].Value = eMatricula.seccion;


                cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                cmd.Parameters["@fecha"].Value = eMatricula.fecha;

                cmd.Parameters.Add(new SqlParameter("@hora", SqlDbType.Date));
                cmd.Parameters["@hora"].Value = eMatricula.hora;


                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                eMatricula.mensajeResp = ex.Message;

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


        public bool eliminarMatricula(int idMatricula)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_matricula_del";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@idMatricula", SqlDbType.Int));
                cmd.Parameters["@idMatricula"].Value = idMatricula;

                cnx.Open();
                cmd.ExecuteNonQuery();
                v_exito = true;

            }
            catch (SqlException ex)
            {
                v_exito = false;
                eMatricula.mensajeResp = ex.Message;

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


        public DataTable listarMatriculas(int idnivel)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_matricula_list";
                cmd.Parameters.Add(new SqlParameter("@idNivel", idnivel));
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
