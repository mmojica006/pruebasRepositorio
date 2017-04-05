namespace Interfaces
{
    partial class PopAddConcepto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopAddConcepto));
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.elPanel1 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.elPanel2 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.elRichLabel1 = new Klik.Windows.Forms.v1.EntryLib.ELRichLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.dtpfNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elButton1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elRichLabel2 = new Klik.Windows.Forms.v1.EntryLib.ELRichLabel();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).BeginInit();
            this.elPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).BeginInit();
            this.elPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
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
            this.elPanel1.Location = new System.Drawing.Point(12, 28);
            this.elPanel1.Name = "elPanel1";
            this.elPanel1.Size = new System.Drawing.Size(404, 149);
            this.elPanel1.TabIndex = 0;
            // 
            // elPanel2
            // 
            this.elPanel2.BackgroundStyle.GradientAngle = 45F;
            this.elPanel2.Controls.Add(this.elRichLabel2);
            this.elPanel2.Controls.Add(this.elButton1);
            this.elPanel2.Controls.Add(this.btnGuardar);
            this.elPanel2.Location = new System.Drawing.Point(422, 31);
            this.elPanel2.Name = "elPanel2";
            this.elPanel2.Size = new System.Drawing.Size(156, 146);
            this.elPanel2.TabIndex = 1;
            // 
            // elRichLabel1
            // 
            this.elRichLabel1.Location = new System.Drawing.Point(3, 3);
            this.elRichLabel1.Name = "elRichLabel1";
            this.elRichLabel1.Size = new System.Drawing.Size(229, 28);
            this.elRichLabel1.TabIndex = 2;
            this.elRichLabel1.Text = "Datos del Nuevo Concepto de Pago";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Vencimiento";
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
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(118, 44);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(271, 20);
            this.txtdescripcion.TabIndex = 6;
            this.txtdescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtdescripcion_Validating);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(118, 118);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(271, 20);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecio_Validating);
            // 
            // dtpfNacimiento
            // 
            this.dtpfNacimiento.Location = new System.Drawing.Point(118, 83);
            this.dtpfNacimiento.Name = "dtpfNacimiento";
            this.dtpfNacimiento.Size = new System.Drawing.Size(271, 20);
            this.dtpfNacimiento.TabIndex = 41;
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
            // elButton1
            // 
            this.elButton1.BackgroundImageStyle.Alpha = 100;
            this.elButton1.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.elButton1.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.elButton1.BorderStyle.EdgeRadius = 7;
            this.elButton1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.elButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.elButton1.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.elButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.Location = new System.Drawing.Point(31, 91);
            this.elButton1.Name = "elButton1";
            this.elButton1.Size = new System.Drawing.Size(96, 50);
            this.elButton1.TabIndex = 4;
            this.elButton1.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.elButton1.TextStyle.Text = "Salir";
            this.elButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // elRichLabel2
            // 
            this.elRichLabel2.Location = new System.Drawing.Point(31, 3);
            this.elRichLabel2.Name = "elRichLabel2";
            this.elRichLabel2.Size = new System.Drawing.Size(85, 28);
            this.elRichLabel2.TabIndex = 5;
            this.elRichLabel2.Text = "Operaciones";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // PopAddConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 193);
            this.Controls.Add(this.elPanel2);
            this.Controls.Add(this.elPanel1);
            this.DoubleBuffered = true;
            this.Name = "PopAddConcepto";
            this.Text = "Nuevo Concepto";
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).EndInit();
            this.elPanel1.ResumeLayout(false);
            this.elPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).EndInit();
            this.elPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elRichLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel2;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELRichLabel elRichLabel1;
        private System.Windows.Forms.DateTimePicker dtpfNacimiento;
        private Klik.Windows.Forms.v1.EntryLib.ELRichLabel elRichLabel2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnGuardar;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}