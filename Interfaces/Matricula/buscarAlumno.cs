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
    public partial class buscarAlumno : Form
    {

        AlumnoNegocio alumnoNeg = new AlumnoNegocio();

        public int idAlumno { get; set; }
     

        public buscarAlumno()
        {
            InitializeComponent();
            mostrarAlumnos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtAlumno.Text != String.Empty)
            {
                dgvAlumno.DataSource = alumnoNeg.consultarAlumno(0, txtAlumno.Text.Trim());

            }
        }

        private void mostrarAlumnos()
        {
            dgvAlumno.AutoGenerateColumns = true;
            dgvAlumno.DataSource = alumnoNeg.consultarAlumno(0, null);
            this.dgvAlumno.Columns["IdAlumno"].Visible = false;




        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.DataSource != null)
            {

                 idAlumno = Convert.ToInt32(this.dgvAlumno.CurrentRow.Cells[0].Value.ToString());

            }

        }
    }
    }
