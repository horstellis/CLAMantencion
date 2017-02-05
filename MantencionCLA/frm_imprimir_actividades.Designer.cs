namespace MantencionCLA
{
    partial class frm_imprimir_actividades
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listar_actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantencionDataSet = new MantencionCLA.mantencionDataSet();
            this.listar_clasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listar_actividadesTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.listar_actividadesTableAdapter();
            this.listar_clasificacionTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.listar_clasificacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listar_actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listar_clasificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listar_actividadesBindingSource
            // 
            this.listar_actividadesBindingSource.DataMember = "listar_actividades";
            this.listar_actividadesBindingSource.DataSource = this.mantencionDataSet;
            // 
            // mantencionDataSet
            // 
            this.mantencionDataSet.DataSetName = "mantencionDataSet";
            this.mantencionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listar_clasificacionBindingSource
            // 
            this.listar_clasificacionBindingSource.DataMember = "listar_clasificacion";
            this.listar_clasificacionBindingSource.DataSource = this.mantencionDataSet;
            // 
            // reporte
            // 
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "listar_actividades";
            reportDataSource1.Value = this.listar_actividadesBindingSource;
            reportDataSource2.Name = "listar_clasificacion";
            reportDataSource2.Value = this.listar_clasificacionBindingSource;
            this.reporte.LocalReport.DataSources.Add(reportDataSource1);
            this.reporte.LocalReport.DataSources.Add(reportDataSource2);
            this.reporte.LocalReport.ReportEmbeddedResource = "MantencionCLA.Reportes.rpt_listar_actividades.rdlc";
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reporte";
            this.reporte.ShowBackButton = false;
            this.reporte.ShowDocumentMapButton = false;
            this.reporte.ShowProgress = false;
            this.reporte.ShowRefreshButton = false;
            this.reporte.ShowStopButton = false;
            this.reporte.Size = new System.Drawing.Size(984, 561);
            this.reporte.TabIndex = 0;
            this.reporte.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // listar_actividadesTableAdapter
            // 
            this.listar_actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // listar_clasificacionTableAdapter
            // 
            this.listar_clasificacionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_imprimir_actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.reporte);
            this.Name = "frm_imprimir_actividades";
            this.Text = "Reportes - Listar Actividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_imprimir_actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listar_actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listar_clasificacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte;
        private System.Windows.Forms.BindingSource listar_actividadesBindingSource;
        private mantencionDataSet mantencionDataSet;
        private System.Windows.Forms.BindingSource listar_clasificacionBindingSource;
        private mantencionDataSetTableAdapters.listar_actividadesTableAdapter listar_actividadesTableAdapter;
        private mantencionDataSetTableAdapters.listar_clasificacionTableAdapter listar_clasificacionTableAdapter;
    }
}