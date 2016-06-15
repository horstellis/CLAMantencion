namespace MantencionCLA
{
    partial class frm_mant_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.fra_permisos = new System.Windows.Forms.GroupBox();
            this.opt_visor = new System.Windows.Forms.RadioButton();
            this.opt_usuario = new System.Windows.Forms.RadioButton();
            this.opt_admin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_bloqueado = new System.Windows.Forms.RadioButton();
            this.opt_inactivo = new System.Windows.Forms.RadioButton();
            this.opt_activo = new System.Windows.Forms.RadioButton();
            this.dat_usuarios = new System.Windows.Forms.DataGridView();
            this.cmd_ver_clave = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.fra_permisos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(119, 9);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(240, 23);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(119, 35);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(216, 23);
            this.txt_clave.TabIndex = 1;
            this.txt_clave.UseSystemPasswordChar = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(119, 61);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(240, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // fra_permisos
            // 
            this.fra_permisos.Controls.Add(this.opt_visor);
            this.fra_permisos.Controls.Add(this.opt_usuario);
            this.fra_permisos.Controls.Add(this.opt_admin);
            this.fra_permisos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fra_permisos.Location = new System.Drawing.Point(15, 90);
            this.fra_permisos.Name = "fra_permisos";
            this.fra_permisos.Size = new System.Drawing.Size(344, 49);
            this.fra_permisos.TabIndex = 2;
            this.fra_permisos.TabStop = false;
            this.fra_permisos.Text = "Permisos del Usuario";
            // 
            // opt_visor
            // 
            this.opt_visor.AutoSize = true;
            this.opt_visor.Location = new System.Drawing.Point(256, 22);
            this.opt_visor.Name = "opt_visor";
            this.opt_visor.Size = new System.Drawing.Size(52, 19);
            this.opt_visor.TabIndex = 0;
            this.opt_visor.TabStop = true;
            this.opt_visor.Text = "Visor";
            this.opt_visor.UseVisualStyleBackColor = true;
            this.opt_visor.Click += new System.EventHandler(this.opt_visor_Click);
            // 
            // opt_usuario
            // 
            this.opt_usuario.AutoSize = true;
            this.opt_usuario.Location = new System.Drawing.Point(137, 22);
            this.opt_usuario.Name = "opt_usuario";
            this.opt_usuario.Size = new System.Drawing.Size(66, 19);
            this.opt_usuario.TabIndex = 0;
            this.opt_usuario.TabStop = true;
            this.opt_usuario.Text = "Usuario";
            this.opt_usuario.UseVisualStyleBackColor = true;
            this.opt_usuario.Click += new System.EventHandler(this.opt_usuario_Click);
            // 
            // opt_admin
            // 
            this.opt_admin.AutoSize = true;
            this.opt_admin.Location = new System.Drawing.Point(7, 23);
            this.opt_admin.Name = "opt_admin";
            this.opt_admin.Size = new System.Drawing.Size(102, 19);
            this.opt_admin.TabIndex = 0;
            this.opt_admin.TabStop = true;
            this.opt_admin.Text = "Administrador";
            this.opt_admin.UseVisualStyleBackColor = true;
            this.opt_admin.Click += new System.EventHandler(this.opt_admin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_bloqueado);
            this.groupBox1.Controls.Add(this.opt_inactivo);
            this.groupBox1.Controls.Add(this.opt_activo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Usuario";
            // 
            // opt_bloqueado
            // 
            this.opt_bloqueado.AutoSize = true;
            this.opt_bloqueado.Location = new System.Drawing.Point(256, 24);
            this.opt_bloqueado.Name = "opt_bloqueado";
            this.opt_bloqueado.Size = new System.Drawing.Size(82, 19);
            this.opt_bloqueado.TabIndex = 0;
            this.opt_bloqueado.TabStop = true;
            this.opt_bloqueado.Text = "Bloqueado";
            this.opt_bloqueado.UseVisualStyleBackColor = true;
            this.opt_bloqueado.Click += new System.EventHandler(this.opt_bloqueado_Click);
            // 
            // opt_inactivo
            // 
            this.opt_inactivo.AutoSize = true;
            this.opt_inactivo.Location = new System.Drawing.Point(137, 22);
            this.opt_inactivo.Name = "opt_inactivo";
            this.opt_inactivo.Size = new System.Drawing.Size(66, 19);
            this.opt_inactivo.TabIndex = 0;
            this.opt_inactivo.TabStop = true;
            this.opt_inactivo.Text = "Inactivo";
            this.opt_inactivo.UseVisualStyleBackColor = true;
            this.opt_inactivo.Click += new System.EventHandler(this.opt_inactivo_Click);
            // 
            // opt_activo
            // 
            this.opt_activo.AutoSize = true;
            this.opt_activo.Location = new System.Drawing.Point(7, 23);
            this.opt_activo.Name = "opt_activo";
            this.opt_activo.Size = new System.Drawing.Size(58, 19);
            this.opt_activo.TabIndex = 0;
            this.opt_activo.TabStop = true;
            this.opt_activo.Text = "Activo";
            this.opt_activo.UseVisualStyleBackColor = true;
            this.opt_activo.Click += new System.EventHandler(this.opt_activo_Click);
            // 
            // dat_usuarios
            // 
            this.dat_usuarios.AllowUserToAddRows = false;
            this.dat_usuarios.AllowUserToDeleteRows = false;
            this.dat_usuarios.AllowUserToResizeColumns = false;
            this.dat_usuarios.AllowUserToResizeRows = false;
            this.dat_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_usuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dat_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_usuarios.Location = new System.Drawing.Point(366, 9);
            this.dat_usuarios.Name = "dat_usuarios";
            this.dat_usuarios.RowHeadersVisible = false;
            this.dat_usuarios.Size = new System.Drawing.Size(358, 248);
            this.dat_usuarios.TabIndex = 28;
            this.dat_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_usuarios_CellClick);
            // 
            // cmd_ver_clave
            // 
            this.cmd_ver_clave.BackColor = System.Drawing.Color.Transparent;
            this.cmd_ver_clave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_ver_clave.FlatAppearance.BorderSize = 0;
            this.cmd_ver_clave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_ver_clave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_ver_clave.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ver_clave.Location = new System.Drawing.Point(341, 37);
            this.cmd_ver_clave.Name = "cmd_ver_clave";
            this.cmd_ver_clave.Size = new System.Drawing.Size(18, 21);
            this.cmd_ver_clave.TabIndex = 35;
            this.cmd_ver_clave.Text = "";
            this.cmd_ver_clave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_ver_clave.UseVisualStyleBackColor = false;
            this.cmd_ver_clave.MouseEnter += new System.EventHandler(this.cmd_ver_clave_MouseEnter);
            this.cmd_ver_clave.MouseLeave += new System.EventHandler(this.cmd_ver_clave_MouseLeave);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.Image")));
            this.cmd_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_eliminar.Location = new System.Drawing.Point(135, 200);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(103, 60);
            this.cmd_eliminar.TabIndex = 25;
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
            this.cmd_insertar.Location = new System.Drawing.Point(15, 200);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(103, 60);
            this.cmd_insertar.TabIndex = 26;
            this.cmd_insertar.Text = "&Agregar\r\nActualizar";
            this.cmd_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_insertar.UseVisualStyleBackColor = true;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear;
            this.cmd_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_nuevo.Location = new System.Drawing.Point(255, 200);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(103, 60);
            this.cmd_nuevo.TabIndex = 27;
            this.cmd_nuevo.Text = "&Limpiar";
            this.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            this.cmd_nuevo.Click += new System.EventHandler(this.cmd_nuevo_Click);
            // 
            // frm_mant_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 269);
            this.Controls.Add(this.cmd_ver_clave);
            this.Controls.Add(this.dat_usuarios);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.cmd_nuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fra_permisos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_mant_usuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenedores - Usuarios";
            this.Load += new System.EventHandler(this.frm_mant_usuarios_Load);
            this.fra_permisos.ResumeLayout(false);
            this.fra_permisos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox fra_permisos;
        private System.Windows.Forms.RadioButton opt_visor;
        private System.Windows.Forms.RadioButton opt_admin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_inactivo;
        private System.Windows.Forms.RadioButton opt_activo;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.DataGridView dat_usuarios;
        private System.Windows.Forms.RadioButton opt_usuario;
        private System.Windows.Forms.RadioButton opt_bloqueado;
        private System.Windows.Forms.Button cmd_ver_clave;
    }
}