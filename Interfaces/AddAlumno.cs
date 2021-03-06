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
    public partial class AddAlumno : Form
    {
        private string imgPath = String.Empty;
        AlumnoNegocio AlumnoNeg = new AlumnoNegocio();
        EAlumnos AlumnoEnti = new EAlumnos();

        public AddAlumno()
        {
            InitializeComponent();
            pictFoto.Image = Properties.Resources.usuario;
            txtcedula.Focus();
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombre.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtnombre, "El nombre es requerido");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtnombre, "");
        }

        private void txtapellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellido.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtapellido, "El apellido es requerido");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtapellido, "");

        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtDireccion, "La dirección es requerida");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtDireccion, "");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validation.hasValidationErrors(this.Controls))
            {
                this.DialogResult = DialogResult.None;
                return;

            }   else
                {

            try
            {
                AlumnoEnti.cedula = txtcedula.Text;
                AlumnoEnti.nombres = txtnombre.Text;
                AlumnoEnti.napellidos = txtapellido.Text;
                AlumnoEnti.celular = int.Parse( txtcelular.Text);
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
                   //boquearControles();
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
    }
}
