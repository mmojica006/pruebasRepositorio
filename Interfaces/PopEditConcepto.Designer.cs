namespace Interfaces
{
    partial class PopEditConcepto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopEditConcepto));
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.elPanel2 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.elRichLabel2 = new Klik.Windows.Forms.v1.EntryLib.ELRichLabel();
            this.btnSalir = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnGuardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elPanel1 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.dtpfNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elRichLabel1 = new Klik.Windows.Forms.v1.EntryLib.ELRichLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).BeginInit();
            this.elPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).BeginInit();
            this.elPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // elPanel2
            // 
            this.elPanel2.BackgroundStyle.GradientAngle = 45F;
            this.elPanel2.Controls.Add(this.elRichLabel2);
            this.elPanel2.Controls.Add(this.btnSalir);
            this.elPanel2.Controls.Add(this.btnGuardar);
            this.elPanel2.Location = new System.Drawing.Point(422, 15);
            this.elPanel2.Name = "elPanel2";
            this.elPanel2.Size = new System.Drawing.Size(156, 146);
            this.elPanel2.TabIndex = 3;
            // 
            // elRichLabel2
            // 
            this.elRichLabel2.Location = new System.Drawing.Point(31, 3);
            this.elRichLabel2.Name = "elRichLabel2";
            this.elRichLabel2.Size = new System.Drawing.Size(85, 28);
            this.elRichLabel2.TabIndex = 5;
            this.elRichLabel2.Text = "Operaciones";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageStyle.Alpha = 100;
            this.btnSalir.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSalir.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.BorderStyle.EdgeRadius = 7;
            this.btnSalir.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnSalir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnSalir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnSalir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Location = new System.Drawing.Point(31, 91);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnSalir.TextStyle.Text = "Salir";
            this.btnSalir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnGuardar.Location = new System.Drawing.Point(31, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 50);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.TextStyle.Text = "Guardar";
            this.btnGuardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // elPanel1
            // 
            this.elPanel1.BackgroundStyle.GradientAngle = 45F;
            this.elPanel1.Controls.Add(this.dtpfNacimiento);
            this.elPanel1.Controls.Add(this.txtprecio);
            this.elPanel1.Controls.Add(this.txtdescripcion);
            this.elPanel1.Controls.Add(this.label3);
            this.elPanel1.Controls.Add(this.label2);
            this.elPanel1.Controls.Add(this.label1);
            this.elPanel1.Controls.Add(this.elRichLabel1);
            this.elPanel1.Location = new System.Drawing.Point(12, 12);
            this.elPanel1.Name = "elPanel1";
            this.elPanel1.Size = new System.Drawing.Size(404, 149);
            this.elPanel1.TabIndex = 2;
            // 
            // dtpfNacimiento
            // 
            this.dtpfNacimiento.Location = new System.Drawing.Point(118, 83);
            this.dtpfNacimiento.Name = "dtpfNacimiento";
            this.dtpfNacimiento.Size = new System.Drawing.Size(271, 20);
            this.dtpfNacimiento.TabIndex = 41;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(118, 118);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(271, 20);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecio_Validating);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(118, 44);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(271, 20);
            this.txtdescripcion.TabIndex = 6;
            this.txtdescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtdescripcion_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            // 
            // elRichLabel1
            // 
            this.elRichLabel1.Location = new System.Drawing.Point(3, 3);
            this.elRichLabel1.Name = "elRichLabel1";
            this.elRichLabel1.Size = new System.Drawing.Size(229, 28);
            this.elRichLabel1.TabIndex = 2;
            this.elRichLabel1.Text = "Atualizar Concepto de Pago";
            // 
            // PopEditConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 181);
            this.Controls.Add(this.elPanel2);
            this.Controls.Add(this.elPanel1);
            this.DoubleBuffered = true;
            this.Name = "PopEditConcepto";
            this.Text = "Actualizar concepto";
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).EndInit();
            this.elPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).EndInit();
            this.elPanel1.ResumeLayout(false);
            this.elPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private System.Windows.Forms.ErrorProvider errProvider;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel2;
        private Klik.Windows.Forms.v1.EntryLib.ELRichLabel elRichLabel2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnSalir;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnGuardar;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel1;
        private System.Windows.Forms.DateTimePicker dtpfNacimiento;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELRichLabel elRichLabel1;
    }
}