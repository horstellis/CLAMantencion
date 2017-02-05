namespace MantencionCLA
{
    partial class frm_mant_basico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_basico));
            this.dat_tabla = new System.Windows.Forms.DataGridView();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dat_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_tabla
            // 
            this.dat_tabla.AllowUserToAddRows = false;
            this.dat_tabla.AllowUserToDeleteRows = false;
            this.dat_tabla.AllowUserToResizeColumns = false;
            this.dat_tabla.AllowUserToResizeRows = false;
            this.dat_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_tabla.BackgroundColor = System.Drawing.Color.Snow;
            this.dat_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_tabla.GridColor = System.Drawing.Color.Snow;
            this.dat_tabla.Location = new System.Drawing.Point(12, 35);
            this.dat_tabla.Name = "dat_tabla";
            this.dat_tabla.ReadOnly = true;
            this.dat_tabla.RowHeadersVisible = false;
            this.dat_tabla.Size = new System.Drawing.Size(413, 206);
            this.dat_tabla.TabIndex = 10;
            this.dat_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_tabla_CellClick);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(156, 6);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ShortcutsEnabled = false;
            this.txt_descripcion.Size = new System.Drawing.Size(269, 23);
            this.txt_descripcion.TabIndex = 9;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 9);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(68, 15);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.FlatAppearance.BorderSize = 0;
            this.cmd_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_eliminar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Delete_48px;
            this.cmd_eliminar.Location = new System.Drawing.Point(432, 72);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(60, 60);
            this.cmd_eliminar.TabIndex = 11;
            this.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.cmd_eliminar, "Eliminar registro");
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // cmd_insertar
            // 
            this.cmd_insertar.FlatAppearance.BorderSize = 0;
            this.cmd_insertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_insertar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_insertar.Image = global::MantencionCLA.Properties.Resources.Gnome_Media_Floppy_48px;
            this.cmd_insertar.Location = new System.Drawing.Point(432, 6);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(60, 60);
            this.cmd_insertar.TabIndex = 12;
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.cmd_insertar, "Agregar o actualizar registro");
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.FlatAppearance.BorderSize = 0;
            this.cmd_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_limpiar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear_48px;
            this.cmd_limpiar.Location = new System.Drawing.Point(431, 138);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(60, 60);
            this.cmd_limpiar.TabIndex = 13;
            this.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.cmd_limpiar, "Limpiar campos");
            this.cmd_limpiar.UseVisualStyleBackColor = true;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // frm_mant_basico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 255);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.dat_tabla);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mant_basico";
            this.Text = "frm_mant_basico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mant_basico_FormClosing);
            this.Load += new System.EventHandler(this.frm_mant_basico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_tabla;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.ToolTip tooltip;
    }
}