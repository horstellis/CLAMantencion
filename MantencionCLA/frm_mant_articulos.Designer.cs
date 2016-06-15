namespace MantencionCLA
{
    partial class frm_mant_articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_articulos));
            this.dat_articulo = new System.Windows.Forms.DataGridView();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_articulo
            // 
            this.dat_articulo.AllowUserToAddRows = false;
            this.dat_articulo.AllowUserToOrderColumns = true;
            this.dat_articulo.AllowUserToResizeColumns = false;
            this.dat_articulo.AllowUserToResizeRows = false;
            this.dat_articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_articulo.Location = new System.Drawing.Point(12, 115);
            this.dat_articulo.Name = "dat_articulo";
            this.dat_articulo.ReadOnly = true;
            this.dat_articulo.RowHeadersVisible = false;
            this.dat_articulo.Size = new System.Drawing.Size(344, 218);
            this.dat_articulo.TabIndex = 43;
            this.dat_articulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_articulo_CellClick);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "dsa"});
            this.cmb_tipo.Location = new System.Drawing.Point(132, 47);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(224, 23);
            this.cmb_tipo.TabIndex = 42;
            this.cmb_tipo.DropDownClosed += new System.EventHandler(this.cmb_tipo_DropDownClosed);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(132, 13);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ShortcutsEnabled = false;
            this.txt_nombre.Size = new System.Drawing.Size(224, 23);
            this.txt_nombre.TabIndex = 41;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.Image")));
            this.cmd_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_eliminar.Location = new System.Drawing.Point(362, 79);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(103, 60);
            this.cmd_eliminar.TabIndex = 38;
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
            this.cmd_insertar.Location = new System.Drawing.Point(362, 13);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(103, 60);
            this.cmd_insertar.TabIndex = 39;
            this.cmd_insertar.Text = "&Agregar\r\nActualizar";
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear;
            this.cmd_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_nuevo.Location = new System.Drawing.Point(362, 145);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(103, 60);
            this.cmd_nuevo.TabIndex = 40;
            this.cmd_nuevo.Text = "&Limpiar";
            this.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            this.cmd_nuevo.Click += new System.EventHandler(this.cmd_nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tipo Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(132, 86);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ShortcutsEnabled = false;
            this.txt_cantidad.Size = new System.Drawing.Size(224, 23);
            this.txt_cantidad.TabIndex = 45;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cantidad";
            // 
            // frm_mant_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 346);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dat_articulo);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_mant_articulos";
            this.Text = "Mantenedor Articulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mant_articulos_FormClosing);
            this.Load += new System.EventHandler(this.frm_mant_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_articulo;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label3;
    }
}