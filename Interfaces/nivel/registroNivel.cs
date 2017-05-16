using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces.nivel
{
    public partial class registroNivel : Form
    {
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
    }
}
