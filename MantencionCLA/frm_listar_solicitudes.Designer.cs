namespace MantencionCLA
{
    partial class frm_listar_solicitudes
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
            this.listar_solcitudesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantencionDataSet = new MantencionCLA.mantencionDataSet();
            this.cmd_lista = new System.Windows.Forms.Button();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.cmb_solicitante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listar_solcitudesTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.listar_solcitudesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listar_solcitudesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listar_solcitudesBindingSource
            // 
            this.listar_solcitudesBindingSource.DataMember = "listar_solcitudes";
            this.listar_solcitudesBindingSource.DataSource = this.mantencionDataSet;
            // 
            // mantencionDataSet
            // 
            this.mantencionDataSet.DataSetName = "mantencionDataSet";
            this.mantencionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmd_lista
            // 
            this.cmd_lista.FlatAppearance.BorderSize = 0;
            this.cmd_lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_lista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_lista.Image = global::MantencionCLA.Properties.Resources.Gnome_edit_find;
            this.cmd_lista.Location = new System.Drawing.Point(634, 7);
            this.cmd_lista.Name = "cmd_lista";
            this.cmd_lista.Size = new System.Drawing.Size(50, 50);
            this.cmd_lista.TabIndex = 16;
            this.cmd_lista.UseVisualStyleBackColor = true;
            this.cmd_lista.Click += new System.EventHandler(this.cmd_lista_Click);
            // 
            // dtp_desde
            // 
            this.dtp_desde.CustomFormat = " ";
            this.dtp_desde.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(120, 51);
            this.dtp_desde.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_desde.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(105, 23);
            this.dtp_desde.TabIndex = 48;
            this.dtp_desde.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            // 
            // cmb_solicitante
            // 
            this.cmb_solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_solicitante.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_solicitante.FormattingEnabled = true;
            this.cmb_solicitante.Location = new System.Drawing.Point(123, 7);
            this.cmb_solicitante.Name = "cmb_solicitante";
            this.cmb_solicitante.Size = new System.Drawing.Size(505, 23);
            this.cmb_solicitante.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Rango de Fechas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre Solicitante";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Desde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Hasta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.CustomFormat = " ";
            this.dtp_hasta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(523, 51);
            this.dtp_hasta.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_hasta.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(105, 23);
            this.dtp_hasta.TabIndex = 48;
            this.dtp_hasta.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "listar_solicitudes";
            reportDataSource1.Value = this.listar_solcitudesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MantencionCLA.Reportes.rpt_listar_solicitudes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(616, 349);
            this.reportViewer1.TabIndex = 49;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // listar_solcitudesTableAdapter
            // 
            this.listar_solcitudesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_listar_solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtp_hasta);
            this.Controls.Add(this.dtp_desde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_solicitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listar_solicitudes";
            this.Text = "Buscar Reportes - Solicitudes por Solicitante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_listar_solicitudes_FormClosing);
            this.Load += new System.EventHandler(this.frm_listar_solicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listar_solcitudesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_lista;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.ComboBox cmb_solicitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listar_solcitudesBindingSource;
        private mantencionDataSet mantencionDataSet;
        private mantencionDataSetTableAdapters.listar_solcitudesTableAdapter listar_solcitudesTableAdapter;
    }
}