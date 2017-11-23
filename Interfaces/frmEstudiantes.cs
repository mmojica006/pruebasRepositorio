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

namespace Interfaces
{
    public partial class frmEstudiantes : Form
    {

        public int idAlumno { get; set; }
        AlumnoNegocio alumnoNeg = new AlumnoNegocio();
        EAlumnos eAlumnos = new EAlumnos();

        public frmEstudiantes()
        {
            InitializeComponent();                 
            mostrarAlumnos();
        }

        private void mostrarAlumnos()
        {
            gvEstudiante.AutoGenerateColumns = true;
            gvEstudiante.DataSource = alumnoNeg.consultarAlumno(0, null);
            this.gvEstudiante.Columns["IdAlumno"].Visible = false;




        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            AddAlumno addalumno = new AddAlumno();
            DialogResult dialogResult = addalumno.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mostrarAlumnos();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            idAlumno = Convert.ToInt32(this.gvEstudiante.CurrentRow.Cells[0].Value.ToString(),null);
            EditAlumno editAlumno = new EditAlumno(idAlumno > 0 ? idAlumno:0);
            DialogResult dialogResult = editAlumno.ShowDialog();

            if (dialogResult== DialogResult.OK)
            {
                gvEstudiante.DataSource = alumnoNeg.consultarAlumno(0, null);
             
            }


        }

        private void btnPopBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar el registro?", "Formulario para eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                idAlumno = Convert.ToInt32(this.gvEstudiante.CurrentRow.Cells[0].Value.ToString(), null);

                eAlumnos.idAlumno = idAlumno;

                if (alumnoNeg.eliminarAlumno(eAlumnos))
                {

                    MessageBox.Show(eAlumnos.mensageResp, "Eliminando Registro");
                    mostrarAlumnos();

                }
                else
                {
                    MessageBox.Show(eAlumnos.mensageResp, "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }
}
