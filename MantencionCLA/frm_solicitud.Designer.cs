namespace MantencionCLA
{
    partial class frm_solicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_solicitud));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fsolicitud = new System.Windows.Forms.TextBox();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_solicitante = new System.Windows.Forms.ComboBox();
            this.dat_solicitud = new System.Windows.Forms.DataGridView();
            this.cmd_lista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_solicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "# Folio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha Solicitud";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_fsolicitud
            // 
            this.txt_fsolicitud.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fsolicitud.Location = new System.Drawing.Point(478, 9);
            this.txt_fsolicitud.Name = "txt_fsolicitud";
            this.txt_fsolicitud.Size = new System.Drawing.Size(100, 27);
            this.txt_fsolicitud.TabIndex = 2;
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Location = new System.Drawing.Point(125, 42);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(453, 23);
            this.cmb_seccion.TabIndex = 3;
            this.cmb_seccion.DropDownClosed += new System.EventHandler(this.cmb_seccion_DropDownClosed);
            // 
            // txt_folio
            // 
            this.txt_folio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_folio.Location = new System.Drawing.Point(125, 9);
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(100, 27);
            this.txt_folio.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descripción del Problema";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle.Location = new System.Drawing.Point(16, 140);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(562, 117);
            this.txt_detalle.TabIndex = 2;
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.Image")));
            this.cmd_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_eliminar.Location = new System.Drawing.Point(584, 75);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(103, 60);
            this.cmd_eliminar.TabIndex = 14;
            this.cmd_eliminar.Text = "&Eliminar";
            this.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // cmd_insertar
            // 
            this.cmd_insertar.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_insertar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_insertar.Image")));
            this.cmd_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_insertar.Location = new System.Drawing.Point(584, 9);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(103, 60);
            this.cmd_insertar.TabIndex = 15;
            this.cmd_insertar.Text = "&Agregar\r Actualizar";
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_limpiar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear;
            this.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_limpiar.Location = new System.Drawing.Point(584, 141);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(103, 60);
            this.cmd_limpiar.TabIndex = 16;
            this.cmd_limpiar.Text = "&Limpiar";
            this.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_limpiar.UseVisualStyleBackColor = true;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Solicitante";
            // 
            // cmb_solicitante
            // 
            this.cmb_solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_solicitante.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_solicitante.FormattingEnabled = true;
            this.cmb_solicitante.Location = new System.Drawing.Point(125, 71);
            this.cmb_solicitante.Name = "cmb_solicitante";
            this.cmb_solicitante.Size = new System.Drawing.Size(453, 23);
            this.cmb_solicitante.TabIndex = 3;
            this.cmb_solicitante.DropDownClosed += new System.EventHandler(this.cmb_solicitante_DropDownClosed);
            // 
            // dat_solicitud
            // 
            this.dat_solicitud.AllowUserToAddRows = false;
            this.dat_solicitud.AllowUserToDeleteRows = false;
            this.dat_solicitud.AllowUserToResizeColumns = false;
            this.dat_solicitud.AllowUserToResizeRows = false;
            this.dat_solicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_solicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_solicitud.Location = new System.Drawing.Point(16, 274);
            this.dat_solicitud.Name = "dat_solicitud";
            this.dat_solicitud.ReadOnly = true;
            this.dat_solicitud.RowHeadersVisible = false;
            this.dat_solicitud.Size = new System.Drawing.Size(562, 196);
            this.dat_solicitud.TabIndex = 17;
            this.dat_solicitud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_solicitud_CellClick);
            // 
            // cmd_lista
            // 
            this.cmd_lista.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_lista.Image = ((System.Drawing.Image)(resources.GetObject("cmd_lista.Image")));
            this.cmd_lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_lista.Location = new System.Drawing.Point(584, 207);
            this.cmd_lista.Name = "cmd_lista";
            this.cmd_lista.Size = new System.Drawing.Size(103, 60);
            this.cmd_lista.TabIndex = 15;
            this.cmd_lista.Text = "&Ver Todas";
            this.cmd_lista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_lista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmd_lista.UseVisualStyleBackColor = true;
            this.cmd_lista.Click += new System.EventHandler(this.cmd_lista_Click);
            // 
            // frm_solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 481);
            this.Controls.Add(this.dat_solicitud);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_lista);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.cmb_solicitante);
            this.Controls.Add(this.cmb_seccion);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.txt_folio);
            this.Controls.Add(this.txt_fsolicitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Solicitud";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_solicitud_FormClosing);
            this.Load += new System.EventHandler(this.frm_solicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_solicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fsolicitud;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_solicitante;
        private System.Windows.Forms.DataGridView dat_solicitud;
        private System.Windows.Forms.Button cmd_lista;
    }
}