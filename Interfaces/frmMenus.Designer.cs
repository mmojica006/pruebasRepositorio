namespace Interfaces
{
    partial class frmMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenus));
            this.kFormManager1 = new Klik.Windows.Forms.v1.Common.KFormManager(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónMatriculasPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regitrarMatrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAlumnoMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kFormManager1
            // 
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.inscripciónMatriculasPagosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlumnoToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.alumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosToolStripMenuItem.Image")));
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // registrarAlumnoToolStripMenuItem
            // 
            this.registrarAlumnoToolStripMenuItem.Name = "registrarAlumnoToolStripMenuItem";
            this.registrarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarAlumnoToolStripMenuItem.Text = "Registrar Alumno";
            this.registrarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.registrarAlumnoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.imprimirToolStripMenuItem1});
            this.docentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("docentesToolStripMenuItem.Image")));
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.docentesToolStripMenuItem.Text = "Docentes";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nuevoToolStripMenuItem.Text = "Registrar Docente";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem1
            // 
            this.imprimirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem1.Image")));
            this.imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            this.imprimirToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.imprimirToolStripMenuItem1.Text = "Imprimir";
            // 
            // inscripciónMatriculasPagosToolStripMenuItem
            // 
            this.inscripciónMatriculasPagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regitrarMatrículaToolStripMenuItem,
            this.imprimirToolStripMenuItem2});
            this.inscripciónMatriculasPagosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inscripciónMatriculasPagosToolStripMenuItem.Image")));
            this.inscripciónMatriculasPagosToolStripMenuItem.Name = "inscripciónMatriculasPagosToolStripMenuItem";
            this.inscripciónMatriculasPagosToolStripMenuItem.Size = new System.Drawing.Size(188, 20);
            this.inscripciónMatriculasPagosToolStripMenuItem.Text = "Inscripción Matriculas-Pagos";
            // 
            // regitrarMatrículaToolStripMenuItem
            // 
            this.regitrarMatrículaToolStripMenuItem.Name = "regitrarMatrículaToolStripMenuItem";
            this.regitrarMatrículaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.regitrarMatrículaToolStripMenuItem.Text = "Registrar Matrícula";
            this.regitrarMatrículaToolStripMenuItem.Click += new System.EventHandler(this.regitrarMatrículaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem2
            // 
            this.imprimirToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem2.Image")));
            this.imprimirToolStripMenuItem2.Name = "imprimirToolStripMenuItem2";
            this.imprimirToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.imprimirToolStripMenuItem2.Text = "Imprimir";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDocentesToolStripMenuItem,
            this.reporteAlumnoToolStripMenuItem,
            this.reporteAlumnoMatriculasToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDocentesToolStripMenuItem
            // 
            this.reporteDocentesToolStripMenuItem.Name = "reporteDocentesToolStripMenuItem";
            this.reporteDocentesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reporteDocentesToolStripMenuItem.Text = "Reporte Docentes";
            // 
            // reporteAlumnoToolStripMenuItem
            // 
            this.reporteAlumnoToolStripMenuItem.Name = "reporteAlumnoToolStripMenuItem";
            this.reporteAlumnoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reporteAlumnoToolStripMenuItem.Text = "Reporte Alumno";
            // 
            // reporteAlumnoMatriculasToolStripMenuItem
            // 
            this.reporteAlumnoMatriculasToolStripMenuItem.Name = "reporteAlumnoMatriculasToolStripMenuItem";
            this.reporteAlumnoMatriculasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reporteAlumnoMatriculasToolStripMenuItem.Text = "Reporte Alumno Matriculas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "COLEGIO PRIMERA IGLESIA DE CRISTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenus";
            this.Text = "SISTEMA DE CONTROL DE PAGOS DE ALUMNOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Klik.Windows.Forms.v1.Common.KFormManager kFormManager1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inscripciónMatriculasPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regitrarMatrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAlumnoMatriculasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}