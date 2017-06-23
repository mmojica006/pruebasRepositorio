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


namespace Interfaces.Pagos
{
    public partial class frmPagos : Form
    {

        ENiveles eNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        EMatricula eMatricula = new EMatricula();
        MatriculaNegocio matriculaNeg = new MatriculaNegocio();

        CatalogoNegocio catalogoNeg = new CatalogoNegocio();

        AlumnoNegocio alumnoNeg = new AlumnoNegocio();

        public int v_idAlumno { get; set; }
        public int idMatricula { get; set; }

        public frmPagos()
        {
            InitializeComponent();

            DateTime time = DateTime.Now;
            string format = "h:mm";
            txtHora.Text = time.ToString(format);


            DateTime fecha = DateTime.Now;
            string format2 = "";
            txtFecha.Text = fecha.ToString("d");

            DataTable dt;

           



            bloquearControles();
        }

        private void bloquearControles()
        {

            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
            gvPagos.Enabled = false;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnBuscar.Enabled = false;

        }
        private void habilitarControles()
        {

            btnGuardar.Enabled = true;
            btnImprimir.Enabled = true;
            gvPagos.Enabled = true;
            btnAgregar.Enabled = true;
            btnQuitar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Matricula.buscarAlumno popUp = new Matricula.buscarAlumno();
            DataTable dt;
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                if ((popUp.idAlumno != null) && (popUp.idAlumno != 0))
                {
                    txtAlumno.Text = string.Empty;

                    dt = alumnoNeg.consultarAlumno(popUp.idAlumno, null);
                    string nombreAlumno = dt.Rows[0]["Nombres"].ToString() + " " + dt.Rows[0]["Apellidos"].ToString();

                    v_idAlumno = Convert.ToInt32(dt.Rows[0]["idAlumno"].ToString());
                   // idMatricula = dt.Rows[0][""]


                    txtAlumno.Text = nombreAlumno;

                }


            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            habilitarControles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pagos.frm_pagos_lista popPop = new Pagos.frm_pagos_lista(1);
            DialogResult dialogResult = popPop.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

            }



            }
    }
}
