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
        public int selectedIdConcepto { get; set; }

        ConceptoNegocio conceptoNeg = new ConceptoNegocio();
        EConcepto econcepto = new EConcepto();


        public frmConceptos()
        {
            InitializeComponent();
            gvConceptos.DataSource = conceptoNeg.listarconcepto(0);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            PopAddConcepto popUp = new PopAddConcepto();
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                gvConceptos.DataSource = conceptoNeg.listarconcepto(0);


            }
            else if (dialogResult == DialogResult.Cancel)
            {
               
            }
            popUp.Dispose();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            selectedIdConcepto = Convert.ToInt32(this.gvConceptos.CurrentRow.Cells[0].Value.ToString());
            PopEditConcepto popEditConcepto = new PopEditConcepto(selectedIdConcepto);
            DialogResult dialogResult = popEditConcepto.ShowDialog();

           // popEditConcepto.ShowDialog();
           if (dialogResult == DialogResult.OK)
                {

                gvConceptos.DataSource = conceptoNeg.listarconcepto(0);
            }



           

          //popEditConcepto.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
