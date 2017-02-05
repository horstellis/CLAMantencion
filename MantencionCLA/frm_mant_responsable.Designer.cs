namespace MantencionCLA
{
    partial class frm_mant_responsable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_inactivo = new System.Windows.Forms.RadioButton();
            this.opt_activo = new System.Windows.Forms.RadioButton();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_cargo = new System.Windows.Forms.ComboBox();
            this.dat_responsable = new System.Windows.Forms.DataGridView();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_responsable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargo";
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.FlatAppearance.BorderSize = 0;
            this.cmd_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_eliminar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Delete_48px;
            this.cmd_eliminar.Location = new System.Drawing.Point(399, 72);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(60, 60);
            this.cmd_eliminar.TabIndex = 29;
            this.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.cmd_eliminar, "Eliminar responsable");
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
            this.cmd_insertar.Location = new System.Drawing.Point(399, 6);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(60, 60);
            this.cmd_insertar.TabIndex = 30;
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.cmd_insertar, "Agregar o actualizar responsable");
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.FlatAppearance.BorderSize = 0;
            this.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_nuevo.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear_48px;
            this.cmd_nuevo.Location = new System.Drawing.Point(399, 138);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(60, 60);
            this.cmd_nuevo.TabIndex = 31;
            this.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.cmd_nuevo, "Limpiar campos");
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            this.cmd_nuevo.Click += new System.EventHandler(this.cmd_nuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_inactivo);
            this.groupBox1.Controls.Add(this.opt_activo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 49);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Responsable";
            // 
            // opt_inactivo
            // 
            this.opt_inactivo.AutoSize = true;
            this.opt_inactivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_inactivo.Location = new System.Drawing.Point(313, 23);
            this.opt_inactivo.Name = "opt_inactivo";
            this.opt_inactivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opt_inactivo.Size = new System.Drawing.Size(66, 19);
            this.opt_inactivo.TabIndex = 0;
            this.opt_inactivo.Text = "Inactivo";
            this.opt_inactivo.UseVisualStyleBackColor = true;
            this.opt_inactivo.Click += new System.EventHandler(this.opt_inactivo_Click);
            // 
            // opt_activo
            // 
            this.opt_activo.AutoSize = true;
            this.opt_activo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_activo.Location = new System.Drawing.Point(7, 23);
            this.opt_activo.Name = "opt_activo";
            this.opt_activo.Size = new System.Drawing.Size(58, 19);
            this.opt_activo.TabIndex = 0;
            this.opt_activo.Text = "Activo";
            this.opt_activo.UseVisualStyleBackColor = true;
            this.opt_activo.Click += new System.EventHandler(this.opt_activo_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(128, 6);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(265, 23);
            this.txt_nombre.TabIndex = 32;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Location = new System.Drawing.Point(128, 35);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(265, 23);
            this.cmb_cargo.TabIndex = 33;
            this.cmb_cargo.DropDownClosed += new System.EventHandler(this.cmb_cargo_DropDownClosed);
            // 
            // dat_responsable
            // 
            this.dat_responsable.AllowUserToAddRows = false;
            this.dat_responsable.AllowUserToOrderColumns = true;
            this.dat_responsable.AllowUserToResizeColumns = false;
            this.dat_responsable.AllowUserToResizeRows = false;
            this.dat_responsable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_responsable.BackgroundColor = System.Drawing.Color.Snow;
            this.dat_responsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_responsable.GridColor = System.Drawing.Color.Snow;
            this.dat_responsable.Location = new System.Drawing.Point(8, 119);
            this.dat_responsable.Name = "dat_responsable";
            this.dat_responsable.ReadOnly = true;
            this.dat_responsable.RowHeadersVisible = false;
            this.dat_responsable.Size = new System.Drawing.Size(385, 218);
            this.dat_responsable.TabIndex = 34;
            this.dat_responsable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_responsable_CellClick);
            // 
            // frm_mant_responsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(471, 350);
            this.Controls.Add(this.dat_responsable);
            this.Controls.Add(this.cmb_cargo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_nuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mant_responsable";
            this.Text = "Mantenedor Responsable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mant_responsable_FormClosing);
            this.Load += new System.EventHandler(this.frm_mant_responsable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_responsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_inactivo;
        private System.Windows.Forms.RadioButton opt_activo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_cargo;
        private System.Windows.Forms.DataGridView dat_responsable;
        private System.Windows.Forms.ToolTip tooltip;
    }
}