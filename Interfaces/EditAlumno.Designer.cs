namespace Interfaces
{
    partial class EditAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAlumno));
            this.elTab1 = new Klik.Windows.Forms.v1.EntryLib.ELTab();
            this.elTabPage1 = new Klik.Windows.Forms.v1.EntryLib.ELTabPage();
            this.dtpfNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictFoto = new System.Windows.Forms.PictureBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elTabPage2 = new Klik.Windows.Forms.v1.EntryLib.ELTabPage();
            this.txtNombreMadre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtApodreado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnombrePadre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.elContainer1 = new Klik.Windows.Forms.v1.EntryLib.ELContainer();
            this.btncancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnGuardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.elTab1)).BeginInit();
            this.elTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elTabPage1)).BeginInit();
            this.elTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elTabPage2)).BeginInit();
            this.elTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elContainer1)).BeginInit();
            this.elContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // elTab1
            // 
            this.elTab1.Location = new System.Drawing.Point(14, 15);
            this.elTab1.Name = "elTab1";
            this.elTab1.Size = new System.Drawing.Size(953, 250);
            this.elTab1.TabCaptionStyle.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elTab1.TabCaptionStyle.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.SystemColors.ActiveCaption;
            this.elTab1.TabIndex = 20;
            this.elTab1.TabPages.Add(this.elTabPage1);
            this.elTab1.TabPages.Add(this.elTabPage2);
            // 
            // elTabPage1
            // 
            this.elTabPage1.CaptionTextStyle.Text = "ALUMNO";
            this.elTabPage1.Controls.Add(this.dtpfNacimiento);
            this.elTabPage1.Controls.Add(this.rbfemenino);
            this.elTabPage1.Controls.Add(this.rbmasculino);
            this.elTabPage1.Controls.Add(this.txtapellido);
            this.elTabPage1.Controls.Add(this.label20);
            this.elTabPage1.Controls.Add(this.lblcedula);
            this.elTabPage1.Controls.Add(this.label9);
            this.elTabPage1.Controls.Add(this.pictFoto);
            this.elTabPage1.Controls.Add(this.txttelefono);
            this.elTabPage1.Controls.Add(this.label5);
            this.elTabPage1.Controls.Add(this.txtcelular);
            this.elTabPage1.Controls.Add(this.label4);
            this.elTabPage1.Controls.Add(this.txtnombre);
            this.elTabPage1.Controls.Add(this.label3);
            this.elTabPage1.Controls.Add(this.txtDireccion);
            this.elTabPage1.Controls.Add(this.label2);
            this.elTabPage1.Controls.Add(this.txtcedula);
            this.elTabPage1.Controls.Add(this.label1);
            this.elTabPage1.Location = new System.Drawing.Point(1, 23);
            this.elTabPage1.Name = "elTabPage1";
            this.elTabPage1.Size = new System.Drawing.Size(951, 226);
            // 
            // dtpfNacimiento
            // 
            this.dtpfNacimiento.Location = new System.Drawing.Point(474, 24);
            this.dtpfNacimiento.Name = "dtpfNacimiento";
            this.dtpfNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpfNacimiento.TabIndex = 40;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(582, 51);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rbfemenino.TabIndex = 38;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Checked = true;
            this.rbmasculino.Location = new System.Drawing.Point(474, 51);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 37;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(115, 83);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(266, 20);
            this.txtapellido.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(32, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Apellido";
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(391, 51);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(31, 13);
            this.lblcedula.TabIndex = 28;
            this.lblcedula.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "F-Nacimiento";
            // 
            // pictFoto
            // 
            this.pictFoto.Location = new System.Drawing.Point(734, 17);
            this.pictFoto.Name = "pictFoto";
            this.pictFoto.Size = new System.Drawing.Size(214, 192);
            this.pictFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFoto.TabIndex = 25;
            this.pictFoto.TabStop = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(114, 141);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(266, 20);
            this.txttelefono.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Teléfono";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(114, 115);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(266, 20);
            this.txtcelular.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Celular";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(115, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(266, 20);
            this.txtnombre.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 170);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(598, 39);
            this.txtDireccion.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dirección";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(115, 21);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(266, 20);
            this.txtcedula.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cédula";
            // 
            // elTabPage2
            // 
            this.elTabPage2.CaptionTextStyle.Text = "DATOS DE LOS PADRES";
            this.elTabPage2.Controls.Add(this.txtNombreMadre);
            this.elTabPage2.Controls.Add(this.label16);
            this.elTabPage2.Controls.Add(this.txtApodreado);
            this.elTabPage2.Controls.Add(this.label14);
            this.elTabPage2.Controls.Add(this.txtnombrePadre);
            this.elTabPage2.Controls.Add(this.label17);
            this.elTabPage2.Location = new System.Drawing.Point(1, 23);
            this.elTabPage2.Name = "elTabPage2";
            this.elTabPage2.Size = new System.Drawing.Size(951, 226);
            // 
            // txtNombreMadre
            // 
            this.txtNombreMadre.Location = new System.Drawing.Point(114, 57);
            this.txtNombreMadre.Name = "txtNombreMadre";
            this.txtNombreMadre.Size = new System.Drawing.Size(266, 20);
            this.txtNombreMadre.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Nombre Madre";
            // 
            // txtApodreado
            // 
            this.txtApodreado.Location = new System.Drawing.Point(114, 93);
            this.txtApodreado.Name = "txtApodreado";
            this.txtApodreado.Size = new System.Drawing.Size(266, 20);
            this.txtApodreado.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Apoderado";
            // 
            // txtnombrePadre
            // 
            this.txtnombrePadre.Location = new System.Drawing.Point(114, 21);
            this.txtnombrePadre.Name = "txtnombrePadre";
            this.txtnombrePadre.Size = new System.Drawing.Size(266, 20);
            this.txtnombrePadre.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Nombre Padre ";
            // 
            // elContainer1
            // 
            this.elContainer1.Controls.Add(this.btncancelar);
            this.elContainer1.Controls.Add(this.btnGuardar);
            this.elContainer1.Location = new System.Drawing.Point(13, 271);
            this.elContainer1.Name = "elContainer1";
            this.elContainer1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.elContainer1.Size = new System.Drawing.Size(953, 63);
            this.elContainer1.TabIndex = 19;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageStyle.Alpha = 100;
            this.btncancelar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btncancelar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.BorderStyle.EdgeRadius = 7;
            this.btncancelar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btncancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btncancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btncancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancelar.Location = new System.Drawing.Point(486, 6);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(96, 50);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btncancelar.TextStyle.Text = "Cancelar";
            this.btncancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageStyle.Alpha = 100;
            this.btnGuardar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnGuardar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.BorderStyle.EdgeRadius = 7;
            this.btnGuardar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnGuardar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnGuardar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(324, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 50);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.TextStyle.Text = "Guardar";
            this.btnGuardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 350);
            this.Controls.Add(this.elTab1);
            this.Controls.Add(this.elContainer1);
            this.Name = "EditAlumno";
            this.Text = "Modificar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.elTab1)).EndInit();
            this.elTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elTabPage1)).EndInit();
            this.elTabPage1.ResumeLayout(false);
            this.elTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elTabPage2)).EndInit();
            this.elTabPage2.ResumeLayout(false);
            this.elTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elContainer1)).EndInit();
            this.elContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELTab elTab1;
        private Klik.Windows.Forms.v1.EntryLib.ELTabPage elTabPage1;
        private System.Windows.Forms.DateTimePicker dtpfNacimiento;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictFoto;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELTabPage elTabPage2;
        private System.Windows.Forms.TextBox txtNombreMadre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtApodreado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnombrePadre;
        private System.Windows.Forms.Label label17;
        private Klik.Windows.Forms.v1.EntryLib.ELContainer elContainer1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btncancelar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnGuardar;
    }
}