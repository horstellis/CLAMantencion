namespace MantencionCLA
{
    partial class frm_articulos_mantencion
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
            this.cmb_tipo_articulo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_articulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_solicitud = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_maquina = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dat_articulos = new System.Windows.Forms.DataGridView();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_disponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipo_articulo
            // 
            this.cmb_tipo_articulo.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_tipo_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_articulo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_articulo.FormattingEnabled = true;
            this.cmb_tipo_articulo.Location = new System.Drawing.Point(118, 63);
            this.cmb_tipo_articulo.Name = "cmb_tipo_articulo";
            this.cmb_tipo_articulo.Size = new System.Drawing.Size(179, 23);
            this.cmb_tipo_articulo.TabIndex = 5;
            this.cmb_tipo_articulo.DropDownClosed += new System.EventHandler(this.cmb_tipo_articulo_DropDownClosed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de Artículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artículo";
            // 
            // cmb_articulo
            // 
            this.cmb_articulo.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_articulo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_articulo.FormattingEnabled = true;
            this.cmb_articulo.Location = new System.Drawing.Point(118, 90);
            this.cmb_articulo.Name = "cmb_articulo";
            this.cmb_articulo.Size = new System.Drawing.Size(179, 23);
            this.cmb_articulo.TabIndex = 5;
            this.cmb_articulo.DropDownClosed += new System.EventHandler(this.cmb_articulo_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solicitud Asociada";
            // 
            // lbl_solicitud
            // 
            this.lbl_solicitud.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_solicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_solicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_solicitud.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solicitud.Location = new System.Drawing.Point(118, 9);
            this.lbl_solicitud.Name = "lbl_solicitud";
            this.lbl_solicitud.Size = new System.Drawing.Size(179, 23);
            this.lbl_solicitud.TabIndex = 4;
            this.lbl_solicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Máquina Asociada";
            // 
            // lbl_maquina
            // 
            this.lbl_maquina.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_maquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_maquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_maquina.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maquina.Location = new System.Drawing.Point(118, 36);
            this.lbl_maquina.Name = "lbl_maquina";
            this.lbl_maquina.Size = new System.Drawing.Size(179, 23);
            this.lbl_maquina.TabIndex = 4;
            this.lbl_maquina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(118, 142);
            this.txt_cantidad.MaxLength = 5;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(179, 23);
            this.txt_cantidad.TabIndex = 1;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // dat_articulos
            // 
            this.dat_articulos.AllowUserToAddRows = false;
            this.dat_articulos.AllowUserToDeleteRows = false;
            this.dat_articulos.AllowUserToResizeColumns = false;
            this.dat_articulos.AllowUserToResizeRows = false;
            this.dat_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_articulos.BackgroundColor = System.Drawing.Color.Snow;
            this.dat_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_articulos.GridColor = System.Drawing.Color.Snow;
            this.dat_articulos.Location = new System.Drawing.Point(11, 171);
            this.dat_articulos.Name = "dat_articulos";
            this.dat_articulos.ReadOnly = true;
            this.dat_articulos.RowHeadersVisible = false;
            this.dat_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dat_articulos.Size = new System.Drawing.Size(286, 166);
            this.dat_articulos.TabIndex = 46;
            this.dat_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_articulos_CellClick);
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.Color.Snow;
            this.cmd_limpiar.FlatAppearance.BorderSize = 0;
            this.cmd_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_limpiar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear_48px;
            this.cmd_limpiar.Location = new System.Drawing.Point(303, 141);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(60, 60);
            this.cmd_limpiar.TabIndex = 45;
            this.cmd_limpiar.Tag = "Limpiar los campos";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.BackColor = System.Drawing.Color.Snow;
            this.cmd_eliminar.FlatAppearance.BorderSize = 0;
            this.cmd_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_eliminar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Delete_48px;
            this.cmd_eliminar.Location = new System.Drawing.Point(303, 75);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(60, 60);
            this.cmd_eliminar.TabIndex = 44;
            this.cmd_eliminar.Tag = "Eliminar registro seleccionado";
            this.cmd_eliminar.UseVisualStyleBackColor = false;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // cmd_insertar
            // 
            this.cmd_insertar.BackColor = System.Drawing.Color.Snow;
            this.cmd_insertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_insertar.FlatAppearance.BorderSize = 0;
            this.cmd_insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_insertar.Image = global::MantencionCLA.Properties.Resources.Gnome_Media_Floppy_48px;
            this.cmd_insertar.Location = new System.Drawing.Point(303, 9);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(60, 60);
            this.cmd_insertar.TabIndex = 43;
            this.cmd_insertar.Tag = "";
            this.cmd_insertar.UseVisualStyleBackColor = false;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 56);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota:\r\nSi requiere cambiar la máquina asociada, antes debe \r\nremover todos los ar" +
    "ticulos asociados a esa máquina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Disponible";
            // 
            // lbl_disponible
            // 
            this.lbl_disponible.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_disponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_disponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_disponible.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disponible.Location = new System.Drawing.Point(118, 116);
            this.lbl_disponible.Name = "lbl_disponible";
            this.lbl_disponible.Size = new System.Drawing.Size(179, 23);
            this.lbl_disponible.TabIndex = 4;
            this.lbl_disponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_articulos_mantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(382, 395);
            this.Controls.Add(this.dat_articulos);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmb_articulo);
            this.Controls.Add(this.cmb_tipo_articulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_disponible);
            this.Controls.Add(this.lbl_maquina);
            this.Controls.Add(this.lbl_solicitud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_articulos_mantencion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ficha de Mantención - Asignar Artículos a Mantención";
            this.Load += new System.EventHandler(this.frm_articulos_mantencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipo_articulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_articulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_maquina;
        public System.Windows.Forms.Label lbl_solicitud;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.DataGridView dat_articulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_disponible;


    }
}