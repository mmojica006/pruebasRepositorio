using Interfaces.Helpers;
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

namespace Interfaces.Empleado
{
    public partial class addEmpleado : Form
    {
        EmpleadoNegocio empNeg = new EmpleadoNegocio();
        Eempleado empEntidad = new Eempleado();

        public addEmpleado()
        {
            InitializeComponent();
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

   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validation.hasValidationErrors(this.Controls))
            {

                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                empEntidad.dni = txtcedula.Text;
                empEntidad.Nombre = txtnombre.Text;
                empEntidad.Apellido = txtapellido.Text;
                empEntidad.FechaNac = Convert.ToDateTime(dtpfNacimiento.Text);
                empEntidad.Telefono = txttelefono.Text;
                empEntidad.Sexo = rbmasculino.Checked ? "M" : "F";
                empEntidad.Direccion = txtDireccion.Text;

                if (empNeg.agregarEmpleado(empEntidad))
                {
                    MessageBox.Show("Registro agregado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            }
    }
}
