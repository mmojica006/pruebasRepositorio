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

namespace Interfaces
{
    public partial class PopEditConcepto : Form
    {
        EConcepto eConcepto = new EConcepto();
        ConceptoNegocio conceptosNegocio = new ConceptoNegocio();
 

        public PopEditConcepto(int id)
        {
            InitializeComponent();
                           //Initialize with static textbox

            obtenerConcepto(id);
        }

        private void obtenerConcepto(int id)
        {
            frmConceptos frm = new frmConceptos(); 
            DataTable dt;
            txtdescripcion.Text = String.Empty;
            txtprecio.Text = String.Empty;
         dt = conceptosNegocio.listarconcepto(id);
            txtdescripcion.Text = dt.Rows[0]["Nombre"].ToString();
            txtprecio.Text = dt.Rows[0]["Precio"].ToString();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
