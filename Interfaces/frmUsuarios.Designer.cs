namespace Interfaces
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.elPanel2 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.elDataGridView1 = new Klik.Windows.Forms.v1.EntryLib.ELDataGridView();
            this.elPanel1 = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.btnSalir = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnuevo = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnGuardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnEliminar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnEditar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).BeginInit();
            this.elPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).BeginInit();
            this.elPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // elPanel2
            // 
            this.elPanel2.BackgroundStyle.GradientAngle = 45F;
            this.elPanel2.Controls.Add(this.label2);
            this.elPanel2.Controls.Add(this.elDataGridView1);
            this.elPanel2.Location = new System.Drawing.Point(25, 12);
            this.elPanel2.Name = "elPanel2";
            this.elPanel2.Size = new System.Drawing.Size(579, 312);
            this.elPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LISTA";
            // 
            // elDataGridView1
            // 
            this.elDataGridView1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elDataGridView1.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window;
            this.elDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.elDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.elDataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.elDataGridView1.Location = new System.Drawing.Point(27, 47);
            this.elDataGridView1.Name = "elDataGridView1";
            this.elDataGridView1.Size = new System.Drawing.Size(516, 215);
            this.elDataGridView1.TabIndex = 1;
            // 
            // elPanel1
            // 
            this.elPanel1.BackgroundStyle.GradientAngle = 45F;
            this.elPanel1.Controls.Add(this.btnSalir);
            this.elPanel1.Controls.Add(this.label1);
            this.elPanel1.Controls.Add(this.btnnuevo);
            this.elPanel1.Controls.Add(this.btnGuardar);
            this.elPanel1.Controls.Add(this.btnEliminar);
            this.elPanel1.Controls.Add(this.btnEditar);
            this.elPanel1.Location = new System.Drawing.Point(627, 12);
            this.elPanel1.Name = "elPanel1";
            this.elPanel1.Size = new System.Drawing.Size(152, 313);
            this.elPanel1.TabIndex = 4;
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
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageStyle.Alpha = 100;
            this.btnGuardar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnGuardar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.BorderStyle.EdgeRadius = 7;
            this.btnGuardar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnGuardar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnGuardar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(15, 192);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 50);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnGuardar.TextStyle.Text = "Actualizar";
            this.btnGuardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageStyle.Alpha = 100;
            this.btnEliminar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
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
            this.btnEditar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
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
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 350);
            this.Controls.Add(this.elPanel2);
            this.Controls.Add(this.elPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.elPanel2)).EndInit();
            this.elPanel2.ResumeLayout(false);
            this.elPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPanel1)).EndInit();
            this.elPanel1.ResumeLayout(false);
            this.elPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel2;
        private System.Windows.Forms.Label label2;
        private Klik.Windows.Forms.v1.EntryLib.ELDataGridView elDataGridView1;
        private Klik.Windows.Forms.v1.EntryLib.ELPanel elPanel1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnSalir;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnnuevo;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnGuardar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnEliminar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnEditar;
        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
    }
}