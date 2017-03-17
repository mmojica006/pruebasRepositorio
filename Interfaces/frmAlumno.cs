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
using Interfaces.Helpers;

namespace Interfaces
{
    public partial class frmAlumno : Form
    {
        private string imgPath = String.Empty;
        AlumnoNegocio AlumnoNeg = new AlumnoNegocio();
        EAlumnos AlumnoEnti = new EAlumnos();


        public frmAlumno()
        {
          

            InitializeComponent();

            bloquearControles();
            pictFoto.Image = Properties.Resources.usuario;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnnuevo.Enabled = false;

      

        }

        private void pictFoto_Click(object sender, EventArgs e)
        {


            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dialogResult = new DialogResult();
                openFileDialog.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    Image img = bmp.GetThumbnailImage(480, 480, null, IntPtr.Zero);

                    pictFoto.BackgroundImage = null;
                    pictFoto.InitialImage = null;
                    pictFoto.Image = null;
                    pictFoto.BackgroundImageLayout = ImageLayout.Stretch;
                    pictFoto.BackgroundImage = img;
                    imgPath = openFileDialog.FileName;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Subir Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictFoto_MouseMove(object sender, MouseEventArgs e)
        {
            pictFoto.Cursor = Cursors.Hand;
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombre.Text.Trim() == String.Empty)
            {
                epError.SetError(txtnombre, "El nombre es requerido");
                e.Cancel = true;
            }
            else
                epError.SetError(txtnombre, "");

        }

        private void txtapellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellido.Text.Trim() == String.Empty)
            {
                epError.SetError(txtapellido, "El nombre es requerido");
                e.Cancel = true;
            }
            else
                epError.SetError(txtapellido, "");

        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == String.Empty)
            {
                epError.SetError(txtDireccion, "La dirección es requerida");
                e.Cancel = true;
            }
            else
                epError.SetError(txtDireccion, "");

        }

        private void bloquearControles()
        {
            txtcedula.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtcelular.Enabled = false;
            txttelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtnombrePadre.Enabled = false;
            txtNombreMadre.Enabled = false;
            txtApodreado.Enabled = false;

            rbmasculino.Enabled = false;
            rbfemenino.Enabled = false;
            pictFoto.Enabled = false;

            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSalir.Enabled = false;


        }

        private void ActivarControles()
        {
            txtcedula.Enabled = true;
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtcelular.Enabled = true;
            txttelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtnombrePadre.Enabled = true;
            txtNombreMadre.Enabled = true;
            txtApodreado.Enabled = true;

            rbmasculino.Enabled = true;
            rbfemenino.Enabled = true;
            pictFoto.Enabled = true;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnSalir.Enabled = true;


        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopupBuscar_Alumno popup = new PopupBuscar_Alumno();
            DialogResult dialogResult =  popup.ShowDialog(); 

            if (dialogResult== DialogResult.OK)
            {

            } else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked on Cancel"); 
            }
            popup.Dispose(); 

        }

        // This code snippet is from the SO thread linked above (by Ed S)
        void ChangeEnabled(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
            }
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }





        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // the controls collection can be the whole form or just a panel or group
            if (Validation.hasValidationErrors(this.Controls))
                return;


            try
            {
                AlumnoEnti.cedula = txtcedula.Text;
                AlumnoEnti.nombres = txtnombre.Text;
                AlumnoEnti.napellidos = txtapellido.Text;
                AlumnoEnti.celular = Convert.ToInt32(txtcelular.Text);
                AlumnoEnti.telefono = txttelefono.Text;
                AlumnoEnti.direccion = txtDireccion.Text;
                AlumnoEnti.fechaNac = Convert.ToDateTime(dtpfNacimiento.Text);
                AlumnoEnti.sexo = rbmasculino.Checked ? "M" : "F";
                AlumnoEnti.nomPadre = txtnombrePadre.Text;
                AlumnoEnti.nomMadre = txtNombreMadre.Text;
                AlumnoEnti.nomApoderado = txtApodreado.Text;
                AlumnoEnti.foto = Utility.ReadFile(imgPath != String.Empty ? imgPath : null);

                if (!AlumnoNeg.insertarAlumno(AlumnoEnti))
                {
                    MessageBox.Show(AlumnoEnti.mensageResp, "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Alumno ingresado correctamente", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
