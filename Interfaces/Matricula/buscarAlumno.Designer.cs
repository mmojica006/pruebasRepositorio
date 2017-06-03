namespace Interfaces.Matricula
{
    partial class buscarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.dgvAlumno = new Klik.Windows.Forms.v1.EntryLib.ELDataGridView();
            this.btnCancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnAceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageStyle.Alpha = 100;
            this.btnBuscar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBuscar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.BorderStyle.EdgeRadius = 7;
            this.btnBuscar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnBuscar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnBuscar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnBuscar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(508, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 37);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnBuscar.TextStyle.Text = "Buscar";
            this.btnBuscar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(12, 20);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(414, 20);
            this.txtAlumno.TabIndex = 11;
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.dgvAlumno.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumno.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumno.GridColor = System.Drawing.Color.LightGray;
            this.dgvAlumno.Location = new System.Drawing.Point(12, 55);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.Size = new System.Drawing.Size(565, 150);
            this.dgvAlumno.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageStyle.Alpha = 100;
            this.btnCancelar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnCancelar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.BorderStyle.EdgeRadius = 7;
            this.btnCancelar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnCancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnCancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnCancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(285, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 50);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnCancelar.TextStyle.Text = "Cancelar";
            this.btnCancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageStyle.Alpha = 100;
            this.btnAceptar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnAceptar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.BorderStyle.EdgeRadius = 7;
            this.btnAceptar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnAceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnAceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnAceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Location = new System.Drawing.Point(183, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 50);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnAceptar.TextStyle.Text = "Aceptar";
            this.btnAceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // buscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 261);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.DoubleBuffered = true;
            this.Name = "buscarAlumno";
            this.Text = "Búsqueda de Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELButton btnBuscar;
        private System.Windows.Forms.TextBox txtAlumno;
        private Klik.Windows.Forms.v1.EntryLib.ELDataGridView dgvAlumno;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnCancelar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnAceptar;
        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
    }
}