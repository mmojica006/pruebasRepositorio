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

namespace Interfaces.nivel
{
    public partial class buscarMaestro : Form
    {
        public int selectedIdEmpleado { get; set; }
        Eempleado _empleado = new Eempleado();
        EmpleadoNegocio emplNeg = new EmpleadoNegocio();

        public buscarMaestro()
        {
            InitializeComponent();
            mostrarEmpleados();
        }

        private void mostrarEmpleados()
        {
            dgvEmpleado.DataSource = emplNeg.listarEmpleado(0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.DataSource != null)

            {
                selectedIdEmpleado = Convert.ToInt32(this.dgvEmpleado.CurrentRow.Cells[0].Value.ToString());
            }

        }
    }
}
