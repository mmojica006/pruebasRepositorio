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
    public partial class frmConceptos : Form
    {
        ConceptoNegocio conceptoNeg = new ConceptoNegocio();
        EConcepto econcepto = new EConcepto();

        public frmConceptos()
        {
            InitializeComponent();
            gvConceptos.DataSource = conceptoNeg.listarconcepto();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            PopAddConcepto popUp = new PopAddConcepto();
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                gvConceptos.DataSource = conceptoNeg.listarconcepto();


            }
            else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked on Cancel");
            }
            popUp.Dispose();


        }
    }
}
