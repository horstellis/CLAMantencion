namespace MantencionCLA
{
    partial class frm_mantencion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_factual = new System.Windows.Forms.Label();
            this.txt_solicitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_solicitante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_linea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_maquina = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_finalizado = new System.Windows.Forms.RadioButton();
            this.opt_pendiente = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_ayudante = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.opt_no = new System.Windows.Forms.RadioButton();
            this.opt_si = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_responsable = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_clasificacion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_freal = new System.Windows.Forms.DateTimePicker();
            this.dtp_ftermino = new System.Windows.Forms.DateTimePicker();
            this.dtp_finicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_flimite = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dat_observaciones = new System.Windows.Forms.DataGridView();
            this.id_det_mantencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_fsolicitud = new System.Windows.Forms.DateTimePicker();
            this.fra_filtros = new System.Windows.Forms.GroupBox();
            this.cmd_buscar = new System.Windows.Forms.Button();
            this.fra_anio = new System.Windows.Forms.GroupBox();
            this.txt_ver_anio = new System.Windows.Forms.TextBox();
            this.opt_ver_anio_anio = new System.Windows.Forms.RadioButton();
            this.opt_ver_anio_todos = new System.Windows.Forms.RadioButton();
            this.fra_seccion = new System.Windows.Forms.GroupBox();
            this.cmb_ver_seccion = new System.Windows.Forms.ComboBox();
            this.opt_ver_sec_una = new System.Windows.Forms.RadioButton();
            this.opt_ver_sec_todas = new System.Windows.Forms.RadioButton();
            this.fra_opciones = new System.Windows.Forms.GroupBox();
            this.opt_ver_finalizadas = new System.Windows.Forms.RadioButton();
            this.opt_ver_vencidas = new System.Windows.Forms.RadioButton();
            this.opt_ver_por_vencer = new System.Windows.Forms.RadioButton();
            this.opt_ver_pendientes = new System.Windows.Forms.RadioButton();
            this.opt_ver_solicitud = new System.Windows.Forms.RadioButton();
            this.opt_ver_sin_asignar = new System.Windows.Forms.RadioButton();
            this.dat_ver = new System.Windows.Forms.DataGridView();
            this.id_solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cmd_asignar_articulos = new System.Windows.Forms.Button();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_insertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_observaciones)).BeginInit();
            this.fra_filtros.SuspendLayout();
            this.fra_anio.SuspendLayout();
            this.fra_seccion.SuspendLayout();
            this.fra_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_factual
            // 
            this.lbl_factual.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_factual.Location = new System.Drawing.Point(393, 1);
            this.lbl_factual.Name = "lbl_factual";
            this.lbl_factual.Size = new System.Drawing.Size(217, 23);
            this.lbl_factual.TabIndex = 0;
            this.lbl_factual.Text = "Fecha Actual, Formato Largo";
            this.lbl_factual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_solicitud
            // 
            this.txt_solicitud.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_solicitud.Location = new System.Drawing.Point(123, 6);
            this.txt_solicitud.MaxLength = 5;
            this.txt_solicitud.Name = "txt_solicitud";
            this.txt_solicitud.Size = new System.Drawing.Size(82, 23);
            this.txt_solicitud.TabIndex = 1;
            this.txt_solicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_solicitud_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Solicitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Solicitante";
            // 
            // cmb_solicitante
            // 
            this.cmb_solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_solicitante.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_solicitante.FormattingEnabled = true;
            this.cmb_solicitante.Location = new System.Drawing.Point(123, 64);
            this.cmb_solicitante.Name = "cmb_solicitante";
            this.cmb_solicitante.Size = new System.Drawing.Size(328, 23);
            this.cmb_solicitante.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sección";
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seccion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Location = new System.Drawing.Point(123, 93);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(328, 23);
            this.cmb_seccion.TabIndex = 3;
            this.cmb_seccion.DropDownClosed += new System.EventHandler(this.cmb_seccion_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Línea de Proceso";
            // 
            // cmb_linea
            // 
            this.cmb_linea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_linea.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_linea.FormattingEnabled = true;
            this.cmb_linea.Location = new System.Drawing.Point(123, 121);
            this.cmb_linea.Name = "cmb_linea";
            this.cmb_linea.Size = new System.Drawing.Size(179, 23);
            this.cmb_linea.TabIndex = 3;
            this.cmb_linea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_linea_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Máquina Asociada";
            // 
            // cmb_maquina
            // 
            this.cmb_maquina.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maquina.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_maquina.FormattingEnabled = true;
            this.cmb_maquina.Location = new System.Drawing.Point(431, 122);
            this.cmb_maquina.Name = "cmb_maquina";
            this.cmb_maquina.Size = new System.Drawing.Size(179, 23);
            this.cmb_maquina.TabIndex = 3;
            this.cmb_maquina.SelectedIndexChanged += new System.EventHandler(this.cmb_maquina_SelectedIndexChanged);
            this.cmb_maquina.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_maquina_MouseClick);
            this.cmb_maquina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_maquina_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_finalizado);
            this.groupBox1.Controls.Add(this.opt_pendiente);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(457, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Actividad";
            // 
            // opt_finalizado
            // 
            this.opt_finalizado.AutoSize = true;
            this.opt_finalizado.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_finalizado.Location = new System.Drawing.Point(7, 49);
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
            this.opt_pendiente.Location = new System.Drawing.Point(7, 23);
            this.opt_pendiente.Name = "opt_pendiente";
            this.opt_pendiente.Size = new System.Drawing.Size(78, 19);
            this.opt_pendiente.TabIndex = 0;
            this.opt_pendiente.TabStop = true;
            this.opt_pendiente.Text = "Pendiente";
            this.opt_pendiente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripción del Problema";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle.Location = new System.Drawing.Point(15, 179);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_detalle.Size = new System.Drawing.Size(595, 59);
            this.txt_detalle.TabIndex = 1;
            this.txt_detalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_detalle_KeyPress_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ayudante);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.opt_no);
            this.groupBox2.Controls.Add(this.opt_si);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_responsable);
            this.groupBox2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mecánicos o Responsables";
            // 
            // lst_ayudante
            // 
            this.lst_ayudante.FormattingEnabled = true;
            this.lst_ayudante.Location = new System.Drawing.Point(157, 71);
            this.lst_ayudante.Name = "lst_ayudante";
            this.lst_ayudante.Size = new System.Drawing.Size(179, 58);
            this.lst_ayudante.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "¿Quienes?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "¿Requiere ayudante?";
            // 
            // opt_no
            // 
            this.opt_no.AutoSize = true;
            this.opt_no.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_no.Location = new System.Drawing.Point(296, 48);
            this.opt_no.Name = "opt_no";
            this.opt_no.Size = new System.Drawing.Size(40, 19);
            this.opt_no.TabIndex = 0;
            this.opt_no.TabStop = true;
            this.opt_no.Text = "No";
            this.opt_no.UseVisualStyleBackColor = true;
            this.opt_no.Click += new System.EventHandler(this.opt_no_Click);
            // 
            // opt_si
            // 
            this.opt_si.AutoSize = true;
            this.opt_si.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_si.Location = new System.Drawing.Point(157, 48);
            this.opt_si.Name = "opt_si";
            this.opt_si.Size = new System.Drawing.Size(34, 19);
            this.opt_si.TabIndex = 0;
            this.opt_si.TabStop = true;
            this.opt_si.Text = "Si";
            this.opt_si.UseVisualStyleBackColor = true;
            this.opt_si.Click += new System.EventHandler(this.opt_si_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Responsable Actividad";
            // 
            // cmb_responsable
            // 
            this.cmb_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_responsable.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_responsable.FormattingEnabled = true;
            this.cmb_responsable.Location = new System.Drawing.Point(157, 16);
            this.cmb_responsable.Name = "cmb_responsable";
            this.cmb_responsable.Size = new System.Drawing.Size(179, 23);
            this.cmb_responsable.TabIndex = 3;
            this.cmb_responsable.DropDown += new System.EventHandler(this.cmb_responsable_DropDown);
            this.cmb_responsable.SelectedIndexChanged += new System.EventHandler(this.cmb_responsable_SelectedIndexChanged);
            this.cmb_responsable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_responsable_MouseClick);
            this.cmb_responsable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_responsable_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Clasificación";
            // 
            // cmb_clasificacion
            // 
            this.cmb_clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clasificacion.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clasificacion.FormattingEnabled = true;
            this.cmb_clasificacion.Location = new System.Drawing.Point(431, 150);
            this.cmb_clasificacion.Name = "cmb_clasificacion";
            this.cmb_clasificacion.Size = new System.Drawing.Size(179, 23);
            this.cmb_clasificacion.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_freal);
            this.groupBox3.Controls.Add(this.dtp_ftermino);
            this.groupBox3.Controls.Add(this.dtp_finicio);
            this.groupBox3.Controls.Add(this.dtp_flimite);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(363, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fechas";
            // 
            // dtp_freal
            // 
            this.dtp_freal.CustomFormat = " ";
            this.dtp_freal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_freal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_freal.Location = new System.Drawing.Point(131, 103);
            this.dtp_freal.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_freal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_freal.Name = "dtp_freal";
            this.dtp_freal.Size = new System.Drawing.Size(105, 23);
            this.dtp_freal.TabIndex = 45;
            this.tooltip.SetToolTip(this.dtp_freal, "Click normal para mostrar\r\nClick contrario para borrar");
            this.dtp_freal.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            this.dtp_freal.FormatChanged += new System.EventHandler(this.dtp_freal_FormatChanged);
            this.dtp_freal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_freal_MouseDown);
            // 
            // dtp_ftermino
            // 
            this.dtp_ftermino.CustomFormat = " ";
            this.dtp_ftermino.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ftermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ftermino.Location = new System.Drawing.Point(131, 74);
            this.dtp_ftermino.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_ftermino.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_ftermino.Name = "dtp_ftermino";
            this.dtp_ftermino.Size = new System.Drawing.Size(105, 23);
            this.dtp_ftermino.TabIndex = 45;
            this.tooltip.SetToolTip(this.dtp_ftermino, "Click normal para mostrar\r\nClick contrario para borrar");
            this.dtp_ftermino.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            this.dtp_ftermino.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_ftermino_MouseDown);
            // 
            // dtp_finicio
            // 
            this.dtp_finicio.CustomFormat = " ";
            this.dtp_finicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_finicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_finicio.Location = new System.Drawing.Point(131, 45);
            this.dtp_finicio.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_finicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_finicio.Name = "dtp_finicio";
            this.dtp_finicio.Size = new System.Drawing.Size(105, 23);
            this.dtp_finicio.TabIndex = 45;
            this.tooltip.SetToolTip(this.dtp_finicio, "Click normal para mostrar\r\nClick contrario para borrar");
            this.dtp_finicio.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            this.dtp_finicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_finicio_MouseDown);
            // 
            // dtp_flimite
            // 
            this.dtp_flimite.CustomFormat = " ";
            this.dtp_flimite.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_flimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_flimite.Location = new System.Drawing.Point(131, 16);
            this.dtp_flimite.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_flimite.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_flimite.Name = "dtp_flimite";
            this.dtp_flimite.Size = new System.Drawing.Size(105, 23);
            this.dtp_flimite.TabIndex = 45;
            this.tooltip.SetToolTip(this.dtp_flimite, "Click normal para mostrar\r\nClick contrario para borrar");
            this.dtp_flimite.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            this.dtp_flimite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_flimite_MouseDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Término Real";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Término Programado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Inicio Programado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Límite";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 385);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "OBSERVACIONES";
            // 
            // dat_observaciones
            // 
            this.dat_observaciones.AllowUserToResizeColumns = false;
            this.dat_observaciones.AllowUserToResizeRows = false;
            this.dat_observaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dat_observaciones.BackgroundColor = System.Drawing.Color.Snow;
            this.dat_observaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dat_observaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_observaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_observaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_observaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_det_mantencion,
            this.fecha,
            this.observacion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dat_observaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.dat_observaciones.GridColor = System.Drawing.Color.Snow;
            this.dat_observaciones.Location = new System.Drawing.Point(15, 404);
            this.dat_observaciones.MultiSelect = false;
            this.dat_observaciones.Name = "dat_observaciones";
            this.dat_observaciones.RowHeadersWidth = 30;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_observaciones.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dat_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dat_observaciones.Size = new System.Drawing.Size(595, 150);
            this.dat_observaciones.TabIndex = 6;
            this.dat_observaciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_observaciones_CellEnter);
            this.dat_observaciones.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_observaciones_CellLeave);
            this.dat_observaciones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_observaciones_RowEnter);
            this.dat_observaciones.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dat_observaciones_RowHeaderMouseDoubleClick);
            this.dat_observaciones.Click += new System.EventHandler(this.dat_observaciones_Click);
            this.dat_observaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dat_observaciones_KeyDown);
            this.dat_observaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dat_observaciones_KeyUp);
            this.dat_observaciones.Leave += new System.EventHandler(this.dat_observaciones_Leave);
            // 
            // id_det_mantencion
            // 
            this.id_det_mantencion.HeaderText = "id";
            this.id_det_mantencion.Name = "id_det_mantencion";
            this.id_det_mantencion.Visible = false;
            // 
            // fecha
            // 
            dataGridViewCellStyle2.Format = "d";
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // observacion
            // 
            this.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.observacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.observacion.HeaderText = "Observación";
            this.observacion.Name = "observacion";
            // 
            // dtp_fsolicitud
            // 
            this.dtp_fsolicitud.CustomFormat = " ";
            this.dtp_fsolicitud.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fsolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fsolicitud.Location = new System.Drawing.Point(346, 35);
            this.dtp_fsolicitud.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_fsolicitud.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_fsolicitud.Name = "dtp_fsolicitud";
            this.dtp_fsolicitud.Size = new System.Drawing.Size(105, 23);
            this.dtp_fsolicitud.TabIndex = 44;
            this.tooltip.SetToolTip(this.dtp_fsolicitud, "Click normal para mostrar\r\nClick contrario para borrar");
            this.dtp_fsolicitud.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            this.dtp_fsolicitud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_fsolicitud_MouseDown);
            // 
            // fra_filtros
            // 
            this.fra_filtros.BackColor = System.Drawing.Color.Cornsilk;
            this.fra_filtros.Controls.Add(this.cmd_buscar);
            this.fra_filtros.Controls.Add(this.fra_anio);
            this.fra_filtros.Controls.Add(this.fra_seccion);
            this.fra_filtros.Controls.Add(this.fra_opciones);
            this.fra_filtros.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fra_filtros.Location = new System.Drawing.Point(681, 9);
            this.fra_filtros.Name = "fra_filtros";
            this.fra_filtros.Size = new System.Drawing.Size(299, 192);
            this.fra_filtros.TabIndex = 45;
            this.fra_filtros.TabStop = false;
            this.fra_filtros.Text = "Ver Solicitudes o Mantenciones";
            // 
            // cmd_buscar
            // 
            this.cmd_buscar.BackColor = System.Drawing.Color.Orange;
            this.cmd_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_buscar.Location = new System.Drawing.Point(6, 151);
            this.cmd_buscar.Name = "cmd_buscar";
            this.cmd_buscar.Size = new System.Drawing.Size(104, 23);
            this.cmd_buscar.TabIndex = 2;
            this.cmd_buscar.Text = "Buscar";
            this.cmd_buscar.UseVisualStyleBackColor = false;
            this.cmd_buscar.Click += new System.EventHandler(this.cmd_buscar_Click);
            // 
            // fra_anio
            // 
            this.fra_anio.Controls.Add(this.txt_ver_anio);
            this.fra_anio.Controls.Add(this.opt_ver_anio_anio);
            this.fra_anio.Controls.Add(this.opt_ver_anio_todos);
            this.fra_anio.Location = new System.Drawing.Point(116, 92);
            this.fra_anio.Name = "fra_anio";
            this.fra_anio.Size = new System.Drawing.Size(176, 82);
            this.fra_anio.TabIndex = 1;
            this.fra_anio.TabStop = false;
            this.fra_anio.Text = "Año a buscar";
            // 
            // txt_ver_anio
            // 
            this.txt_ver_anio.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ver_anio.Location = new System.Drawing.Point(67, 38);
            this.txt_ver_anio.MaxLength = 4;
            this.txt_ver_anio.Name = "txt_ver_anio";
            this.txt_ver_anio.Size = new System.Drawing.Size(102, 23);
            this.txt_ver_anio.TabIndex = 2;
            this.txt_ver_anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ver_anio_KeyPress);
            // 
            // opt_ver_anio_anio
            // 
            this.opt_ver_anio_anio.AutoSize = true;
            this.opt_ver_anio_anio.Location = new System.Drawing.Point(6, 44);
            this.opt_ver_anio_anio.Name = "opt_ver_anio_anio";
            this.opt_ver_anio_anio.Size = new System.Drawing.Size(46, 19);
            this.opt_ver_anio_anio.TabIndex = 0;
            this.opt_ver_anio_anio.TabStop = true;
            this.opt_ver_anio_anio.Text = "Año";
            this.opt_ver_anio_anio.UseVisualStyleBackColor = true;
            this.opt_ver_anio_anio.Click += new System.EventHandler(this.opt_ver_anio_anio_Click);
            // 
            // opt_ver_anio_todos
            // 
            this.opt_ver_anio_todos.AutoSize = true;
            this.opt_ver_anio_todos.Location = new System.Drawing.Point(7, 19);
            this.opt_ver_anio_todos.Name = "opt_ver_anio_todos";
            this.opt_ver_anio_todos.Size = new System.Drawing.Size(56, 19);
            this.opt_ver_anio_todos.TabIndex = 0;
            this.opt_ver_anio_todos.TabStop = true;
            this.opt_ver_anio_todos.Text = "Todos";
            this.opt_ver_anio_todos.UseVisualStyleBackColor = true;
            this.opt_ver_anio_todos.Click += new System.EventHandler(this.opt_ver_anio_todos_Click);
            // 
            // fra_seccion
            // 
            this.fra_seccion.Controls.Add(this.cmb_ver_seccion);
            this.fra_seccion.Controls.Add(this.opt_ver_sec_una);
            this.fra_seccion.Controls.Add(this.opt_ver_sec_todas);
            this.fra_seccion.Location = new System.Drawing.Point(116, 14);
            this.fra_seccion.Name = "fra_seccion";
            this.fra_seccion.Size = new System.Drawing.Size(176, 78);
            this.fra_seccion.TabIndex = 1;
            this.fra_seccion.TabStop = false;
            this.fra_seccion.Text = "Sección";
            // 
            // cmb_ver_seccion
            // 
            this.cmb_ver_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ver_seccion.FormattingEnabled = true;
            this.cmb_ver_seccion.Location = new System.Drawing.Point(7, 37);
            this.cmb_ver_seccion.Name = "cmb_ver_seccion";
            this.cmb_ver_seccion.Size = new System.Drawing.Size(163, 23);
            this.cmb_ver_seccion.TabIndex = 1;
            // 
            // opt_ver_sec_una
            // 
            this.opt_ver_sec_una.AutoSize = true;
            this.opt_ver_sec_una.Location = new System.Drawing.Point(115, 15);
            this.opt_ver_sec_una.Name = "opt_ver_sec_una";
            this.opt_ver_sec_una.Size = new System.Drawing.Size(46, 19);
            this.opt_ver_sec_una.TabIndex = 0;
            this.opt_ver_sec_una.TabStop = true;
            this.opt_ver_sec_una.Text = "Una";
            this.opt_ver_sec_una.UseVisualStyleBackColor = true;
            this.opt_ver_sec_una.Click += new System.EventHandler(this.opt_ver_sec_una_Click);
            // 
            // opt_ver_sec_todas
            // 
            this.opt_ver_sec_todas.AutoSize = true;
            this.opt_ver_sec_todas.Location = new System.Drawing.Point(7, 15);
            this.opt_ver_sec_todas.Name = "opt_ver_sec_todas";
            this.opt_ver_sec_todas.Size = new System.Drawing.Size(55, 19);
            this.opt_ver_sec_todas.TabIndex = 0;
            this.opt_ver_sec_todas.TabStop = true;
            this.opt_ver_sec_todas.Text = "Todas";
            this.opt_ver_sec_todas.UseVisualStyleBackColor = true;
            this.opt_ver_sec_todas.Click += new System.EventHandler(this.opt_ver_sec_todas_Click);
            // 
            // fra_opciones
            // 
            this.fra_opciones.Controls.Add(this.opt_ver_finalizadas);
            this.fra_opciones.Controls.Add(this.opt_ver_vencidas);
            this.fra_opciones.Controls.Add(this.opt_ver_por_vencer);
            this.fra_opciones.Controls.Add(this.opt_ver_pendientes);
            this.fra_opciones.Controls.Add(this.opt_ver_solicitud);
            this.fra_opciones.Controls.Add(this.opt_ver_sin_asignar);
            this.fra_opciones.Location = new System.Drawing.Point(6, 14);
            this.fra_opciones.Name = "fra_opciones";
            this.fra_opciones.Size = new System.Drawing.Size(104, 131);
            this.fra_opciones.TabIndex = 0;
            this.fra_opciones.TabStop = false;
            this.fra_opciones.Text = "Tipo Búsqueda";
            // 
            // opt_ver_finalizadas
            // 
            this.opt_ver_finalizadas.AutoSize = true;
            this.opt_ver_finalizadas.Location = new System.Drawing.Point(6, 110);
            this.opt_ver_finalizadas.Name = "opt_ver_finalizadas";
            this.opt_ver_finalizadas.Size = new System.Drawing.Size(82, 19);
            this.opt_ver_finalizadas.TabIndex = 0;
            this.opt_ver_finalizadas.TabStop = true;
            this.opt_ver_finalizadas.Text = "Finalizadas";
            this.opt_ver_finalizadas.UseVisualStyleBackColor = true;
            this.opt_ver_finalizadas.Click += new System.EventHandler(this.opt_ver_finalizadas_Click);
            // 
            // opt_ver_vencidas
            // 
            this.opt_ver_vencidas.AutoSize = true;
            this.opt_ver_vencidas.Location = new System.Drawing.Point(6, 91);
            this.opt_ver_vencidas.Name = "opt_ver_vencidas";
            this.opt_ver_vencidas.Size = new System.Drawing.Size(71, 19);
            this.opt_ver_vencidas.TabIndex = 0;
            this.opt_ver_vencidas.TabStop = true;
            this.opt_ver_vencidas.Text = "Vencidas";
            this.opt_ver_vencidas.UseVisualStyleBackColor = true;
            this.opt_ver_vencidas.Click += new System.EventHandler(this.opt_ver_vencidas_Click);
            // 
            // opt_ver_por_vencer
            // 
            this.opt_ver_por_vencer.AutoSize = true;
            this.opt_ver_por_vencer.Location = new System.Drawing.Point(6, 72);
            this.opt_ver_por_vencer.Name = "opt_ver_por_vencer";
            this.opt_ver_por_vencer.Size = new System.Drawing.Size(81, 19);
            this.opt_ver_por_vencer.TabIndex = 0;
            this.opt_ver_por_vencer.TabStop = true;
            this.opt_ver_por_vencer.Text = "Por vencer";
            this.opt_ver_por_vencer.UseVisualStyleBackColor = true;
            this.opt_ver_por_vencer.Click += new System.EventHandler(this.opt_ver_por_vencer_Click);
            // 
            // opt_ver_pendientes
            // 
            this.opt_ver_pendientes.AutoSize = true;
            this.opt_ver_pendientes.Location = new System.Drawing.Point(6, 53);
            this.opt_ver_pendientes.Name = "opt_ver_pendientes";
            this.opt_ver_pendientes.Size = new System.Drawing.Size(83, 19);
            this.opt_ver_pendientes.TabIndex = 0;
            this.opt_ver_pendientes.TabStop = true;
            this.opt_ver_pendientes.Text = "Pendientes";
            this.opt_ver_pendientes.UseVisualStyleBackColor = true;
            this.opt_ver_pendientes.Click += new System.EventHandler(this.opt_ver_pendientes_Click);
            // 
            // opt_ver_solicitud
            // 
            this.opt_ver_solicitud.AutoSize = true;
            this.opt_ver_solicitud.Location = new System.Drawing.Point(6, 15);
            this.opt_ver_solicitud.Name = "opt_ver_solicitud";
            this.opt_ver_solicitud.Size = new System.Drawing.Size(82, 19);
            this.opt_ver_solicitud.TabIndex = 0;
            this.opt_ver_solicitud.TabStop = true;
            this.opt_ver_solicitud.Text = "Solicitudes";
            this.tooltip.SetToolTip(this.opt_ver_solicitud, "Ver solicitudes generadas no asignadas a mantención\r\nFiltra por Sección y Año de " +
        "Solicitud");
            this.opt_ver_solicitud.UseVisualStyleBackColor = true;
            this.opt_ver_solicitud.Click += new System.EventHandler(this.opt_ver_solicitud_Click);
            // 
            // opt_ver_sin_asignar
            // 
            this.opt_ver_sin_asignar.AutoSize = true;
            this.opt_ver_sin_asignar.Location = new System.Drawing.Point(6, 34);
            this.opt_ver_sin_asignar.Name = "opt_ver_sin_asignar";
            this.opt_ver_sin_asignar.Size = new System.Drawing.Size(82, 19);
            this.opt_ver_sin_asignar.TabIndex = 0;
            this.opt_ver_sin_asignar.TabStop = true;
            this.opt_ver_sin_asignar.Text = "Sin Asignar";
            this.tooltip.SetToolTip(this.opt_ver_sin_asignar, "Muestra actividades de mantención sin asignación de responsables\r\nFiltra por Secc" +
        "ión y Año de ");
            this.opt_ver_sin_asignar.UseVisualStyleBackColor = true;
            this.opt_ver_sin_asignar.Click += new System.EventHandler(this.opt_ver_sin_asignar_Click);
            // 
            // dat_ver
            // 
            this.dat_ver.AllowUserToAddRows = false;
            this.dat_ver.AllowUserToDeleteRows = false;
            this.dat_ver.AllowUserToResizeColumns = false;
            this.dat_ver.AllowUserToResizeRows = false;
            this.dat_ver.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dat_ver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_ver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_solicitud,
            this.nombre_seccion,
            this.ftermino,
            this.flimite});
            this.dat_ver.Location = new System.Drawing.Point(681, 207);
            this.dat_ver.Name = "dat_ver";
            this.dat_ver.ReadOnly = true;
            this.dat_ver.RowHeadersVisible = false;
            this.dat_ver.Size = new System.Drawing.Size(299, 347);
            this.dat_ver.TabIndex = 46;
            this.dat_ver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_ver_CellClick);
            // 
            // id_solicitud
            // 
            this.id_solicitud.HeaderText = "#";
            this.id_solicitud.Name = "id_solicitud";
            this.id_solicitud.ReadOnly = true;
            this.id_solicitud.Width = 30;
            // 
            // nombre_seccion
            // 
            this.nombre_seccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_seccion.HeaderText = "Sección";
            this.nombre_seccion.Name = "nombre_seccion";
            this.nombre_seccion.ReadOnly = true;
            // 
            // ftermino
            // 
            this.ftermino.HeaderText = "Término";
            this.ftermino.Name = "ftermino";
            this.ftermino.ReadOnly = true;
            this.ftermino.Width = 70;
            // 
            // flimite
            // 
            this.flimite.HeaderText = "Límite";
            this.flimite.Name = "flimite";
            this.flimite.ReadOnly = true;
            this.flimite.Width = 70;
            // 
            // calendario
            // 
            this.calendario.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendario.Location = new System.Drawing.Point(985, 9);
            this.calendario.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.calendario.Name = "calendario";
            this.calendario.ShowWeekNumbers = true;
            this.calendario.TabIndex = 47;
            // 
            // txt_folio
            // 
            this.txt_folio.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_folio.Location = new System.Drawing.Point(123, 35);
            this.txt_folio.MaxLength = 5;
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(82, 23);
            this.txt_folio.TabIndex = 1;
            this.txt_folio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_folio_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "N° Folio";
            // 
            // cmd_asignar_articulos
            // 
            this.cmd_asignar_articulos.BackColor = System.Drawing.Color.Snow;
            this.cmd_asignar_articulos.Enabled = false;
            this.cmd_asignar_articulos.FlatAppearance.BorderSize = 0;
            this.cmd_asignar_articulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_asignar_articulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_asignar_articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_asignar_articulos.Image = global::MantencionCLA.Properties.Resources.Gnome_Preferences_System_48px;
            this.cmd_asignar_articulos.Location = new System.Drawing.Point(616, 207);
            this.cmd_asignar_articulos.Name = "cmd_asignar_articulos";
            this.cmd_asignar_articulos.Size = new System.Drawing.Size(60, 60);
            this.cmd_asignar_articulos.TabIndex = 43;
            this.cmd_asignar_articulos.Tag = "Limpiar los campos";
            this.cmd_asignar_articulos.UseVisualStyleBackColor = false;
            this.cmd_asignar_articulos.Click += new System.EventHandler(this.cmd_asignar_articulos_Click);
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.BackColor = System.Drawing.Color.Snow;
            this.cmd_limpiar.FlatAppearance.BorderSize = 0;
            this.cmd_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_limpiar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Clear_48px;
            this.cmd_limpiar.Location = new System.Drawing.Point(616, 141);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(60, 60);
            this.cmd_limpiar.TabIndex = 42;
            this.cmd_limpiar.Tag = "Limpiar los campos";
            this.cmd_limpiar.UseVisualStyleBackColor = false;
            this.cmd_limpiar.Click += new System.EventHandler(this.cmd_limpiar_Click);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.BackColor = System.Drawing.Color.Snow;
            this.cmd_eliminar.FlatAppearance.BorderSize = 0;
            this.cmd_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_eliminar.Image = global::MantencionCLA.Properties.Resources.Gnome_Edit_Delete_48px;
            this.cmd_eliminar.Location = new System.Drawing.Point(616, 75);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(60, 60);
            this.cmd_eliminar.TabIndex = 41;
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
            this.cmd_insertar.Location = new System.Drawing.Point(616, 9);
            this.cmd_insertar.Name = "cmd_insertar";
            this.cmd_insertar.Size = new System.Drawing.Size(60, 60);
            this.cmd_insertar.TabIndex = 40;
            this.cmd_insertar.Tag = "";
            this.cmd_insertar.UseVisualStyleBackColor = false;
            this.cmd_insertar.Click += new System.EventHandler(this.cmd_insertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° de Solicitud";
            // 
            // frm_mantencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1205, 558);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.dat_ver);
            this.Controls.Add(this.fra_filtros);
            this.Controls.Add(this.dtp_fsolicitud);
            this.Controls.Add(this.cmd_asignar_articulos);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_insertar);
            this.Controls.Add(this.dat_observaciones);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmb_linea);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_maquina);
            this.Controls.Add(this.cmb_seccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_clasificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_solicitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.txt_folio);
            this.Controls.Add(this.txt_solicitud);
            this.Controls.Add(this.lbl_factual);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mantencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de Actividad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mantencion_FormClosing);
            this.Load += new System.EventHandler(this.frm_mantencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_observaciones)).EndInit();
            this.fra_filtros.ResumeLayout(false);
            this.fra_anio.ResumeLayout(false);
            this.fra_anio.PerformLayout();
            this.fra_seccion.ResumeLayout(false);
            this.fra_seccion.PerformLayout();
            this.fra_opciones.ResumeLayout(false);
            this.fra_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_factual;
        private System.Windows.Forms.TextBox txt_solicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_solicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_linea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_maquina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_finalizado;
        private System.Windows.Forms.RadioButton opt_pendiente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_responsable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton opt_no;
        private System.Windows.Forms.RadioButton opt_si;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_clasificacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dat_observaciones;
        private System.Windows.Forms.CheckedListBox lst_ayudante;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_insertar;
        private System.Windows.Forms.DateTimePicker dtp_fsolicitud;
        private System.Windows.Forms.DateTimePicker dtp_freal;
        private System.Windows.Forms.DateTimePicker dtp_ftermino;
        private System.Windows.Forms.DateTimePicker dtp_finicio;
        private System.Windows.Forms.DateTimePicker dtp_flimite;
        private System.Windows.Forms.GroupBox fra_filtros;
        private System.Windows.Forms.Button cmd_buscar;
        private System.Windows.Forms.GroupBox fra_anio;
        private System.Windows.Forms.TextBox txt_ver_anio;
        private System.Windows.Forms.RadioButton opt_ver_anio_anio;
        private System.Windows.Forms.RadioButton opt_ver_anio_todos;
        private System.Windows.Forms.GroupBox fra_seccion;
        private System.Windows.Forms.ComboBox cmb_ver_seccion;
        private System.Windows.Forms.RadioButton opt_ver_sec_una;
        private System.Windows.Forms.RadioButton opt_ver_sec_todas;
        private System.Windows.Forms.GroupBox fra_opciones;
        private System.Windows.Forms.RadioButton opt_ver_finalizadas;
        private System.Windows.Forms.RadioButton opt_ver_vencidas;
        private System.Windows.Forms.RadioButton opt_ver_por_vencer;
        private System.Windows.Forms.RadioButton opt_ver_pendientes;
        private System.Windows.Forms.RadioButton opt_ver_sin_asignar;
        private System.Windows.Forms.DataGridView dat_ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn flimite;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton opt_ver_solicitud;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button cmd_asignar_articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_det_mantencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    }
}