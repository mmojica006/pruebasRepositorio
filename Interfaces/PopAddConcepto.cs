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

namespace Interfaces
{
    public partial class PopAddConcepto : Form
    {
        ConceptoNegocio conceptoNeg = new ConceptoNegocio();
        EConcepto econcepto = new EConcepto();


        public PopAddConcepto()
        {
            InitializeComponent();
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

                try

                {
                    econcepto.Nombre = txtdescripcion.Text;
                    econcepto.FechaVenc = Convert.ToDateTime(dtpfNacimiento.Text);
                    econcepto.Precio = Convert.ToDecimal(txtprecio.Text);
                    if (conceptoNeg.AgregarConcepto(econcepto))
                    {
                        MessageBox.Show("Concepto ingresado correctamente", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(econcepto.msgResp, "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void txtdescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (txtdescripcion.Text.Trim() == String.Empty)
            {
                errProvider.SetError(txtdescripcion, "La descripción es requerida");
                e.Cancel = true;
            }
            else
                errProvider.SetError(txtdescripcion, "");

        }

        private void txtprecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtprecio.Text.Trim() == String.Empty)
            {
                errProvider.SetError(txtdescripcion, "El precio es requerido");
                e.Cancel = true;
            }
            else
                errProvider.SetError(txtdescripcion, "");
        }
    }
}
