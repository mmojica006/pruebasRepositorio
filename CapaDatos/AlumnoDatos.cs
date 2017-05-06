using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
   public  class AlumnoDatos
    {
        SqlConnection cnx;
        EAlumnos mcEntidad = new EAlumnos();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool vexito;

        public AlumnoDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }

        public bool insertarAlumno(EAlumnos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_alumno_insert";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_nombres", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombres"].Value = mcEntidad.nombres;

                cmd.Parameters.Add(new SqlParameter("@p_apellidos", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_apellidos"].Value = mcEntidad.napellidos;

                cmd.Parameters.Add(new SqlParameter("@p_cedula", SqlDbType.VarChar, 16));
                cmd.Parameters["@p_cedula"].Value = mcEntidad.cedula;

                cmd.Parameters.Add(new SqlParameter("@p_sexo", SqlDbType.Char, 1));
                cmd.Parameters["@p_sexo"].Value = mcEntidad.sexo;

                cmd.Parameters.Add(new SqlParameter("@p_fechaNac", SqlDbType.Date));
                cmd.Parameters["@p_fechaNac"].Value = mcEntidad.fechaNac;

                cmd.Parameters.Add(new SqlParameter("@p_nombPadre", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombPadre"].Value = mcEntidad.nomPadre;

                cmd.Parameters.Add(new SqlParameter("@p_nombreMadre", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombreMadre"].Value = mcEntidad.nomMadre;

                cmd.Parameters.Add(new SqlParameter("@p_nombreApoderado", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombreApoderado"].Value = mcEntidad.nomApoderado;

                cmd.Parameters.Add(new SqlParameter("@p_telefono", SqlDbType.VarChar, 10));
                cmd.Parameters["@p_telefono"].Value = mcEntidad.telefono;                     

                cmd.Parameters.Add(new SqlParameter("@p_celular", SqlDbType.Int));
                cmd.Parameters["@p_celular"].Value = mcEntidad.celular;

                cmd.Parameters.Add(new SqlParameter("@p_direccion", SqlDbType.VarChar, 500));
                cmd.Parameters["@p_direccion"].Value = mcEntidad.direccion;

                cmd.Parameters.Add(new SqlParameter("@p_foto", SqlDbType.Image));
                if (mcEntidad.foto == null ){
                }
                cmd.Parameters["@p_foto"].Value = mcEntidad.foto;//==String.Empty ? DBNull:mcEntidad.foto;

                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;


            }
            catch (SqlException ex)
            {
                vexito = false;
                mcEntidad.mensageResp = ex.Message;

            }

            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }


        public bool actualizarAlumno(EAlumnos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_alumno_actualizar";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_nombres", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombres"].Value = mcEntidad.nombres;

                cmd.Parameters.Add(new SqlParameter("@@p_apellidos", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_apellidos"].Value = mcEntidad.napellidos;

                cmd.Parameters.Add(new SqlParameter("@p_cedula", SqlDbType.VarChar, 16));
                cmd.Parameters["@p_cedula"].Value = mcEntidad.cedula;

                cmd.Parameters.Add(new SqlParameter("@p_sexo", SqlDbType.Char, 1));
                cmd.Parameters["@p_sexo"].Value = mcEntidad.sexo;

                cmd.Parameters.Add(new SqlParameter("@p_fechaNac", SqlDbType.Date));
                cmd.Parameters["@p_fechaNac"].Value = mcEntidad.fechaNac;

                cmd.Parameters.Add(new SqlParameter("@p_nombPadre", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombPadre"].Value = mcEntidad.nomPadre;

                cmd.Parameters.Add(new SqlParameter("@p_nombreMadre", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombreMadre"].Value = mcEntidad.nomMadre;

                cmd.Parameters.Add(new SqlParameter("@p_nombreApoderado", SqlDbType.VarChar, 150));
                cmd.Parameters["@p_nombreApoderado"].Value = mcEntidad.nomApoderado;

                cmd.Parameters.Add(new SqlParameter("@p_telefono", SqlDbType.VarChar, 10));
                cmd.Parameters["@p_telefono"].Value = mcEntidad.telefono;

                cmd.Parameters.Add(new SqlParameter("@p_telefono", SqlDbType.VarChar, 10));
                cmd.Parameters["@p_telefono"].Value = mcEntidad.telefono;

                cmd.Parameters.Add(new SqlParameter("@p_celular", SqlDbType.Int));
                cmd.Parameters["@p_celular"].Value = mcEntidad.celular;

                cmd.Parameters.Add(new SqlParameter("@p_direccion", SqlDbType.VarChar, 500));
                cmd.Parameters["@p_direccion"].Value = mcEntidad.direccion;

                cmd.Parameters.Add(new SqlParameter("@p_foto", SqlDbType.VarBinary));
                cmd.Parameters["@p_foto"].Value = mcEntidad.foto;

                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;


            }
            catch (SqlException ex)
            {
                vexito = false;
                mcEntidad.mensageResp = ex.Message;
            }

            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }

        public bool eliminarAlumno(EAlumnos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_alumno_eliminar";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_codigo", SqlDbType.Int));
                cmd.Parameters["@p_codigo"].Value = mcEntidad.idAlumno;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Char,1));
                cmd.Parameters["@estado"].Value = mcEntidad.dstado;
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException ex)
            {
                vexito = false;
                mcEntidad.mensageResp = ex.Message;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;




        }

        public DataTable ConsultarAlumno(int idAlumno =0 ,string parametro=null)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_alumno_buscar";
                cmd.Parameters.Add(new SqlParameter("@p_idAlumno", idAlumno));
                cmd.Parameters.Add(new SqlParameter("@p_nombre", parametro));
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "alumnos");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["alumnos"]);
        }


    }
}
