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
    public partial class PopEditConcepto : Form
    {
        EConcepto eConcepto = new EConcepto();
        ConceptoNegocio conceptosNegocio = new ConceptoNegocio();

        public int idconcepto { get; set; }


        public PopEditConcepto(int id)
        {
            InitializeComponent();
            //Initialize with static textbox

            obtenerConcepto(id);
        }

        private void obtenerConcepto(int id)
        {
            idconcepto = id;
            frmConceptos frm = new frmConceptos();
            DataTable dt;
            txtdescripcion.Text = String.Empty;
            txtprecio.Text = String.Empty;

            dt = conceptosNegocio.listarconcepto(id);
            txtdescripcion.Text = dt.Rows[0]["Nombre"].ToString();
            txtprecio.Text = dt.Rows[0]["Precio"].ToString();
            dtpfNacimiento.Value = Convert.ToDateTime(dt.Rows[0]["FechaVencimiento"].ToString());




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
                eConcepto.IdConcepto = idconcepto;
                eConcepto.Nombre = txtdescripcion.Text;
                eConcepto.Precio = decimal.Parse(txtprecio.Text);
                eConcepto.FechaVenc = Convert.ToDateTime(dtpfNacimiento.Text);

                if (conceptosNegocio.editarConcepto(eConcepto))
                {
                    MessageBox.Show("Concepto Actualizado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(eConcepto.msgResp, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errProvider.SetError(txtprecio, "El precio es requerido");
                e.Cancel = true;
            }
            else
                errProvider.SetError(txtprecio, "");

        }
    }
}
