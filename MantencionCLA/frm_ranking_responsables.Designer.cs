namespace MantencionCLA
{
    partial class frm_ranking_responsables
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mantencionDataSet = new MantencionCLA.mantencionDataSet();
            this.ranking_responsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranking_responsablesTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.ranking_responsablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranking_responsablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ranking_responsables";
            reportDataSource2.Value = this.ranking_responsablesBindingSource;
            this.reporte.LocalReport.DataSources.Add(reportDataSource2);
            this.reporte.LocalReport.ReportEmbeddedResource = "MantencionCLA.Reportes.rpt_ranking.rdlc";
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reporte";
            this.reporte.ShowBackButton = false;
            this.reporte.ShowDocumentMapButton = false;
            this.reporte.ShowProgress = false;
            this.reporte.ShowRefreshButton = false;
            this.reporte.ShowStopButton = false;
            this.reporte.Size = new System.Drawing.Size(516, 307);
            this.reporte.TabIndex = 0;
            // 
            // mantencionDataSet
            // 
            this.mantencionDataSet.DataSetName = "mantencionDataSet";
            this.mantencionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ranking_responsablesBindingSource
            // 
            this.ranking_responsablesBindingSource.DataMember = "ranking_responsables";
            this.ranking_responsablesBindingSource.DataSource = this.mantencionDataSet;
            // 
            // ranking_responsablesTableAdapter
            // 
            this.ranking_responsablesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ranking_responsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 307);
            this.Controls.Add(this.reporte);
            this.Name = "frm_ranking_responsables";
            this.Text = "Reportes - Ranking Responsables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ranking_responsables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranking_responsablesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte;
        private System.Windows.Forms.BindingSource ranking_responsablesBindingSource;
        private mantencionDataSet mantencionDataSet;
        private mantencionDataSetTableAdapters.ranking_responsablesTableAdapter ranking_responsablesTableAdapter;
    }
}