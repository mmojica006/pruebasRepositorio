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

        public int idNivel { get; set; }
        ENiveles entidadNivel = new ENiveles();
        NivelNegocio nivelNeg = new NivelNegocio();

        public frmNivel()
        {
            InitializeComponent();
            mostrarNiveles();
        }

        private void mostrarNiveles()
        {
            gvNivel.DataSource = nivelNeg.listarNivel(0, null);
            gvNivel.Columns["IdNivel"].Visible = false;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            idNivel = Convert.ToInt32(this.gvNivel.CurrentRow.Cells[0].Value.ToString());

            nivel.modificarNivel modNivel = new nivel.modificarNivel(idNivel);
            DialogResult dialogResult = modNivel.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                gvNivel.DataSource = nivelNeg.listarNivel(0, null);



            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
            modNivel.Dispose();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Variable
            string MessageBoxTitle = "Niveles";
            string MessageBoxContent = "seguro que desea borrar el registro?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                idNivel = Convert.ToInt32(this.gvNivel.CurrentRow.Cells[0].Value.ToString());

                if (nivelNeg.eliminarNivel(idNivel))
                {
                    MessageBox.Show("Registro eliminado", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gvNivel.DataSource = nivelNeg.listarNivel(0, null);
                }
                else{
                    MessageBox.Show("Error en el proceso", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
