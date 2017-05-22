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
    public partial class modificarNivel : Form
    {
        Eempleado entEmp = new Eempleado();
        EmpleadoNegocio empNeg = new EmpleadoNegocio();

        ENiveles entNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        private string[] comboInicial = new[] { "3 años", "4 años", "5 años" };
        private string[] comboPrimaria = new[] { "1º", "2º", "3º", "4º", "5º" };
        private string[] comboSecundaria = new[] { "1º", "2º", "3º", "4º", "5º" };


        public modificarNivel(int idNivel=0)
        {
            InitializeComponent();

            cargarComboGrado();
            llenarData(idNivel);
         

            
        }
        private void cargarComboGrado()
        {
            cmbGrado.Items.Add("Inicial");
            cmbGrado.Items.Add("Primaria");
            cmbGrado.Items.Add("Secundaria");
            cmbGrado.SelectedIndex = 0;


        }

        private void llenarData(int idNivel)
        {
            DataTable dt;
            dt = nivelNeg.listarNivel(idNivel);

            if (dt.Rows.Count > 0){
                txtEmpleado.Text = dt.Rows[0]["Nombres"].ToString();
                txtVacante.Text= dt.Rows[0]["NroVacantes"].ToString();
                string  grado = dt.Rows[0]["Grado"].ToString();

                cmbGrado.SelectedItem = grado;
            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbGrado.SelectedItem as string;

            switch (selectedValue)
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
    }
}
