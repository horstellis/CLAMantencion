namespace MantencionCLA
{
    partial class frm_imprimir
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
            this.visor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mantencionDataSet = new MantencionCLA.mantencionDataSet();
            this.lista_usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_usuariosTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.lista_usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "lista_usuarios";
            reportDataSource1.Value = this.lista_usuariosBindingSource;
            this.visor.LocalReport.DataSources.Add(reportDataSource1);
            this.visor.LocalReport.ReportEmbeddedResource = "";
            this.visor.LocalReport.ReportPath = "";
            this.visor.Location = new System.Drawing.Point(0, 0);
            this.visor.Name = "visor";
            this.visor.ShowBackButton = false;
            this.visor.ShowCredentialPrompts = false;
            this.visor.Size = new System.Drawing.Size(643, 340);
            this.visor.TabIndex = 0;
            // 
            // mantencionDataSet
            // 
            this.mantencionDataSet.DataSetName = "mantencionDataSet";
            this.mantencionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lista_usuariosBindingSource
            // 
            this.lista_usuariosBindingSource.DataMember = "lista_usuarios";
            this.lista_usuariosBindingSource.DataSource = this.mantencionDataSet;
            // 
            // lista_usuariosTableAdapter
            // 
            this.lista_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 340);
            this.Controls.Add(this.visor);
            this.Name = "frm_imprimir";
            this.Text = "frm_imprimir";
            this.Load += new System.EventHandler(this.frm_imprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer visor;
        private System.Windows.Forms.BindingSource lista_usuariosBindingSource;
        private mantencionDataSet mantencionDataSet;
        private mantencionDataSetTableAdapters.lista_usuariosTableAdapter lista_usuariosTableAdapter;
    }
}