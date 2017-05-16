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
    public partial class frmNivel : Form
    {
        ENiveles entidadNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        public frmNivel()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nivel.registroNivel registroNivel = new nivel.registroNivel();
            DialogResult dialogResult = registroNivel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                gvNivel.DataSource = nivelNeg.listarNivel(0,null);


            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
            registroNivel.Dispose();


        }
    }
}
