using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces.Matricula
{
    public partial class addMatricula : Form
    {
        public addMatricula()
        {
            InitializeComponent();
            DateTime time = DateTime.Now;
            string format = "h:mm";
            txthora.Text = time.ToString(format);


            DateTime fecha = DateTime.Now;
            string format2 = "";
            txtfecha.Text = fecha.ToString("d");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
