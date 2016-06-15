namespace MantencionCLA
{
    partial class frm_mant_foraneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_foraneo));
            this.cmb_foraneo = new System.Windows.Forms.ComboBox();
            this.dat_tabla = new System.Windows.Forms.DataGridView();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_foraneo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_foraneo
            // 
            this.cmb_foraneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_foraneo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_foraneo.FormattingEnabled = true;
            this.cmb_foraneo.Location = new System.Drawing.Point(154, 10);
            this.cmb_foraneo.Name = "cmb_foraneo";
            this.cmb_foraneo.Size = new System.Drawing.Size(271, 23);
            this.cmb_foraneo.TabIndex = 19;
            this.cmb_foraneo.DropDownClosed += new System.EventHandler(this.cmb_foraneo_DropDownClosed);
            // 
            // dat_tabla
            // 
            this.dat_tabla.AllowUserToAddRows = false;
            this.dat_tabla.AllowUserToDeleteRows = false;
            this.dat_tabla.AllowUserToResizeColumns = false;
            this.dat_tabla.AllowUserToResizeRows = false;
            this.dat_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_tabla.ColumnHeadersVisible = false;
            this.dat_tabla.Location = new System.Drawing.Point(12, 187);
            this.dat_tabla.Name = "dat_tabla";
            this.dat_tabla.ReadOnly = true;
            this.dat_tabla.RowHeadersVisible = false;
            this.dat_tabla.Size = new System.Drawing.Size(413, 126);
            this.dat_tabla.TabIndex = 18;
            this.dat_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_tabla_CellClick);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(154, 39);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(271, 23);
            this.txt_nombre.TabIndex = 17;
            // 
            // lbl_foraneo
            // 
            this.lbl_foraneo.AutoSize = true;
            this.lbl_foraneo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foraneo.Location = new System.Drawing.Point(9, 13);
            this.lbl_foraneo.Name = "lbl_foraneo";
            this.lbl_foraneo.Size = new System.Drawing.Size(51, 15);
            this.lbl_foraneo.TabIndex = 15;
            this.lbl_foraneo.Text = "Foraneo";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(9, 42);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(122, 15);
            this.lbl_descripcion.TabIndex = 16;
            this.lbl_descripcion.Text = "Nombre / Descripción";
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.Image")));
            this.cmd_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_eliminar.Location = new System.Drawing.Point(167, 121);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(103, 60);
            this.cmd_eliminar.TabIndex = 22;
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
            this.cmd_insertar.Location = new System.Drawing.Point(12, 121);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(103, 60);
            this.cmd_insertar.TabIndex = 23;
            this.cmd_insertar.Text = "&Agregar\r\nActualizar";
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear;
            this.cmd_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_nuevo.Location = new System.Drawing.Point(322, 121);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(103, 60);
            this.cmd_nuevo.TabIndex = 24;
            this.cmd_nuevo.Text = "&Limpiar";
            this.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            this.cmd_nuevo.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // frm_mant_foraneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 321);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_nuevo);
            this.Controls.Add(this.cmb_foraneo);
            this.Controls.Add(this.dat_tabla);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_foraneo);
            this.Controls.Add(this.lbl_descripcion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 360);
            this.Name = "frm_mant_foraneo";
            this.Text = "frm_mant_foraneo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mant_foraneo_FormClosing);
            this.Load += new System.EventHandler(this.frm_mant_foraneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_foraneo;
        private System.Windows.Forms.DataGridView dat_tabla;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_foraneo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_nuevo;
    }
}