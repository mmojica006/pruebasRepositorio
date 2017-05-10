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

namespace Interfaces.Empleado
{
    public partial class empleado : Form
    {
        public int selectIdEmp { get; set; }
        Eempleado _empleado = new Eempleado();
        EmpleadoNegocio empleadoNeg = new EmpleadoNegocio();

        public empleado()
        {
            InitializeComponent();
            gvEmpleado.DataSource = empleadoNeg.listarEmpleado(0);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Empleado.addEmpleado popUp = new Empleado.addEmpleado();
            DialogResult dialogResult = popUp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                gvEmpleado.DataSource = empleadoNeg.listarEmpleado(0);


            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
            popUp.Dispose();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            selectIdEmp = Convert.ToInt32(this.gvEmpleado.CurrentRow.Cells[0].Value.ToString());
            editEmpleado popEditEmp = new editEmpleado(selectIdEmp);
            DialogResult dialogResult = popEditEmp.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                gvEmpleado.DataSource = empleadoNeg.listarEmpleado(0);
            }





        }
    }
}
