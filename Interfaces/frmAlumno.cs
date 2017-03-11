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
    public partial class frmAlumno : Form
    {
        AlumnoNegocio AlumnoNeg = new AlumnoNegocio();
        EAlumnos AlumnoEnti = new EAlumnos();

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            try
            {
                AlumnoEnti.cedula = txtcedula.Text;
                AlumnoEnti.nombres = txtnombre.Text;
                AlumnoEnti.napellidos = txtapellido.Text;
                AlumnoEnti.celular = txtcelular.Text;
                AlumnoEnti.telefono = txttelefono.Text;
                AlumnoEnti.direccion = txtDireccion.Text;
                AlumnoEnti.fechaNac = Convert.ToDateTime(txtFechaNacimiento.Text);
               // AlumnoEnti.sexo=


            }
            catch (Exception ex)
            {

            }
        }
    }
}
