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
    public partial class addMatricula : Form
    {
        ENiveles eNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        EMatricula eMatricula = new EMatricula();
        MatriculaNegocio matriculaNeg = new MatriculaNegocio();

        CatalogoNegocio catalogoNeg = new CatalogoNegocio();

        AlumnoNegocio alumnoNeg = new AlumnoNegocio();

        public int v_idAlumno { get; set; }




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

            if (Validation.hasValidationErrors(this.Controls))
            {
                this.DialogResult = DialogResult.None;
                return;

            }
            else
            {

               
                try
                {
                    DateTime fechaConvert = Convert.ToDateTime(txtfecha.Text);

                    eMatricula.idAlumno = v_idAlumno;
                    eMatricula.idNivel = Convert.ToInt32(cmbNivel.SelectedValue.ToString());
                    eMatricula.periodo = txtperiodo.Text;
                    eMatricula.seccion = txtseccion.Text;
                    eMatricula.fecha = fechaConvert;
                    eMatricula.hora = txthora.Text;
                   if (matriculaNeg.agregar(eMatricula)){

                        MessageBox.Show("Matricula registrada", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                   else {
                        MessageBox.Show(eMatricula.mensajeResp, "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }






                }
                catch (Exception)
                {

                    throw;
                    MessageBox.Show("Registro de Matricula", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }






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
            DataTable dt;
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                if ((popUp.idAlumno != null) && (popUp.idAlumno!=0)){
                    txtAlumno.Text = string.Empty;

                    dt = alumnoNeg.consultarAlumno(popUp.idAlumno,null);
                    string nombreAlumno = dt.Rows[0]["Nombres"].ToString()+" "+ dt.Rows[0]["Apellidos"].ToString();

                     v_idAlumno = Convert.ToInt32(dt.Rows[0]["idAlumno"].ToString()); 


                    txtAlumno.Text = nombreAlumno;    

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
