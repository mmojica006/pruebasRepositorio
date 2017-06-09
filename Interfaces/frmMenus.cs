using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
            InitializeComponent();
        }

        private void registrarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEstudiantes menu = new frmEstudiantes();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matricula.frmMatricula formDocente = new Matricula.frmMatricula();
            formDocente.Show();
        }

        private void regitrarMatrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatriculaInscripcion formMatPago = new frmMatriculaInscripcion();
            formMatPago.Show();

        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConceptos formConceptos = new frmConceptos();
            formConceptos.Show();

        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.empleado formEmpleado = new Empleado.empleado();
            formEmpleado.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fromUsuario = new frmUsuarios();
            fromUsuario.Show();
        }

        private void nivelesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nivel.frmNivel _nivel = new nivel.frmNivel();
            _nivel.Show();
        }

        private void pagoDeMatriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos.frmPagos _pagos = new Pagos.frmPagos();
            _pagos.Show();
        }
    }
}
