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
    public partial class addMatricula : Form
    {
        ENiveles eNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        EMatricula eMatricula = new EMatricula();
        MatriculaNegocio matriculaNeg = new MatriculaNegocio();

        CatalogoNegocio catalogoNeg = new CatalogoNegocio();

        public addMatricula()
        {
            InitializeComponent();
            DateTime time = DateTime.Now;
            string format = "h:mm";
            txthora.Text = time.ToString(format);


            DateTime fecha = DateTime.Now;
            string format2 = "";
            txtfecha.Text = fecha.ToString("d");

            DataTable dt;

            dt = catalogoNeg.getPeriodo();
            txtperiodo.Text = dt.Rows[0]["value"].ToString();



            llenarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void llenarCombo()
        {
            cmbNivel.DataSource = nivelNeg.nivelCombo();

            cmbNivel.DisplayMember = "Nivel";
            cmbNivel.ValueMember = "idnivel";
            cmbNivel.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Matricula.buscarAlumno popUp = new Matricula.buscarAlumno();
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
               
            }


        }
    }
}
