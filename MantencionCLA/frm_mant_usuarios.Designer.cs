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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mant_usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.fra_permisos = new System.Windows.Forms.GroupBox();
            this.opt_visor = new System.Windows.Forms.RadioButton();
            this.opt_admin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_inactivo = new System.Windows.Forms.RadioButton();
            this.opt_activo = new System.Windows.Forms.RadioButton();
            this.cmd_nuevo = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_guardar = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.mantencionDataSet = new MantencionCLA.mantencionDataSet();
            this.lista_usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_usuariosTableAdapter = new MantencionCLA.mantencionDataSetTableAdapters.lista_usuariosTableAdapter();
            this.tableAdapterManager = new MantencionCLA.mantencionDataSetTableAdapters.TableAdapterManager();
            this.dat_usuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fra_permisos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_usuariosBindingSource)).BeginInit();
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
            this.txt_clave.Size = new System.Drawing.Size(240, 23);
            this.txt_clave.TabIndex = 1;
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
            this.opt_visor.Location = new System.Drawing.Point(206, 22);
            this.opt_visor.Name = "opt_visor";
            this.opt_visor.Size = new System.Drawing.Size(52, 19);
            this.opt_visor.TabIndex = 0;
            this.opt_visor.TabStop = true;
            this.opt_visor.Text = "Visor";
            this.opt_visor.UseVisualStyleBackColor = true;
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
            // 
            // groupBox1
            // 
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
            // opt_inactivo
            // 
            this.opt_inactivo.AutoSize = true;
            this.opt_inactivo.Location = new System.Drawing.Point(206, 22);
            this.opt_inactivo.Name = "opt_inactivo";
            this.opt_inactivo.Size = new System.Drawing.Size(66, 19);
            this.opt_inactivo.TabIndex = 0;
            this.opt_inactivo.TabStop = true;
            this.opt_inactivo.Text = "Inactivo";
            this.opt_inactivo.UseVisualStyleBackColor = true;
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
            // 
            // cmd_nuevo
            // 
            this.cmd_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmd_nuevo.Image")));
            this.cmd_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_nuevo.Location = new System.Drawing.Point(15, 200);
            this.cmd_nuevo.Name = "cmd_nuevo";
            this.cmd_nuevo.Size = new System.Drawing.Size(64, 60);
            this.cmd_nuevo.TabIndex = 3;
            this.cmd_nuevo.Text = "&Nuevo";
            this.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_nuevo.UseVisualStyleBackColor = true;
            // 
            // cmd_editar
            // 
            this.cmd_editar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_editar.Image")));
            this.cmd_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_editar.Location = new System.Drawing.Point(85, 200);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(64, 60);
            this.cmd_editar.TabIndex = 3;
            this.cmd_editar.Text = "&Editar";
            this.cmd_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // cmd_guardar
            // 
            this.cmd_guardar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_guardar.Image")));
            this.cmd_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_guardar.Location = new System.Drawing.Point(155, 200);
            this.cmd_guardar.Name = "cmd_guardar";
            this.cmd_guardar.Size = new System.Drawing.Size(64, 60);
            this.cmd_guardar.TabIndex = 3;
            this.cmd_guardar.Text = "&Guardar";
            this.cmd_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_guardar.UseVisualStyleBackColor = true;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cmd_cancelar.Image")));
            this.cmd_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_cancelar.Location = new System.Drawing.Point(225, 200);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(64, 60);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "&Cancelar";
            this.cmd_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // cmd_salir
            // 
            this.cmd_salir.Image = ((System.Drawing.Image)(resources.GetObject("cmd_salir.Image")));
            this.cmd_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_salir.Location = new System.Drawing.Point(295, 200);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(64, 60);
            this.cmd_salir.TabIndex = 3;
            this.cmd_salir.Text = "&Salir";
            this.cmd_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_salir.UseVisualStyleBackColor = true;
            // 
            // mantencionDataSet
            // 
            this.mantencionDataSet.DataSetName = "mantencionDataSet";
            this.mantencionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lista_usuariosBindingSource
            // 
            this.lista_usuariosBindingSource.DataMember = "lista_usuarios";
            this.lista_usuariosBindingSource.DataSource = this.mantencionDataSet;
            // 
            // lista_usuariosTableAdapter
            // 
            this.lista_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.asignacionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clasificacionTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.det_diarioTableAdapter = null;
            this.tableAdapterManager.enc_diarioTableAdapter = null;
            this.tableAdapterManager.estado_actvidadTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.permisoTableAdapter = null;
            this.tableAdapterManager.responsable_asignadoTableAdapter = null;
            this.tableAdapterManager.responsableTableAdapter = null;
            this.tableAdapterManager.seccionTableAdapter = null;
            this.tableAdapterManager.sectorTableAdapter = null;
            this.tableAdapterManager.solicitanteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MantencionCLA.mantencionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // dat_usuarios
            // 
            this.dat_usuarios.AllowUserToAddRows = false;
            this.dat_usuarios.AllowUserToDeleteRows = false;
            this.dat_usuarios.AllowUserToResizeColumns = false;
            this.dat_usuarios.AllowUserToResizeRows = false;
            this.dat_usuarios.AutoGenerateColumns = false;
            this.dat_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dat_usuarios.DataSource = this.lista_usuariosBindingSource;
            this.dat_usuarios.Location = new System.Drawing.Point(365, 9);
            this.dat_usuarios.Name = "dat_usuarios";
            this.dat_usuarios.RowHeadersVisible = false;
            this.dat_usuarios.Size = new System.Drawing.Size(359, 251);
            this.dat_usuarios.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre Usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo Permiso";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo Permiso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frm_mant_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 269);
            this.Controls.Add(this.dat_usuarios);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_guardar);
            this.Controls.Add(this.cmd_editar);
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
            ((System.ComponentModel.ISupportInitialize)(this.mantencionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_usuariosBindingSource)).EndInit();
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
        private System.Windows.Forms.Button cmd_nuevo;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_guardar;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button cmd_salir;
        private mantencionDataSet mantencionDataSet;
        private System.Windows.Forms.BindingSource lista_usuariosBindingSource;
        private mantencionDataSetTableAdapters.lista_usuariosTableAdapter lista_usuariosTableAdapter;
        private mantencionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dat_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}