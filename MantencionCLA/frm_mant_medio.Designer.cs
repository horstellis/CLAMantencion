namespace MantencionCLA
{
    partial class frm_mant_medio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_medio));
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.dat_tabla = new System.Windows.Forms.DataGridView();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.lbl_observacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.Image")));
            this.cmd_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_eliminar.Location = new System.Drawing.Point(167, 95);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(103, 60);
            this.cmd_eliminar.TabIndex = 17;
            this.cmd_eliminar.Text = "&Eliminar";
            this.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // cmd_insertar
            // 
            this.cmd_insertar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_insertar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_insertar.Image")));
            this.cmd_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_insertar.Location = new System.Drawing.Point(12, 95);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(103, 60);
            this.cmd_insertar.TabIndex = 18;
            this.cmd_insertar.Text = "&Agregar\r\nActualizar";
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear;
            this.cmd_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_nuevo.Location = new System.Drawing.Point(323, 95);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(103, 60);
            this.cmd_nuevo.TabIndex = 19;
            this.cmd_nuevo.Text = "&Limpiar";
            this.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            this.cmd_nuevo.Click += new System.EventHandler(this.cmd_nuevo_Click);
            // 
            // dat_tabla
            // 
            this.dat_tabla.AllowUserToAddRows = false;
            this.dat_tabla.AllowUserToDeleteRows = false;
            this.dat_tabla.AllowUserToResizeColumns = false;
            this.dat_tabla.AllowUserToResizeRows = false;
            this.dat_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_tabla.Location = new System.Drawing.Point(12, 161);
            this.dat_tabla.Name = "dat_tabla";
            this.dat_tabla.ReadOnly = true;
            this.dat_tabla.RowHeadersVisible = false;
            this.dat_tabla.Size = new System.Drawing.Size(414, 133);
            this.dat_tabla.TabIndex = 16;
            this.dat_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_tabla_CellClick);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(157, 6);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(269, 23);
            this.txt_descripcion.TabIndex = 15;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 9);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(122, 15);
            this.lbl_descripcion.TabIndex = 14;
            this.lbl_descripcion.Text = "Descripción / Nombre";
            // 
            // txt_observacion
            // 
            this.txt_observacion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacion.Location = new System.Drawing.Point(157, 36);
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(269, 47);
            this.txt_observacion.TabIndex = 21;
            // 
            // lbl_observacion
            // 
            this.lbl_observacion.AutoSize = true;
            this.lbl_observacion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacion.Location = new System.Drawing.Point(12, 39);
            this.lbl_observacion.Name = "lbl_observacion";
            this.lbl_observacion.Size = new System.Drawing.Size(73, 15);
            this.lbl_observacion.TabIndex = 20;
            this.lbl_observacion.Text = "Observación";
            // 
            // frm_mant_medio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 306);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.lbl_observacion);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_nuevo);
            this.Controls.Add(this.dat_tabla);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 345);
            this.Name = "frm_mant_medio";
            this.Text = "frm_mant_medio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mant_medio_FormClosing);
            this.Load += new System.EventHandler(this.frm_mant_medio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.DataGridView dat_tabla;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.Label lbl_observacion;
    }
}