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

namespace Interfaces
{
    public partial class frmAlumno : Form
    {
        AlumnoNegocio AlumnoNeg = new AlumnoNegocio();
        EAlumnos AlumnoEnti = new EAlumnos();

        public frmAlumno()
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            
            InitializeComponent();
          
            pictFoto.Image = Properties.Resources.usuario;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    AlumnoEnti.cedula = txtcedula.Text;
                    AlumnoEnti.nombres = txtnombre.Text;
                    AlumnoEnti.napellidos = txtapellido.Text;
                    AlumnoEnti.celular = txtcelular.Text;
                    AlumnoEnti.telefono = txttelefono.Text;
                    AlumnoEnti.direccion = txtDireccion.Text;
                    AlumnoEnti.fechaNac = Convert.ToDateTime(dtpfNacimiento.Text);
                    AlumnoEnti.sexo = rbmasculino.Checked ? "M" : "F";
                    AlumnoEnti.nomPadre = txtnombrePadre.Text;
                    AlumnoEnti.nomMadre = txtNombreMadre.Text;
                    AlumnoEnti.nomApoderado = txtApodreado.Text;
                    AlumnoEnti.foto = null;

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

                }
            }
            else
            {
                MessageBox.Show("There are invalid controls on the form.");
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
                }

                                                         

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Subir Foto",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
          }


            

        }

        private void pictFoto_MouseMove(object sender, MouseEventArgs e)
        {
            pictFoto.Cursor = Cursors.Hand;
        }

   

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(txtnombre.Text);
            this.epError.SetError(txtnombre, "Nama Barang Harus Diisi..!!");



            //if (txtnombre.Text.Trim().Length == 0)
            //{
            //    epError.SetError(txtnombre, "Introducir el nombre...");
            //    txtnombre.Focus();
            //}
            //else
            //{
            //    epError.Clear();
            //}

        }
    }
}
