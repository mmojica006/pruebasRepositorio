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
            llenarData();
        }

        private void llenarData()
        {

            gvEmpleado.DataSource = matriculaNeg.listar(Convert.ToInt32(cmbNivel.SelectedValue.ToString()));
            this.gvEmpleado.Columns["IdAlumno"].Visible = false;
            this.gvEmpleado.Columns["idmatricula"].Visible = false;
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

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = cmbNivel.SelectedValue;  //Convert.ToInt32(cmbNivel.SelectedValue.ToString());

            DataRowView drv = this.cmbNivel.SelectedItem as DataRowView;
            int value = Convert.ToInt32(drv[0]);




            gvEmpleado.DataSource = matriculaNeg.listar(value);
            this.gvEmpleado.Columns["IdAlumno"].Visible = false;
            this.gvEmpleado.Columns["idmatricula"].Visible = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gvEmpleado.DataSource != null)
            {


            }




        }
    }
}
