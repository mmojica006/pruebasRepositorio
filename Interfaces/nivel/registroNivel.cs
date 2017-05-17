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

namespace Interfaces.nivel
{
    public partial class registroNivel : Form
    {
        Eempleado entEmp = new Eempleado();
        EmpleadoNegocio empNeg = new EmpleadoNegocio();

        ENiveles entNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        public registroNivel()
        {
            InitializeComponent();
            cargarComboGrado();
        }

        private string[] comboInicial = new[] { "3 años", "4 años", "5 años" };
        private string[] comboPrimaria = new[] { "1º", "2º", "3º", "4º" , "5º" };
        private string[] comboSecundaria = new[] { "1º", "2º", "3º", "4º", "5º" };

        private void cargarComboGrado()
        {
            cmbGrado.Items.Add("Inicial");
            cmbGrado.Items.Add("Primaria");
            cmbGrado.Items.Add("Secundaria");
            cmbGrado.SelectedIndex = 0;


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (Validation.hasValidationErrors(this.Controls))
                {
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else
                {

               if (nivelNeg.agregarNivel(entNivel))
                {
                    MessageBox.Show("Nivel registrado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }   else
                {

                }



                }

        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbGrado.SelectedItem as string;

            switch(selectedValue)
            {
                case "Inicial":
                    cmbOrden.Items.Clear();
                    cmbOrden.Items.AddRange(comboInicial);
                    cmbOrden.SelectedIndex = 0;
                    break;
                case "Primaria":
                    cmbOrden.Items.Clear();
                    cmbOrden.Items.AddRange(comboPrimaria);
                    cmbOrden.SelectedIndex = 0;
                    break;
                case "Secundaria":
                    cmbOrden.Items.Clear();
                    cmbOrden.Items.AddRange(comboSecundaria);
                    cmbOrden.SelectedIndex = 0;
                    break;


            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nivel.buscarMaestro buscarMaestro = new nivel.buscarMaestro();
            DialogResult dialogResult = buscarMaestro.ShowDialog();

            if (dialogResult==DialogResult.OK)
            {

                int idEmpleado = buscarMaestro.selectedIdEmpleado;

                entNivel.idTutor = idEmpleado;
                entNivel.grado = cmbGrado.SelectedItem.ToString();
                entNivel.orden = cmbOrden.SelectedItem.ToString();
                entNivel.vacantes = Convert.ToInt32( txtVacante.Text);

                DataTable dt = empNeg.listarEmpleado(idEmpleado);

                string nombre = dt.Rows[0]["Nombres"].ToString()+ dt.Rows[0]["Apellidos"].ToString();

                txtEmpleado.Text = nombre;



                



            }



        }

        private void txtEmpleado_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmpleado.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtEmpleado, "El nombre del profesor es requerido");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtEmpleado, "");


        }
    }
}
