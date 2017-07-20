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
using System.Collections;

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

        EConcepto _econcepto = new EConcepto();
        ConceptoNegocio _conceptoNegocio = new ConceptoNegocio();


        DataTable dtTable = new DataTable();

        private DataTable _dtTable;
        public DataTable DtTable
        {
            get { return _dtTable; }
            set { _dtTable = value; }
        }

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
                DataTable dtAll = new DataTable();


                dtAll = _conceptoNegocio.listarconcepto(idconcepto);

                //DataRow dr = dtTable.NewRow();
                //dtTable.Rows.Add(dr);
                //dgvPagos.DataSource = dtTable;
                if (dgvPagos.Columns.Contains("IdConcepto") && dgvPagos.Columns["IdConcepto"].Visible)
                {

              
                dgvPagos.Columns.Add("IdConcepto", "ID");
                dgvPagos.Columns.Add("Nombre","Nombre");
                dgvPagos.Columns.Add("FechaVencimiento", "Fec Vencimiento");
                dgvPagos.Columns.Add("Precio", "Precio");
                dgvPagos.Columns.Add("Estado", "Estado");

                dgvPagos.Columns[0].Width = 50;
                dgvPagos.Columns[1].Width = 150;
                dgvPagos.Columns[2].Width = 120;
                dgvPagos.Columns[4].Width = 50;
                }



                //foreach (DataColumn dc in dtAll.Columns)
                //{

                //    dgvPagos.Columns.Add(new DataGridViewTextBoxColumn());

                //}
                foreach (DataRow dr2 in dtAll.Rows)
                {

                    dgvPagos.Rows.Add(dr2.ItemArray);

                }

                // DataTable dt = _conceptoNegocio.listarconcepto(idconcepto) as DataTable;
                // dgvPagos.DataSource = dt;
                //DataTable dt = new DataTable();



                //  dt = _conceptoNegocio.listarconcepto(idconcepto);

                //  SaveData(idconcepto);



                // dtAll = this.DtTable;












                //   Session.Add("conceptos", dt);





                //    var bindingSource = new BindingSource();
                //bindingSource.DataSource = this.DtTable;
                //dgvPagos.DataSource = bindingSource;
                //bindingSource.ResetBindings(false);



                // dgvPagos.DataSource = dtAll;


            }



        }

        private void SaveData(int id)
        {
            DataTable dt;
            dt = _conceptoNegocio.listarconcepto(id);

            List<EConcepto> ConceptosList = new List<EConcepto>();
            ConceptosList = (from DataRow dr in dt.Rows
                             select new EConcepto()
                             {
                                 IdConcepto = Convert.ToInt32(dr["IdConcepto"].ToString()),
                                 Nombre = dr["Nombre"].ToString(),
                                 FechaVenc = Convert.ToDateTime(dr["FechaVencimiento"].ToString()),
                                 Precio = Convert.ToDecimal(dr["Precio"]),
                                 Estado = dr["Estado"].ToString()




                             }).ToList();



        }
    }
}
