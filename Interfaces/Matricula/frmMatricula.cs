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

namespace Interfaces.Matricula
{
    public partial class frmMatricula : Form
    {
        ENiveles eNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        EMatricula eMatricula = new EMatricula();
        MatriculaNegocio matriculaNeg = new MatriculaNegocio();

        public frmMatricula()
        {
            InitializeComponent();

            llenarCombo();

       
           

        }

        private void llenarCombo()
        {
            cmbNivel.DataSource = nivelNeg.nivelCombo();

            cmbNivel.DisplayMember = "Nivel";
            cmbNivel.ValueMember = "idnivel";
            cmbNivel.Enabled = true;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            Matricula.addMatricula popUp = new Matricula.addMatricula();
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

               


            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
            popUp.Dispose();

        }
    }
}
