namespace Interfaces.nivel
{
    partial class buscarMaestro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarMaestro));
            this.txtPopalumno = new System.Windows.Forms.TextBox();
            this.dgvEmpleado = new Klik.Windows.Forms.v1.EntryLib.ELDataGridView();
            this.btnCancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnAceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPopalumno
            // 
            this.txtPopalumno.Location = new System.Drawing.Point(12, 20);
            this.txtPopalumno.Name = "txtPopalumno";
            this.txtPopalumno.Size = new System.Drawing.Size(414, 20);
            this.txtPopalumno.TabIndex = 11;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.dgvEmpleado.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleado.GridColor = System.Drawing.Color.LightGray;
            this.dgvEmpleado.Location = new System.Drawing.Point(12, 63);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(414, 150);
            this.dgvEmpleado.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageStyle.Alpha = 100;
            this.btnCancelar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnCancelar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.BorderStyle.EdgeRadius = 7;
            this.btnCancelar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnCancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnCancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnCancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(465, 136);
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
            this.btnAceptar.BackgroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnAceptar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.BorderStyle.EdgeRadius = 7;
            this.btnAceptar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnAceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnAceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnAceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Location = new System.Drawing.Point(471, 80);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 50);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btnAceptar.TextStyle.Text = "Aceptar";
            this.btnAceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Presiona la tecla ENTER para realizar la búsqueda";
            // 
            // buscarMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPopalumno);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "buscarMaestro";
            this.Text = "Buscar Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPopalumno;
        private Klik.Windows.Forms.v1.EntryLib.ELDataGridView dgvEmpleado;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnCancelar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnAceptar;
        private System.Windows.Forms.Label label1;
    }
}