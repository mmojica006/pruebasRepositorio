﻿using System;
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
    public partial class PopupBuscar_Alumno : Form
    {
        AlumnoNegocio AlumnoNeg = new AlumnoNegocio();
        EAlumnos AlumnoEnti = new EAlumnos();

        public PopupBuscar_Alumno()
        {
            InitializeComponent();
        }

        private void btnPopBuscar_Click(object sender, EventArgs e)
        {
            if (txtPopalumno.Text!=String.Empty)
            {
                dgvAlumno.DataSource = AlumnoNeg.consultarAlumno(txtPopalumno.Text.Trim());
              
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.DataBindings!=null)

            {

            }

        }
    }
}
