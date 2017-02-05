namespace MantencionCLA
{
    partial class frm_especial1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_eliminado = new System.Windows.Forms.RadioButton();
            this.opt_finalizado = new System.Windows.Forms.RadioButton();
            this.opt_pendiente = new System.Windows.Forms.RadioButton();
            this.dat_especial = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mantencion = new System.Windows.Forms.TextBox();
            this.txt_solicitud = new System.Windows.Forms.TextBox();
            this.cmb_solicitante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_lista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_especial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_eliminado);
            this.groupBox1.Controls.Add(this.opt_finalizado);
            this.groupBox1.Controls.Add(this.opt_pendiente);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(301, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Actividad";
            // 
            // opt_eliminado
            // 
            this.opt_eliminado.AutoSize = true;
            this.opt_eliminado.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_eliminado.Location = new System.Drawing.Point(6, 69);
            this.opt_eliminado.Name = "opt_eliminado";
            this.opt_eliminado.Size = new System.Drawing.Size(85, 19);
            this.opt_eliminado.TabIndex = 1;
            this.opt_eliminado.TabStop = true;
            this.opt_eliminado.Text = "ELIMINADO";
            this.opt_eliminado.UseVisualStyleBackColor = true;
            // 
            // opt_finalizado
            // 
            this.opt_finalizado.AutoSize = true;
            this.opt_finalizado.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_finalizado.Location = new System.Drawing.Point(6, 46);
            this.opt_finalizado.Name = "opt_finalizado";
            this.opt_finalizado.Size = new System.Drawing.Size(78, 19);
            this.opt_finalizado.TabIndex = 1;
            this.opt_finalizado.TabStop = true;
            this.opt_finalizado.Text = "Finalizado";
            this.opt_finalizado.UseVisualStyleBackColor = true;
            // 
            // opt_pendiente
            // 
            this.opt_pendiente.AutoSize = true;
            this.opt_pendiente.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_pendiente.Location = new System.Drawing.Point(6, 23);
            this.opt_pendiente.Name = "opt_pendiente";
            this.opt_pendiente.Size = new System.Drawing.Size(78, 19);
            this.opt_pendiente.TabIndex = 0;
            this.opt_pendiente.TabStop = true;
            this.opt_pendiente.Text = "Pendiente";
            this.opt_pendiente.UseVisualStyleBackColor = true;
            // 
            // dat_especial
            // 
            this.dat_especial.AllowUserToAddRows = false;
            this.dat_especial.AllowUserToDeleteRows = false;
            this.dat_especial.AllowUserToResizeColumns = false;
            this.dat_especial.AllowUserToResizeRows = false;
            this.dat_especial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_especial.BackgroundColor = System.Drawing.Color.Snow;
            this.dat_especial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_especial.GridColor = System.Drawing.Color.Snow;
            this.dat_especial.Location = new System.Drawing.Point(15, 114);
            this.dat_especial.Name = "dat_especial";
            this.dat_especial.ReadOnly = true;
            this.dat_especial.RowHeadersVisible = false;
            this.dat_especial.Size = new System.Drawing.Size(439, 138);
            this.dat_especial.TabIndex = 19;
            this.dat_especial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_especial_CellClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(209, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "N° Mantención";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "N° de Solicitud";
            // 
            // txt_mantencion
            // 
            this.txt_mantencion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mantencion.Location = new System.Drawing.Point(213, 27);
            this.txt_mantencion.MaxLength = 5;
            this.txt_mantencion.Name = "txt_mantencion";
            this.txt_mantencion.Size = new System.Drawing.Size(82, 23);
            this.txt_mantencion.TabIndex = 20;
            // 
            // txt_solicitud
            // 
            this.txt_solicitud.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_solicitud.Location = new System.Drawing.Point(123, 27);
            this.txt_solicitud.MaxLength = 5;
            this.txt_solicitud.Name = "txt_solicitud";
            this.txt_solicitud.Size = new System.Drawing.Size(82, 23);
            this.txt_solicitud.TabIndex = 21;
            // 
            // cmb_solicitante
            // 
            this.cmb_solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_solicitante.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_solicitante.FormattingEnabled = true;
            this.cmb_solicitante.Location = new System.Drawing.Point(123, 56);
            this.cmb_solicitante.Name = "cmb_solicitante";
            this.cmb_solicitante.Size = new System.Drawing.Size(172, 23);
            this.cmb_solicitante.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre Solicitante";
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seccion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Location = new System.Drawing.Point(123, 85);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(172, 23);
            this.cmb_seccion.TabIndex = 27;
            this.cmb_seccion.DropDownClosed += new System.EventHandler(this.cmb_seccion_DropDownClosed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sección";
            // 
            // cmd_insertar
            // 
            this.cmd_insertar.FlatAppearance.BorderSize = 0;
            this.cmd_insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_insertar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_insertar.Image = global::MantencionCLA.Properties.Resources.Gnome_Media_Floppy_48px;
            this.cmd_insertar.Location = new System.Drawing.Point(463, 11);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(60, 60);
            this.cmd_insertar.TabIndex = 17;
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_lista
            // 
            this.cmd_lista.FlatAppearance.BorderSize = 0;
            this.cmd_lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_lista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_lista.Image = global::MantencionCLA.Properties.Resources.Gnome_edit_find;
            this.cmd_lista.Location = new System.Drawing.Point(463, 77);
            this.cmd_lista.Name = "cmd_lista";
            this.cmd_lista.Size = new System.Drawing.Size(60, 60);
            this.cmd_lista.TabIndex = 16;
            this.cmd_lista.UseVisualStyleBackColor = true;
            this.cmd_lista.Click += new System.EventHandler(this.cmd_lista_Click);
            // 
            // frm_especial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(536, 266);
            this.Controls.Add(this.cmb_seccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_solicitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mantencion);
            this.Controls.Add(this.txt_solicitud);
            this.Controls.Add(this.dat_especial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_especial1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activación de Actividades Eliminadas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_especial1_FormClosing);
            this.Load += new System.EventHandler(this.frm_especial1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_especial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_lista;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_eliminado;
        private System.Windows.Forms.RadioButton opt_finalizado;
        private System.Windows.Forms.RadioButton opt_pendiente;
        private System.Windows.Forms.DataGridView dat_especial;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mantencion;
        private System.Windows.Forms.TextBox txt_solicitud;
        private System.Windows.Forms.ComboBox cmb_solicitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.Label label4;
    }
}