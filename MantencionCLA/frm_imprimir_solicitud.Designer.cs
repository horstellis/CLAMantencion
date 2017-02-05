namespace MantencionCLA
{
    partial class frm_imprimir_solicitud
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
            this.imprimir_solicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantencionDataSet = new MantencionCLA.mantencionDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.imprimir_solicitudTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.imprimir_solicitudTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir_solicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // imprimir_solicitudBindingSource
            // 
            this.imprimir_solicitudBindingSource.DataMember = "imprimir_solicitud";
            this.imprimir_solicitudBindingSource.DataSource = this.mantencionDataSet;
            // 
            // mantencionDataSet
            // 
            this.mantencionDataSet.DataSetName = "mantencionDataSet";
            this.mantencionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "imprimir_solicitud";
            reportDataSource1.Value = this.imprimir_solicitudBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MantencionCLA.Reportes.rpt_solicitud.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(784, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // imprimir_solicitudTableAdapter
            // 
            this.imprimir_solicitudTableAdapter.ClearBeforeFill = true;
            // 
            // frm_imprimir_solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_imprimir_solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_imprimir_solicitud";
            this.Load += new System.EventHandler(this.frm_imprimir_solicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imprimir_solicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource imprimir_solicitudBindingSource;
        private mantencionDataSet mantencionDataSet;
        private mantencionDataSetTableAdapters.imprimir_solicitudTableAdapter imprimir_solicitudTableAdapter;
    }
}