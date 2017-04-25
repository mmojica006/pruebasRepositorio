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
    }
}
