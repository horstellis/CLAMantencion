namespace MantencionCLA
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mecánicosOResponsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificaciónDeMantenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.actividadesEliminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foliosUsadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.ingresoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ventanasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seccionesToolStripMenuItem,
            this.lineasToolStripMenuItem,
            this.máquinasToolStripMenuItem,
            this.solicitantesToolStripMenuItem,
            this.mecánicosOResponsablesToolStripMenuItem,
            this.clasificaciónDeMantenciónToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "&Mantenedores";
            // 
            // seccionesToolStripMenuItem
            // 
            this.seccionesToolStripMenuItem.Name = "seccionesToolStripMenuItem";
            this.seccionesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.seccionesToolStripMenuItem.Text = "Secciones";
            // 
            // lineasToolStripMenuItem
            // 
            this.lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            this.lineasToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.lineasToolStripMenuItem.Text = "Lineas";
            // 
            // máquinasToolStripMenuItem
            // 
            this.máquinasToolStripMenuItem.Name = "máquinasToolStripMenuItem";
            this.máquinasToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.máquinasToolStripMenuItem.Text = "Máquinas";
            // 
            // mecánicosOResponsablesToolStripMenuItem
            // 
            this.mecánicosOResponsablesToolStripMenuItem.Name = "mecánicosOResponsablesToolStripMenuItem";
            this.mecánicosOResponsablesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.mecánicosOResponsablesToolStripMenuItem.Text = "Mecánicos o Responsables";
            // 
            // clasificaciónDeMantenciónToolStripMenuItem
            // 
            this.clasificaciónDeMantenciónToolStripMenuItem.Name = "clasificaciónDeMantenciónToolStripMenuItem";
            this.clasificaciónDeMantenciónToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.clasificaciónDeMantenciónToolStripMenuItem.Text = "Clasificación de Mantención";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadesToolStripMenuItem,
            this.mantenciónToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ingresoToolStripMenuItem.Text = "&Ingreso";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // mantenciónToolStripMenuItem
            // 
            this.mantenciónToolStripMenuItem.Name = "mantenciónToolStripMenuItem";
            this.mantenciónToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mantenciónToolStripMenuItem.Text = "Mantención";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem,
            this.buscarReporteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.actividadesEliminadasToolStripMenuItem,
            this.foliosUsadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte";
            // 
            // buscarReporteToolStripMenuItem
            // 
            this.buscarReporteToolStripMenuItem.Name = "buscarReporteToolStripMenuItem";
            this.buscarReporteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.buscarReporteToolStripMenuItem.Text = "Buscar Reporte";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // actividadesEliminadasToolStripMenuItem
            // 
            this.actividadesEliminadasToolStripMenuItem.Name = "actividadesEliminadasToolStripMenuItem";
            this.actividadesEliminadasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.actividadesEliminadasToolStripMenuItem.Text = "Actividades eliminadas";
            // 
            // foliosUsadosToolStripMenuItem
            // 
            this.foliosUsadosToolStripMenuItem.Name = "foliosUsadosToolStripMenuItem";
            this.foliosUsadosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.foliosUsadosToolStripMenuItem.Text = "Folios Usados";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ventanasToolStripMenuItem.Text = "&Ventanas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // solicitantesToolStripMenuItem
            // 
            this.solicitantesToolStripMenuItem.Name = "solicitantesToolStripMenuItem";
            this.solicitantesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.solicitantesToolStripMenuItem.Text = "Solicitantes";
            this.solicitantesToolStripMenuItem.Click += new System.EventHandler(this.solicitantesToolStripMenuItem_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 367);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.Text = "Programa de Mantenimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecánicosOResponsablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificaciónDeMantenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actividadesEliminadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foliosUsadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitantesToolStripMenuItem;
    }
}

