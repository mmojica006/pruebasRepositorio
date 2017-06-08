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


namespace Interfaces.Matricula
{
    public partial class editMatricula : Form
    {

        ENiveles eNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        EMatricula eMatricula = new EMatricula();
        MatriculaNegocio matriculaNeg = new MatriculaNegocio();

        CatalogoNegocio catalogoNeg = new CatalogoNegocio();

        AlumnoNegocio alumnoNeg = new AlumnoNegocio();

        public int idAlumnoEdit { get; set; }

        public editMatricula( int idAlumno = 0)
        {
            InitializeComponent();
            DateTime time = DateTime.Now;
            string format = "h:mm";
            hora.Text = time.ToString(format);


            DateTime fecha = DateTime.Now;
            string format2 = "";
            fechaEdit.Text = fecha.ToString("d");

            DataTable dt;

            dt = catalogoNeg.getPeriodo();
            txtperiodo.Text = dt.Rows[0]["value"].ToString();




            llenarCombo();
            idAlumnoEdit = idAlumno;
            llenarData(idAlumno);
        }                                                                                                                                                                                          

        private void llenarData(int idAlumno)
        {
            DataTable dt;
            dt = matriculaNeg.Buscar(idAlumno);

            txtseccion.Text = dt.Rows[0]["seccion"].ToString();
            txtAlumno.Text = dt.Rows[0]["Nombres"].ToString();



        }

        private void llenarCombo()
        {
            cmbNivel.DataSource = nivelNeg.nivelCombo();

            cmbNivel.DisplayMember = "Nivel";
            cmbNivel.ValueMember = "idnivel";
            cmbNivel.Enabled = true;
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
                eMatricula.idAlumno = idAlumnoEdit;
                eMatricula.idNivel = Convert.ToInt32(cmbNivel.SelectedValue.ToString());
                eMatricula.seccion = txtseccion.Text;
                 if (matriculaNeg.editar(eMatricula)){
                    MessageBox.Show("Matricula actualizada", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }




            }

        }

        private void txtseccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtseccion.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtseccion, "La sección es requerida");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtseccion, "");
        }
    }
}
