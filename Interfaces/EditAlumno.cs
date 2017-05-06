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

namespace Interfaces
{
    public partial class EditAlumno : Form
    {   //Intanciando las capas.

        EAlumnos AlumnoEnti = new EAlumnos();
        AlumnoNegocio _alumnoNegocio = new AlumnoNegocio();
        private string imgPath = String.Empty;


        public EditAlumno(int idalumno)
        {
            InitializeComponent();

            showData(idalumno);
        }

        private void showData(int idalumno)
        {
            CleanText();
            DataTable dt;
            dt = _alumnoNegocio.consultarAlumno(idalumno,null);


            if (dt != null)
            {
                txtapellido.Text = dt.Rows[0]["Apellidos"].ToString();
                txtApodreado.Text = dt.Rows[0]["NomApoderado"].ToString();
                txtcedula.Text = dt.Rows[0]["Cedula"].ToString();
                txtcelular.Text = dt.Rows[0]["Celular"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtnombre.Text = dt.Rows[0]["Nombres"].ToString();
                txtNombreMadre.Text = dt.Rows[0]["NomMadre"].ToString();
                txtnombrePadre.Text = dt.Rows[0]["NomPadre"].ToString();
                txttelefono.Text = dt.Rows[0]["Telefono"].ToString();
                dtpfNacimiento.Value = Convert.ToDateTime(dt.Rows[0]["FechaNac"].ToString());
                
                                  
                byte[] imgBytes = (byte[]) dt.Rows[0]["imagen"];
                if (imgBytes!= null && imgBytes.Length > 0)
                { 
                // If you want convert to a bitmap file
                TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap)); 
                Bitmap MyBitmap = (Bitmap)tc.ConvertFrom(imgBytes);   
                pictFoto.Image = MyBitmap;
                  //  imgPath = pictFoto.Image;
                }
                else
                {
                    pictFoto.Image = Properties.Resources.usuario; 
                }


            }
        }

        private void CleanText()
        {
            txtapellido.Text = String.Empty;
            txtApodreado.Text = String.Empty;
            txtcedula.Text = String.Empty;
            txtcelular.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtnombre.Text = String.Empty;
            txtNombreMadre.Text = String.Empty;
            txtnombrePadre.Text = String.Empty;
            txttelefono.Text = String.Empty;
            pictFoto.BackgroundImage = null;
            pictFoto.InitialImage = null;
            pictFoto.Image = null;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validation.hasValidationErrors(this.Controls))
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
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
                  //  AlumnoEnti.foto = pictFoto.Image;// Utility.ReadFile(imgPath);

                    if (!_alumnoNegocio.insertarAlumno(AlumnoEnti))
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

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombre.Text.Trim() == String.Empty)
            {
                errProvider.SetError(txtnombre, "El nombre es requerido");
                e.Cancel = true;
            }
            else
                errProvider.SetError(txtnombre, "");
        }

        private void txtapellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellido.Text.Trim() == String.Empty)
            {
                errProvider.SetError(txtapellido, "El apellido es requerido");
                e.Cancel = true;
            }
            else
                errProvider.SetError(txtapellido, "");
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == String.Empty)
            {
                errProvider.SetError(txtDireccion, "La dirección es requerida");
                e.Cancel = true;
            }
            else
                errProvider.SetError(txtDireccion, "");
        }
    }
}
