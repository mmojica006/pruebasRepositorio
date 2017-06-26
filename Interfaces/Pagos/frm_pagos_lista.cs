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
    public partial class frm_pagos_lista : Form
    {
        PagosNegocio pagosNeg = new PagosNegocio();
        public int idConcepto { get; set; }

        public frm_pagos_lista( int idMatricula)
        {
            InitializeComponent();
            cargarData(idMatricula);

        }

        private void cargarData(int idMatricula)
        {
            DataTable dt;

            dt = pagosNeg.listaPagosPendientes(idMatricula);
           
            if (dt.Rows.Count > 1)
            {
                dgvLista.DataSource = dt;
            }


        }

        private void frm_pagos_lista_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvLista.DataSource != null)

            {
                idConcepto = Convert.ToInt32(this.dgvLista.CurrentRow.Cells[0].Value.ToString());
            }


        }
    }
}
