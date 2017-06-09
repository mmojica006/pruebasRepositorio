namespace Interfaces.Pagos
{
    partial class frmPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.elPanel1 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.elPanel2 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.gvPagos = new Klik.Windows.Forms.v1.EntryLib.ELDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnAgregar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnQuitar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnLimpiar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.IdConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elPanel3 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.btnSalir = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnnuevo = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnImprimir = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnGuardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).BeginInit();
            this.elPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).BeginInit();
            this.elPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel3)).BeginInit();
            this.elPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
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
            this.elPanel1.Controls.Add(this.txtHora);
            this.elPanel1.Controls.Add(this.txtFecha);
            this.elPanel1.Controls.Add(this.btnBuscar);
            this.elPanel1.Controls.Add(this.label3);
            this.elPanel1.Controls.Add(this.label2);
            this.elPanel1.Controls.Add(this.txtAlumno);
            this.elPanel1.Controls.Add(this.label1);
            this.elPanel1.Location = new System.Drawing.Point(12, 30);
            this.elPanel1.Name = "elPanel1";
            this.elPanel1.Size = new System.Drawing.Size(537, 79);
            this.elPanel1.TabIndex = 1;
            // 
            // elPanel2
            // 
            this.elPanel2.BackgroundStyle.GradientAngle = 45F;
            this.elPanel2.Controls.Add(this.btnLimpiar);
            this.elPanel2.Controls.Add(this.btnQuitar);
            this.elPanel2.Controls.Add(this.btnAgregar);
            this.elPanel2.Location = new System.Drawing.Point(12, 115);
            this.elPanel2.Name = "elPanel2";
            this.elPanel2.Size = new System.Drawing.Size(537, 52);
            this.elPanel2.TabIndex = 2;
            // 
            // gvPagos
            // 
            this.gvPagos.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.gvPagos.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window;
            this.gvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConcepto,
            this.Concepto,
            this.Importe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvPagos.GridColor = System.Drawing.Color.LightGray;
            this.gvPagos.Location = new System.Drawing.Point(12, 173);
            this.gvPagos.Name = "gvPagos";
            this.gvPagos.Size = new System.Drawing.Size(537, 150);
            this.gvPagos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(15, 46);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(250, 20);
            this.txtAlumno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(346, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(474, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(271, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(317, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(423, 46);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnAgregar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnAgregar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(15, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.TextStyle.Text = "Agregar";
            this.btnAgregar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnQuitar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnQuitar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitar.Location = new System.Drawing.Point(121, 13);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.TextStyle.Text = "Quitar";
            this.btnQuitar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnLimpiar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnLimpiar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(237, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.TextStyle.Text = "Limpiar";
            this.btnLimpiar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdConcepto
            // 
            this.IdConcepto.HeaderText = "IdConcepto";
            this.IdConcepto.Name = "IdConcepto";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // elPanel3
            // 
            this.elPanel3.BackgroundStyle.GradientAngle = 45F;
            this.elPanel3.Controls.Add(this.btnSalir);
            this.elPanel3.Controls.Add(this.label4);
            this.elPanel3.Controls.Add(this.btnnuevo);
            this.elPanel3.Controls.Add(this.btnImprimir);
            this.elPanel3.Controls.Add(this.btnGuardar);
            this.elPanel3.Location = new System.Drawing.Point(555, 30);
            this.elPanel3.Name = "elPanel3";
            this.elPanel3.Size = new System.Drawing.Size(152, 294);
            this.elPanel3.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageStyle.Alpha = 100;
            this.btnSalir.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSalir.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.BorderStyle.EdgeRadius = 7;
            this.btnSalir.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnSalir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnSalir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnSalir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Location = new System.Drawing.Point(15, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 50);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnSalir.TextStyle.Text = "Salir";
            this.btnSalir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "OPERACIONES";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImageStyle.Alpha = 100;
            this.btnnuevo.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnnuevo.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.BorderStyle.EdgeRadius = 7;
            this.btnnuevo.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnnuevo.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnnuevo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnnuevo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnnuevo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnuevo.Location = new System.Drawing.Point(15, 24);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(120, 50);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnnuevo.TextStyle.Text = "Nuevo";
            this.btnnuevo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImageStyle.Alpha = 100;
            this.btnImprimir.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnImprimir.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.BorderStyle.EdgeRadius = 7;
            this.btnImprimir.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimir.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnImprimir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnImprimir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnImprimir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.Location = new System.Drawing.Point(15, 164);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 50);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnImprimir.TextStyle.Text = "Imprimir";
            this.btnImprimir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageStyle.Alpha = 100;
            this.btnGuardar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnGuardar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.BorderStyle.EdgeRadius = 7;
            this.btnGuardar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnGuardar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnGuardar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(15, 98);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 50);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.TextStyle.Text = "Guardar";
            this.btnGuardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(419, 329);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(344, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL";
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.elPanel3);
            this.Controls.Add(this.gvPagos);
            this.Controls.Add(this.elPanel2);
            this.Controls.Add(this.elPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmPagos";
            this.Text = "Registro de Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).EndInit();
            this.elPanel1.ResumeLayout(false);
            this.elPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).EndInit();
            this.elPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel3)).EndInit();
            this.elPanel3.ResumeLayout(false);
            this.elPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel1;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel2;
        private Klik.Windows.Forms.v1.EntryLib.ELDataGridView gvPagos;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnLimpiar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnQuitar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel3;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnSalir;
        private System.Windows.Forms.Label label4;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnnuevo;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnImprimir;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
    }
}