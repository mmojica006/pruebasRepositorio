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

namespace Interfaces.Pagos
{
    public partial class frmBuscarAlumnosMatriculados : Form
    {

        PagosNegocio _pagoNegocio = new PagosNegocio();

        public int idAlumno { get; set; }
        public int idMatriculaBuscar { get; set; }

        public frmBuscarAlumnosMatriculados()
        {
            InitializeComponent();
            mostrarAlumnosMat(0, null);

        }

        private void mostrarAlumnosMat(int idalumno, string nombre)
        {
            dgvAlumno.AutoGenerateColumns = true;
            dgvAlumno.DataSource = _pagoNegocio.consultaMatAlumno(idalumno, nombre);
            this.dgvAlumno.Columns["idmatricula"].Visible = false;
            this.dgvAlumno.Columns["nomapoderado"].Visible = false;
            this.dgvAlumno.Columns["fechanac"].Visible = false; 
            this.dgvAlumno.Columns["Nivel"].Width = 150;
            this.dgvAlumno.Columns["seccion"].Width = 50;



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.DataSource != null)
            {

                idAlumno = Convert.ToInt32(this.dgvAlumno.CurrentRow.Cells[1].Value.ToString());
                idMatriculaBuscar = Convert.ToInt32(this.dgvAlumno.CurrentRow.Cells[0].Value.ToString());

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtAlumno.Text != String.Empty)
            {
                mostrarAlumnosMat( 0,txtAlumno.Text.Trim());

            }


        }
    }
}
