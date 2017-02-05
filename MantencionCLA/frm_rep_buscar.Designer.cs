namespace MantencionCLA
{
    partial class frm_rep_buscar
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
            this.fra_seleccion = new System.Windows.Forms.GroupBox();
            this.opt_rep_ranking = new System.Windows.Forms.RadioButton();
            this.opt_rep_todas = new System.Windows.Forms.RadioButton();
            this.opt_rep_finalizadas = new System.Windows.Forms.RadioButton();
            this.opt_rep_pendientes = new System.Windows.Forms.RadioButton();
            this.fra_seccion = new System.Windows.Forms.GroupBox();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.opt_sec_una = new System.Windows.Forms.RadioButton();
            this.opt_sec_todas = new System.Windows.Forms.RadioButton();
            this.fra_fecha = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cmd_imprimir = new System.Windows.Forms.Button();
            this.fra_seleccion.SuspendLayout();
            this.fra_seccion.SuspendLayout();
            this.fra_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // fra_seleccion
            // 
            this.fra_seleccion.Controls.Add(this.opt_rep_ranking);
            this.fra_seleccion.Controls.Add(this.opt_rep_todas);
            this.fra_seleccion.Controls.Add(this.opt_rep_finalizadas);
            this.fra_seleccion.Controls.Add(this.opt_rep_pendientes);
            this.fra_seleccion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fra_seleccion.Location = new System.Drawing.Point(13, 12);
            this.fra_seleccion.Name = "fra_seleccion";
            this.fra_seleccion.Size = new System.Drawing.Size(297, 121);
            this.fra_seleccion.TabIndex = 0;
            this.fra_seleccion.TabStop = false;
            this.fra_seleccion.Text = "Elija el tipo de reporte";
            // 
            // opt_rep_ranking
            // 
            this.opt_rep_ranking.AutoSize = true;
            this.opt_rep_ranking.Location = new System.Drawing.Point(7, 98);
            this.opt_rep_ranking.Name = "opt_rep_ranking";
            this.opt_rep_ranking.Size = new System.Drawing.Size(141, 19);
            this.opt_rep_ranking.TabIndex = 2;
            this.opt_rep_ranking.TabStop = true;
            this.opt_rep_ranking.Text = "Ranking Responsables";
            this.tooltip.SetToolTip(this.opt_rep_ranking, "Muestra la cantidad de actividades atrasadas\r\npor Mecánico o Responsable");
            this.opt_rep_ranking.UseVisualStyleBackColor = true;
            this.opt_rep_ranking.CheckedChanged += new System.EventHandler(this.opt_rep_ranking_CheckedChanged);
            // 
            // opt_rep_todas
            // 
            this.opt_rep_todas.AutoSize = true;
            this.opt_rep_todas.Location = new System.Drawing.Point(7, 73);
            this.opt_rep_todas.Name = "opt_rep_todas";
            this.opt_rep_todas.Size = new System.Drawing.Size(135, 19);
            this.opt_rep_todas.TabIndex = 2;
            this.opt_rep_todas.TabStop = true;
            this.opt_rep_todas.Text = "Todas las Actividades";
            this.tooltip.SetToolTip(this.opt_rep_todas, "Muestra todas las actividades");
            this.opt_rep_todas.UseVisualStyleBackColor = true;
            this.opt_rep_todas.CheckedChanged += new System.EventHandler(this.opt_rep_todas_CheckedChanged);
            // 
            // opt_rep_finalizadas
            // 
            this.opt_rep_finalizadas.AutoSize = true;
            this.opt_rep_finalizadas.Location = new System.Drawing.Point(7, 48);
            this.opt_rep_finalizadas.Name = "opt_rep_finalizadas";
            this.opt_rep_finalizadas.Size = new System.Drawing.Size(145, 19);
            this.opt_rep_finalizadas.TabIndex = 1;
            this.opt_rep_finalizadas.TabStop = true;
            this.opt_rep_finalizadas.Text = "Actividades Finalizadas";
            this.tooltip.SetToolTip(this.opt_rep_finalizadas, "Muestra sólo actividades finalizadas");
            this.opt_rep_finalizadas.UseVisualStyleBackColor = true;
            this.opt_rep_finalizadas.CheckedChanged += new System.EventHandler(this.opt_rep_finalizadas_CheckedChanged);
            // 
            // opt_rep_pendientes
            // 
            this.opt_rep_pendientes.AutoSize = true;
            this.opt_rep_pendientes.Location = new System.Drawing.Point(7, 23);
            this.opt_rep_pendientes.Name = "opt_rep_pendientes";
            this.opt_rep_pendientes.Size = new System.Drawing.Size(146, 19);
            this.opt_rep_pendientes.TabIndex = 0;
            this.opt_rep_pendientes.TabStop = true;
            this.opt_rep_pendientes.Text = "Actividades Pendientes";
            this.tooltip.SetToolTip(this.opt_rep_pendientes, "Muestra sólo actividades pendientes");
            this.opt_rep_pendientes.UseVisualStyleBackColor = true;
            this.opt_rep_pendientes.CheckedChanged += new System.EventHandler(this.opt_rep_pendientes_CheckedChanged);
            // 
            // fra_seccion
            // 
            this.fra_seccion.Controls.Add(this.cmb_seccion);
            this.fra_seccion.Controls.Add(this.opt_sec_una);
            this.fra_seccion.Controls.Add(this.opt_sec_todas);
            this.fra_seccion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fra_seccion.Location = new System.Drawing.Point(13, 139);
            this.fra_seccion.Name = "fra_seccion";
            this.fra_seccion.Size = new System.Drawing.Size(297, 79);
            this.fra_seccion.TabIndex = 0;
            this.fra_seccion.TabStop = false;
            this.fra_seccion.Text = "Selección de Sección";
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seccion.Enabled = false;
            this.cmb_seccion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Location = new System.Drawing.Point(137, 45);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(154, 23);
            this.cmb_seccion.TabIndex = 4;
            // 
            // opt_sec_una
            // 
            this.opt_sec_una.AutoSize = true;
            this.opt_sec_una.Location = new System.Drawing.Point(7, 49);
            this.opt_sec_una.Name = "opt_sec_una";
            this.opt_sec_una.Size = new System.Drawing.Size(90, 19);
            this.opt_sec_una.TabIndex = 1;
            this.opt_sec_una.TabStop = true;
            this.opt_sec_una.Text = "Una Sección";
            this.opt_sec_una.UseVisualStyleBackColor = true;
            this.opt_sec_una.CheckedChanged += new System.EventHandler(this.opt_sec_una_CheckedChanged);
            // 
            // opt_sec_todas
            // 
            this.opt_sec_todas.AutoSize = true;
            this.opt_sec_todas.Location = new System.Drawing.Point(7, 23);
            this.opt_sec_todas.Name = "opt_sec_todas";
            this.opt_sec_todas.Size = new System.Drawing.Size(127, 19);
            this.opt_sec_todas.TabIndex = 0;
            this.opt_sec_todas.TabStop = true;
            this.opt_sec_todas.Text = "Todas las Secciones";
            this.opt_sec_todas.UseVisualStyleBackColor = true;
            // 
            // fra_fecha
            // 
            this.fra_fecha.Controls.Add(this.dtp_fecha);
            this.fra_fecha.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fra_fecha.Location = new System.Drawing.Point(12, 224);
            this.fra_fecha.Name = "fra_fecha";
            this.fra_fecha.Size = new System.Drawing.Size(297, 56);
            this.fra_fecha.TabIndex = 5;
            this.fra_fecha.TabStop = false;
            this.fra_fecha.Text = "Selección de Fecha Filtrado";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(7, 23);
            this.dtp_fecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(284, 23);
            this.dtp_fecha.TabIndex = 0;
            this.dtp_fecha.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // cmd_imprimir
            // 
            this.cmd_imprimir.FlatAppearance.BorderSize = 0;
            this.cmd_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_imprimir.Image = global::MantencionCLA.Properties.Resources._48px_Gnome_document_print_svg;
            this.cmd_imprimir.Location = new System.Drawing.Point(316, 12);
            this.cmd_imprimir.Name = "cmd_imprimir";
            this.cmd_imprimir.Size = new System.Drawing.Size(50, 50);
            this.cmd_imprimir.TabIndex = 28;
            this.cmd_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_imprimir.UseVisualStyleBackColor = true;
            this.cmd_imprimir.Click += new System.EventHandler(this.cmd_imprimir_Click);
            // 
            // frm_rep_buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(373, 288);
            this.Controls.Add(this.fra_fecha);
            this.Controls.Add(this.cmd_imprimir);
            this.Controls.Add(this.fra_seccion);
            this.Controls.Add(this.fra_seleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_rep_buscar";
            this.Text = "Reportes - Buscar Actividades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_rep_buscar_FormClosing);
            this.Load += new System.EventHandler(this.frm_rep_buscar_Load);
            this.fra_seleccion.ResumeLayout(false);
            this.fra_seleccion.PerformLayout();
            this.fra_seccion.ResumeLayout(false);
            this.fra_seccion.PerformLayout();
            this.fra_fecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fra_seleccion;
        private System.Windows.Forms.RadioButton opt_rep_todas;
        private System.Windows.Forms.RadioButton opt_rep_finalizadas;
        private System.Windows.Forms.RadioButton opt_rep_pendientes;
        private System.Windows.Forms.GroupBox fra_seccion;
        private System.Windows.Forms.RadioButton opt_sec_una;
        private System.Windows.Forms.RadioButton opt_sec_todas;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.Button cmd_imprimir;
        private System.Windows.Forms.RadioButton opt_rep_ranking;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.GroupBox fra_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}