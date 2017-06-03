using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using Interfaces.Helpers;

namespace Interfaces.Empleado
{
    public partial class editEmpleado : Form
    {
        EmpleadoNegocio empNeg = new EmpleadoNegocio();
        Eempleado empEntidad = new Eempleado();
        public int idEmp { get; set; }

        public editEmpleado(int id)
        {
            InitializeComponent();
            getEmpleado(id);
        }

        private void getEmpleado(int id)
        {
            idEmp = id;
            DataTable dt;
            limpiarTexbox();

            dt = empNeg.listarEmpleado(id);
            txtcedula.Text = dt.Rows[0]["DNI"].ToString();
            txtnombre.Text = dt.Rows[0]["Nombres"].ToString();
            txtapellido.Text = dt.Rows[0]["Apellidos"].ToString();
            dtpfNacimiento.Value = Convert.ToDateTime( dt.Rows[0]["FechaNac"].ToString());
            txttelefono.Text = dt.Rows[0]["Telefono"].ToString();
            txtcedula.Text = dt.Rows[0]["DNI"].ToString();
            txtcedula.Text = dt.Rows[0]["DNI"].ToString();
            
            String sexo = dt.Rows[0]["Sexo"].ToString();
            switch (sexo)
            {
                case "M":
                    rbmasculino.Checked = true;
                    break;
                case "F":
                    rbfemenino.Checked = true;
                    break;

                default:
                    rbmasculino.Checked = true;
                    break;
            }

            txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validation.hasValidationErrors(this.Controls))
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                empEntidad.idEmpleado = idEmp;
                empEntidad.dni = txtcedula.Text;
                empEntidad.Nombre = txtnombre.Text;
                empEntidad.Apellido = txtapellido.Text;
                empEntidad.FechaNac = Convert.ToDateTime(dtpfNacimiento.Text);
                empEntidad.Telefono = txttelefono.Text;
                empEntidad.Sexo = rbmasculino.Checked ? "M" : "F";
                empEntidad.Direccion = txtDireccion.Text;

                if (empNeg.editarEmpleado(empEntidad))
                {
                    MessageBox.Show("Registro actualizado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



            }

        private void limpiarTexbox()
        {
            txtcedula.Text = String.Empty;
             txtnombre.Text = String.Empty; ;
             txtapellido.Text = String.Empty; ;           
             txttelefono.Text = String.Empty; ;           
             txtDireccion.Text = String.Empty; ;
        }

        private void txtcedula_Validating(object sender, CancelEventArgs e)
        {
            if (txtcedula.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtcedula, "La cédula es requerida");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtcedula, "");

        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombre.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtnombre, "El nombre es requerido");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtcedula, "");

        }

        private void txtapellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellido.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtapellido, "El apellido es requerido");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtcedula, "");
        }

        private void elRichLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
