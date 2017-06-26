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

        Epagos _epagos = new Epagos();
        PagosNegocio pagosNegocio = new PagosNegocio();

        ConceptoNegocio _conceptoNegocio = new ConceptoNegocio();


        public int v_idAlumno { get; set; }
        public int MmatriculaId { get; set; }

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
            dgvPagos.Enabled = false;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnBuscar.Enabled = false;

        }
        private void habilitarControles()
        {

            btnGuardar.Enabled = true;
            btnImprimir.Enabled = true;
            dgvPagos.Enabled = true;
            btnAgregar.Enabled = true;
            btnQuitar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Matricula.buscarAlumno popUp = new Matricula.buscarAlumno();
            DataTable dt;
            DataTable dtMatricula;
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                if ((popUp.idAlumno != null) && (popUp.idAlumno != 0))
                {
                    txtAlumno.Text = string.Empty;

                    dt = alumnoNeg.consultarAlumno(popUp.idAlumno, null);
                    string nombreAlumno = dt.Rows[0]["Nombres"].ToString() + " " + dt.Rows[0]["Apellidos"].ToString();

                    v_idAlumno = Convert.ToInt32(dt.Rows[0]["idAlumno"].ToString());

                    dtMatricula = matriculaNeg.BuscarMatriculoAlumno(v_idAlumno);
                    if (dtMatricula.Rows.Count > 1)
                    {
                        MmatriculaId = Convert.ToInt32( dtMatricula.Rows[0]["idmatricula"].ToString());

                    }


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
            Pagos.frm_pagos_lista popPop = new Pagos.frm_pagos_lista(MmatriculaId);
            DialogResult dialogResult = popPop.ShowDialog();
            int idconcepto = popPop.idConcepto;
           

            if (dialogResult == DialogResult.OK)
            {
           



                // DataTable dt = _conceptoNegocio.listarconcepto(idconcepto) as DataTable;
                // dgvPagos.DataSource = dt;
                        DataTable dt = new DataTable();
                dt=_conceptoNegocio.listarconcepto(idconcepto);
             //   Session.Add("conceptos", dt);





                var bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dgvPagos.DataSource = bindingSource;

                bindingSource.ResetBindings(false);




            }



        }
    }
}
