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
    public class empleadoDatos
    {
        SqlConnection cnx;
        Eempleado _empleado = new Eempleado();
        Conexion miConex = new Conexion();
        SqlCommand cmd = new SqlCommand();
        bool exito;

        public empleadoDatos()
        {
            cnx = new SqlConnection(miConex.getConex());
        }

        public bool agregarEmpleado(Eempleado _empleado)
        {

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_empleado_add";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_nombre", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_nombre"].Value = _empleado.Nombre;

                cmd.Parameters.Add(new SqlParameter("@p_apellido", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_apellido"].Value = _empleado.Apellido;


                cmd.Parameters.Add(new SqlParameter("@p_dni", SqlDbType.VarChar,100));
                cmd.Parameters["@p_dni"].Value = _empleado.dni;

                cmd.Parameters.Add(new SqlParameter("@p_sexo", SqlDbType.Char,1));
                cmd.Parameters["@p_sexo"].Value = _empleado.Sexo;

                cmd.Parameters.Add(new SqlParameter("@fechaNac", SqlDbType.Date));
                cmd.Parameters["@fechaNac"].Value = _empleado.FechaNac;

                cmd.Parameters.Add(new SqlParameter("@p_telefono", SqlDbType.VarChar, 20));
                cmd.Parameters["@p_telefono"].Value = _empleado.Telefono;

                cmd.Parameters.Add(new SqlParameter("@p_direccion", SqlDbType.VarChar, 500));
                cmd.Parameters["@p_direccion"].Value = _empleado.Direccion;


                cnx.Open();
                cmd.ExecuteNonQuery();
                exito = true;



            }
            catch(SqlException ex)
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

        public bool  editarEmpleado(Eempleado _empleado)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_empleado_edit";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_nombre", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_nombre"].Value = _empleado.Nombre;

                cmd.Parameters.Add(new SqlParameter("@p_apellido", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_apellido"].Value = _empleado.Apellido;


                cmd.Parameters.Add(new SqlParameter("@p_dni", SqlDbType.VarChar, 100));
                cmd.Parameters["@p_dni"].Value = _empleado.dni;

                cmd.Parameters.Add(new SqlParameter("@p_sexo", SqlDbType.Char, 1));
                cmd.Parameters["@p_sexo"].Value = _empleado.Sexo;

                cmd.Parameters.Add(new SqlParameter("@fechaNac", SqlDbType.Date));
                cmd.Parameters["@fechaNac"].Value = _empleado.FechaNac;

                cmd.Parameters.Add(new SqlParameter("@p_telefono", SqlDbType.VarChar, 20));
                cmd.Parameters["@p_telefono"].Value = _empleado.Telefono;

                cmd.Parameters.Add(new SqlParameter("@p_direccion", SqlDbType.VarChar, 500));
                cmd.Parameters["@p_direccion"].Value = _empleado.Direccion;


                cnx.Open();
                cmd.ExecuteNonQuery();
                exito = true;



            }
            catch (SqlException ex)
            {
                exito = false;
                throw;

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

        public bool eliminarEmpleado(int idEmpleado)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_empleado_del";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@p_id", SqlDbType.Int));
                cmd.Parameters["@p_id"].Value = idEmpleado;

            }
            catch (SqlException ex)
            {
                exito = false;
                throw;
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

        public DataTable listarAlumno(int idEmpleado = 0)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_empleados_list";
                cmd.Parameters.Add(new SqlParameter("@p_idempleado", idEmpleado));
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
