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
            frmAlumno menu = new frmAlumno();
            menu.Show();



        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocente formDocente = new frmDocente();
            formDocente.Show();
        }

        private void regitrarMatrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatriculaInscripcion formMatPago = new frmMatriculaInscripcion();
            formMatPago.Show();

        }
    }
}
