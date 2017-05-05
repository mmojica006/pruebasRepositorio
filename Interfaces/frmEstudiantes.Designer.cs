namespace Interfaces
{
    partial class frmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.kStyleManager1 = new Klik.Windows.Forms.v1.Common.KStyleManager(this.components);
            this.elPanel2 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnPopBuscar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gvEstudiante = new Klik.Windows.Forms.v1.EntryLib.ELDataGridView();
            this.elPanel1 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.btnSalir = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnuevo = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnActualizar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnEliminar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnEditar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).BeginInit();
            this.elPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPopBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).BeginInit();
            this.elPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // elPanel2
            // 
            this.elPanel2.BackgroundStyle.GradientAngle = 45F;
            this.elPanel2.Controls.Add(this.txtbuscar);
            this.elPanel2.Controls.Add(this.btnPopBuscar);
            this.elPanel2.Controls.Add(this.label2);
            this.elPanel2.Controls.Add(this.gvEstudiante);
            this.elPanel2.Location = new System.Drawing.Point(12, 18);
            this.elPanel2.Name = "elPanel2";
            this.elPanel2.Size = new System.Drawing.Size(579, 312);
            this.elPanel2.TabIndex = 5;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(27, 41);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(441, 20);
            this.txtbuscar.TabIndex = 9;
            // 
            // btnPopBuscar
            // 
            this.btnPopBuscar.BackgroundImageStyle.Alpha = 100;
            this.btnPopBuscar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnPopBuscar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopBuscar.BorderStyle.EdgeRadius = 7;
            this.btnPopBuscar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnPopBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPopBuscar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnPopBuscar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnPopBuscar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnPopBuscar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPopBuscar.Location = new System.Drawing.Point(474, 24);
            this.btnPopBuscar.Name = "btnPopBuscar";
            this.btnPopBuscar.Size = new System.Drawing.Size(69, 37);
            this.btnPopBuscar.TabIndex = 8;
            this.btnPopBuscar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnPopBuscar.TextStyle.Text = "Buscar";
            this.btnPopBuscar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ALUMNOS";
            // 
            // gvEstudiante
            // 
            this.gvEstudiante.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.gvEstudiante.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window;
            this.gvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvEstudiante.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvEstudiante.GridColor = System.Drawing.Color.LightGray;
            this.gvEstudiante.Location = new System.Drawing.Point(27, 80);
            this.gvEstudiante.Name = "gvEstudiante";
            this.gvEstudiante.Size = new System.Drawing.Size(549, 215);
            this.gvEstudiante.TabIndex = 1;
            // 
            // elPanel1
            // 
            this.elPanel1.BackgroundStyle.GradientAngle = 45F;
            this.elPanel1.Controls.Add(this.btnSalir);
            this.elPanel1.Controls.Add(this.label1);
            this.elPanel1.Controls.Add(this.btnnuevo);
            this.elPanel1.Controls.Add(this.btnActualizar);
            this.elPanel1.Controls.Add(this.btnEliminar);
            this.elPanel1.Controls.Add(this.btnEditar);
            this.elPanel1.Location = new System.Drawing.Point(614, 18);
            this.elPanel1.Name = "elPanel1";
            this.elPanel1.Size = new System.Drawing.Size(152, 313);
            this.elPanel1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageStyle.Alpha = 100;
            this.btnSalir.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnSalir.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.BorderStyle.EdgeRadius = 7;
            this.btnSalir.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnSalir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnSalir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnSalir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Location = new System.Drawing.Point(15, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 50);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnSalir.TextStyle.Text = "Salir";
            this.btnSalir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPERACIONES";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImageStyle.Alpha = 100;
            this.btnnuevo.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageStyle.Alpha = 100;
            this.btnActualizar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnActualizar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.BorderStyle.EdgeRadius = 7;
            this.btnActualizar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnActualizar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnActualizar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnActualizar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.Location = new System.Drawing.Point(15, 192);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 50);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnActualizar.TextStyle.Text = "Actualizar";
            this.btnActualizar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageStyle.Alpha = 100;
            this.btnEliminar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnEliminar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.BorderStyle.EdgeRadius = 7;
            this.btnEliminar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnEliminar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnEliminar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnEliminar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Location = new System.Drawing.Point(15, 136);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 50);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnEliminar.TextStyle.Text = "Eliminar";
            this.btnEliminar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageStyle.Alpha = 100;
            this.btnEditar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnEditar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.BorderStyle.EdgeRadius = 7;
            this.btnEditar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnEditar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnEditar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnEditar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Location = new System.Drawing.Point(15, 80);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 50);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnEditar.TextStyle.Text = "Modificar";
            this.btnEditar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 342);
            this.Controls.Add(this.elPanel2);
            this.Controls.Add(this.elPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmEstudiantes";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).EndInit();
            this.elPanel2.ResumeLayout(false);
            this.elPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPopBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).EndInit();
            this.elPanel1.ResumeLayout(false);
            this.elPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private Klik.Windows.Forms.v1.Common.KStyleManager kStyleManager1;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel2;
        private System.Windows.Forms.Label label2;
        private Klik.Windows.Forms.v1.EntryLib.ELDataGridView gvEstudiante;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnSalir;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnnuevo;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnActualizar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnEliminar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnEditar;
        private System.Windows.Forms.TextBox txtbuscar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnPopBuscar;
    }
}