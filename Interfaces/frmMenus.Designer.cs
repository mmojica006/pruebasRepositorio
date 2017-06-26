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
            this.conceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónMatriculasPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regitrarMatrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kFormManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kFormManager1
            // 
            this.kFormManager1.BackgroundImageStyle.Alpha = 100;
            this.kFormManager1.BackgroundImageStyle.ImageEffect = Klik.Windows.Forms.v1.Common.ImageEffect.Mirror;
            this.kFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.kFormManager1.MainContainer = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.inscripciónMatriculasPagosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
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
            this.conceptosToolStripMenuItem,
            this.nivelesToolStripMenuItem1,
            this.colaboradoresToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosToolStripMenuItem.Image")));
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.alumnosToolStripMenuItem.Text = "Registros";
            // 
            // registrarAlumnoToolStripMenuItem
            // 
            this.registrarAlumnoToolStripMenuItem.Name = "registrarAlumnoToolStripMenuItem";
            this.registrarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarAlumnoToolStripMenuItem.Text = "Registrar Alumno";
            this.registrarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.registrarAlumnoToolStripMenuItem_Click);
            // 
            // conceptosToolStripMenuItem
            // 
            this.conceptosToolStripMenuItem.Name = "conceptosToolStripMenuItem";
            this.conceptosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.conceptosToolStripMenuItem.Text = "Conceptos";
            this.conceptosToolStripMenuItem.Click += new System.EventHandler(this.conceptosToolStripMenuItem_Click);
            // 
            // nivelesToolStripMenuItem1
            // 
            this.nivelesToolStripMenuItem1.Name = "nivelesToolStripMenuItem1";
            this.nivelesToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.nivelesToolStripMenuItem1.Text = "Niveles";
            this.nivelesToolStripMenuItem1.Click += new System.EventHandler(this.nivelesToolStripMenuItem1_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.docentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("docentesToolStripMenuItem.Image")));
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.docentesToolStripMenuItem.Text = "Matriculas";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nuevoToolStripMenuItem.Text = "Lista de Matriculas";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoDeMatriculasToolStripMenuItem});
            this.pagosToolStripMenuItem.Image = global::Interfaces.Properties.Resources.ic_attach_money_128_28210;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // pagoDeMatriculasToolStripMenuItem
            // 
            this.pagoDeMatriculasToolStripMenuItem.Name = "pagoDeMatriculasToolStripMenuItem";
            this.pagoDeMatriculasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pagoDeMatriculasToolStripMenuItem.Text = "Pago de Matriculas";
            this.pagoDeMatriculasToolStripMenuItem.Click += new System.EventHandler(this.pagoDeMatriculasToolStripMenuItem_Click);
            // 
            // inscripciónMatriculasPagosToolStripMenuItem
            // 
            this.inscripciónMatriculasPagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regitrarMatrículaToolStripMenuItem});
            this.inscripciónMatriculasPagosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inscripciónMatriculasPagosToolStripMenuItem.Image")));
            this.inscripciónMatriculasPagosToolStripMenuItem.Name = "inscripciónMatriculasPagosToolStripMenuItem";
            this.inscripciónMatriculasPagosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.inscripciónMatriculasPagosToolStripMenuItem.Text = "Consultas";
            // 
            // regitrarMatrículaToolStripMenuItem
            // 
            this.regitrarMatrículaToolStripMenuItem.Name = "regitrarMatrículaToolStripMenuItem";
            this.regitrarMatrículaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.regitrarMatrículaToolStripMenuItem.Text = "Consulta de Pagos";
            this.regitrarMatrículaToolStripMenuItem.Click += new System.EventHandler(this.regitrarMatrículaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.acercaToolStripMenuItem.Text = "Acerca";
            // 
            // frmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 350);
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
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónMatriculasPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regitrarMatrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDeMatriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelesToolStripMenuItem1;
    }
}