namespace MantencionCLA
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnu_mant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_lugares = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_lugares_secciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_lugares_lineas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_lugares_maquinas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_personas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_personas_mecanicos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_personas_cargos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_personas_solicitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_partes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_partes_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_partes_tipos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_clasificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_divisor = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_mant_especiales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_especiales_asignacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_especiales_estado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_especiales_actividad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_especiales_permiso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_mant_especiales_control = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ingreso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ingreso_actividades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ingreso_mantencion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ingreso_divisor = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_ingreso_administrador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ingreso_administrador_cambio_estado = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaciónDeActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_reportes_buscar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_reportes_buscar_solicitudes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_reportes_buscar_actividades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_reportes_divisor = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_reportes_eliminadas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_reportes_folios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ventanas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cerrar_sesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mant,
            this.mnu_ingreso,
            this.mnu_reportes,
            this.mnu_ventanas,
            this.mnu_cerrar_sesion,
            this.mnu_salir});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.MdiWindowListItem = this.mnu_ventanas;
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(691, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnu_mant
            // 
            this.mnu_mant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mant_lugares,
            this.mnu_mant_personas,
            this.mnu_mant_partes,
            this.mnu_mant_clasificacion,
            this.mnu_mant_usuarios,
            this.mnu_mant_divisor,
            this.mnu_mant_especiales});
            this.mnu_mant.Name = "mnu_mant";
            this.mnu_mant.Size = new System.Drawing.Size(95, 20);
            this.mnu_mant.Text = "&Mantenedores";
            // 
            // mnu_mant_lugares
            // 
            this.mnu_mant_lugares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mant_lugares_secciones,
            this.mnu_mant_lugares_lineas,
            this.mnu_mant_lugares_maquinas});
            this.mnu_mant_lugares.Name = "mnu_mant_lugares";
            this.mnu_mant_lugares.Size = new System.Drawing.Size(224, 22);
            this.mnu_mant_lugares.Text = "Lugares y Equipos";
            // 
            // mnu_mant_lugares_secciones
            // 
            this.mnu_mant_lugares_secciones.Name = "mnu_mant_lugares_secciones";
            this.mnu_mant_lugares_secciones.Size = new System.Drawing.Size(126, 22);
            this.mnu_mant_lugares_secciones.Text = "Secciones";
            this.mnu_mant_lugares_secciones.Click += new System.EventHandler(this.mnu_mant_lugares_secciones_Click);
            // 
            // mnu_mant_lugares_lineas
            // 
            this.mnu_mant_lugares_lineas.Name = "mnu_mant_lugares_lineas";
            this.mnu_mant_lugares_lineas.Size = new System.Drawing.Size(126, 22);
            this.mnu_mant_lugares_lineas.Text = "Lineas";
            this.mnu_mant_lugares_lineas.Click += new System.EventHandler(this.mnu_mant_lugares_lineas_Click);
            // 
            // mnu_mant_lugares_maquinas
            // 
            this.mnu_mant_lugares_maquinas.Name = "mnu_mant_lugares_maquinas";
            this.mnu_mant_lugares_maquinas.Size = new System.Drawing.Size(126, 22);
            this.mnu_mant_lugares_maquinas.Text = "Máquinas";
            this.mnu_mant_lugares_maquinas.Click += new System.EventHandler(this.mnu_mant_lugares_maquinas_Click);
            // 
            // mnu_mant_personas
            // 
            this.mnu_mant_personas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mant_personas_mecanicos,
            this.mnu_mant_personas_cargos,
            this.mnu_mant_personas_solicitantes});
            this.mnu_mant_personas.Name = "mnu_mant_personas";
            this.mnu_mant_personas.Size = new System.Drawing.Size(224, 22);
            this.mnu_mant_personas.Text = "Personas";
            // 
            // mnu_mant_personas_mecanicos
            // 
            this.mnu_mant_personas_mecanicos.Name = "mnu_mant_personas_mecanicos";
            this.mnu_mant_personas_mecanicos.Size = new System.Drawing.Size(214, 22);
            this.mnu_mant_personas_mecanicos.Text = "Mecánicos y Responsables";
            this.mnu_mant_personas_mecanicos.Click += new System.EventHandler(this.mnu_mant_personas_mecanicos_Click);
            // 
            // mnu_mant_personas_cargos
            // 
            this.mnu_mant_personas_cargos.Name = "mnu_mant_personas_cargos";
            this.mnu_mant_personas_cargos.Size = new System.Drawing.Size(214, 22);
            this.mnu_mant_personas_cargos.Text = "Cargos";
            this.mnu_mant_personas_cargos.Click += new System.EventHandler(this.mnu_mant_personas_cargos_Click);
            // 
            // mnu_mant_personas_solicitantes
            // 
            this.mnu_mant_personas_solicitantes.Name = "mnu_mant_personas_solicitantes";
            this.mnu_mant_personas_solicitantes.Size = new System.Drawing.Size(214, 22);
            this.mnu_mant_personas_solicitantes.Text = "Solicitantes";
            this.mnu_mant_personas_solicitantes.Click += new System.EventHandler(this.mnu_mant_personas_solicitantes_Click);
            // 
            // mnu_mant_partes
            // 
            this.mnu_mant_partes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mant_partes_articulos,
            this.mnu_mant_partes_tipos});
            this.mnu_mant_partes.Name = "mnu_mant_partes";
            this.mnu_mant_partes.Size = new System.Drawing.Size(224, 22);
            this.mnu_mant_partes.Text = "Partes y Piezas";
            // 
            // mnu_mant_partes_articulos
            // 
            this.mnu_mant_partes_articulos.Name = "mnu_mant_partes_articulos";
            this.mnu_mant_partes_articulos.Size = new System.Drawing.Size(169, 22);
            this.mnu_mant_partes_articulos.Text = "Articulos";
            this.mnu_mant_partes_articulos.Click += new System.EventHandler(this.mnu_mant_partes_articulos_Click);
            // 
            // mnu_mant_partes_tipos
            // 
            this.mnu_mant_partes_tipos.Name = "mnu_mant_partes_tipos";
            this.mnu_mant_partes_tipos.Size = new System.Drawing.Size(169, 22);
            this.mnu_mant_partes_tipos.Text = "Tipos de Articulos";
            this.mnu_mant_partes_tipos.Click += new System.EventHandler(this.mnu_mant_partes_tipos_Click);
            // 
            // mnu_mant_clasificacion
            // 
            this.mnu_mant_clasificacion.Name = "mnu_mant_clasificacion";
            this.mnu_mant_clasificacion.Size = new System.Drawing.Size(224, 22);
            this.mnu_mant_clasificacion.Text = "Clasificación de Mantención";
            this.mnu_mant_clasificacion.Click += new System.EventHandler(this.mnu_mant_clasificacion_Click);
            // 
            // mnu_mant_usuarios
            // 
            this.mnu_mant_usuarios.Name = "mnu_mant_usuarios";
            this.mnu_mant_usuarios.Size = new System.Drawing.Size(224, 22);
            this.mnu_mant_usuarios.Text = "Usuarios";
            this.mnu_mant_usuarios.Click += new System.EventHandler(this.mnu_mant_usuarios_Click);
            // 
            // mnu_mant_divisor
            // 
            this.mnu_mant_divisor.Name = "mnu_mant_divisor";
            this.mnu_mant_divisor.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_mant_especiales
            // 
            this.mnu_mant_especiales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mant_especiales_asignacion,
            this.mnu_mant_especiales_estado,
            this.mnu_mant_especiales_actividad,
            this.mnu_mant_especiales_permiso,
            this.mnu_mant_especiales_control});
            this.mnu_mant_especiales.Name = "mnu_mant_especiales";
            this.mnu_mant_especiales.Size = new System.Drawing.Size(224, 22);
            this.mnu_mant_especiales.Text = "Especiales";
            // 
            // mnu_mant_especiales_asignacion
            // 
            this.mnu_mant_especiales_asignacion.Name = "mnu_mant_especiales_asignacion";
            this.mnu_mant_especiales_asignacion.Size = new System.Drawing.Size(241, 22);
            this.mnu_mant_especiales_asignacion.Text = "Asignación";
            this.mnu_mant_especiales_asignacion.Click += new System.EventHandler(this.mnu_mant_especiales_asignacion_Click);
            // 
            // mnu_mant_especiales_estado
            // 
            this.mnu_mant_especiales_estado.Name = "mnu_mant_especiales_estado";
            this.mnu_mant_especiales_estado.Size = new System.Drawing.Size(241, 22);
            this.mnu_mant_especiales_estado.Text = "Estado Usuarios o Responsables";
            this.mnu_mant_especiales_estado.Click += new System.EventHandler(this.mnu_mant_especiales_estado_Click);
            // 
            // mnu_mant_especiales_actividad
            // 
            this.mnu_mant_especiales_actividad.Name = "mnu_mant_especiales_actividad";
            this.mnu_mant_especiales_actividad.Size = new System.Drawing.Size(241, 22);
            this.mnu_mant_especiales_actividad.Text = "Estado Mantención";
            this.mnu_mant_especiales_actividad.Click += new System.EventHandler(this.mnu_mant_especiales_mantencion_Click);
            // 
            // mnu_mant_especiales_permiso
            // 
            this.mnu_mant_especiales_permiso.Name = "mnu_mant_especiales_permiso";
            this.mnu_mant_especiales_permiso.Size = new System.Drawing.Size(241, 22);
            this.mnu_mant_especiales_permiso.Text = "Tipos de Permiso";
            this.mnu_mant_especiales_permiso.Click += new System.EventHandler(this.mnu_mant_especiales_permiso_Click);
            // 
            // mnu_mant_especiales_control
            // 
            this.mnu_mant_especiales_control.Name = "mnu_mant_especiales_control";
            this.mnu_mant_especiales_control.Size = new System.Drawing.Size(241, 22);
            this.mnu_mant_especiales_control.Text = "Tipo Control";
            this.mnu_mant_especiales_control.Click += new System.EventHandler(this.mnu_mant_especiales_control_Click);
            // 
            // mnu_ingreso
            // 
            this.mnu_ingreso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ingreso_actividades,
            this.mnu_ingreso_mantencion,
            this.mnu_ingreso_divisor,
            this.mnu_ingreso_administrador});
            this.mnu_ingreso.Name = "mnu_ingreso";
            this.mnu_ingreso.Size = new System.Drawing.Size(58, 20);
            this.mnu_ingreso.Text = "&Ingreso";
            // 
            // mnu_ingreso_actividades
            // 
            this.mnu_ingreso_actividades.Name = "mnu_ingreso_actividades";
            this.mnu_ingreso_actividades.Size = new System.Drawing.Size(171, 22);
            this.mnu_ingreso_actividades.Text = "Solicitud";
            this.mnu_ingreso_actividades.Click += new System.EventHandler(this.mnu_ingreso_actividades_Click);
            // 
            // mnu_ingreso_mantencion
            // 
            this.mnu_ingreso_mantencion.Name = "mnu_ingreso_mantencion";
            this.mnu_ingreso_mantencion.Size = new System.Drawing.Size(171, 22);
            this.mnu_ingreso_mantencion.Text = "Ficha de Actividad";
            this.mnu_ingreso_mantencion.Click += new System.EventHandler(this.mnu_ingreso_mantencion_Click);
            // 
            // mnu_ingreso_divisor
            // 
            this.mnu_ingreso_divisor.Name = "mnu_ingreso_divisor";
            this.mnu_ingreso_divisor.Size = new System.Drawing.Size(168, 6);
            // 
            // mnu_ingreso_administrador
            // 
            this.mnu_ingreso_administrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ingreso_administrador_cambio_estado,
            this.eliminaciónDeActividadesToolStripMenuItem});
            this.mnu_ingreso_administrador.Name = "mnu_ingreso_administrador";
            this.mnu_ingreso_administrador.Size = new System.Drawing.Size(171, 22);
            this.mnu_ingreso_administrador.Text = "Administrador";
            // 
            // mnu_ingreso_administrador_cambio_estado
            // 
            this.mnu_ingreso_administrador_cambio_estado.Name = "mnu_ingreso_administrador_cambio_estado";
            this.mnu_ingreso_administrador_cambio_estado.Size = new System.Drawing.Size(216, 22);
            this.mnu_ingreso_administrador_cambio_estado.Text = "Cambio de Estado";
            this.mnu_ingreso_administrador_cambio_estado.Click += new System.EventHandler(this.mnu_ingreso_administrador_cambio_estado_Click);
            // 
            // eliminaciónDeActividadesToolStripMenuItem
            // 
            this.eliminaciónDeActividadesToolStripMenuItem.Name = "eliminaciónDeActividadesToolStripMenuItem";
            this.eliminaciónDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.eliminaciónDeActividadesToolStripMenuItem.Text = "Eliminación de Actividades";
            this.eliminaciónDeActividadesToolStripMenuItem.Visible = false;
            // 
            // mnu_reportes
            // 
            this.mnu_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_reportes_buscar,
            this.mnu_reportes_divisor,
            this.mnu_reportes_eliminadas,
            this.mnu_reportes_folios});
            this.mnu_reportes.Name = "mnu_reportes";
            this.mnu_reportes.Size = new System.Drawing.Size(65, 20);
            this.mnu_reportes.Text = "Reportes";
            // 
            // mnu_reportes_buscar
            // 
            this.mnu_reportes_buscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_reportes_buscar_solicitudes,
            this.mnu_reportes_buscar_actividades});
            this.mnu_reportes_buscar.Name = "mnu_reportes_buscar";
            this.mnu_reportes_buscar.Size = new System.Drawing.Size(195, 22);
            this.mnu_reportes_buscar.Text = "Buscar Reporte";
            // 
            // mnu_reportes_buscar_solicitudes
            // 
            this.mnu_reportes_buscar_solicitudes.Name = "mnu_reportes_buscar_solicitudes";
            this.mnu_reportes_buscar_solicitudes.Size = new System.Drawing.Size(272, 22);
            this.mnu_reportes_buscar_solicitudes.Text = "Solicitudes por Solicitante";
            this.mnu_reportes_buscar_solicitudes.Click += new System.EventHandler(this.mnu_reportes_buscar_solicitudes_Click);
            // 
            // mnu_reportes_buscar_actividades
            // 
            this.mnu_reportes_buscar_actividades.Name = "mnu_reportes_buscar_actividades";
            this.mnu_reportes_buscar_actividades.Size = new System.Drawing.Size(272, 22);
            this.mnu_reportes_buscar_actividades.Text = "Actividades de Mantención / Ranking";
            this.mnu_reportes_buscar_actividades.Click += new System.EventHandler(this.mnu_reportes_buscar_actividades_Click);
            // 
            // mnu_reportes_divisor
            // 
            this.mnu_reportes_divisor.Name = "mnu_reportes_divisor";
            this.mnu_reportes_divisor.Size = new System.Drawing.Size(192, 6);
            this.mnu_reportes_divisor.Visible = false;
            // 
            // mnu_reportes_eliminadas
            // 
            this.mnu_reportes_eliminadas.Name = "mnu_reportes_eliminadas";
            this.mnu_reportes_eliminadas.Size = new System.Drawing.Size(195, 22);
            this.mnu_reportes_eliminadas.Text = "Actividades eliminadas";
            this.mnu_reportes_eliminadas.Visible = false;
            // 
            // mnu_reportes_folios
            // 
            this.mnu_reportes_folios.Name = "mnu_reportes_folios";
            this.mnu_reportes_folios.Size = new System.Drawing.Size(195, 22);
            this.mnu_reportes_folios.Text = "Control de cambios";
            this.mnu_reportes_folios.Visible = false;
            // 
            // mnu_ventanas
            // 
            this.mnu_ventanas.Name = "mnu_ventanas";
            this.mnu_ventanas.Size = new System.Drawing.Size(66, 20);
            this.mnu_ventanas.Text = "&Ventanas";
            // 
            // mnu_cerrar_sesion
            // 
            this.mnu_cerrar_sesion.Name = "mnu_cerrar_sesion";
            this.mnu_cerrar_sesion.Size = new System.Drawing.Size(88, 20);
            this.mnu_cerrar_sesion.Text = "&Cerrar Sesión";
            this.mnu_cerrar_sesion.Click += new System.EventHandler(this.mnu_cerrar_sesion_Click);
            // 
            // mnu_salir
            // 
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(41, 20);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(691, 367);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu;
            this.Name = "frm_principal";
            this.Text = "Programa de Mantenimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_principal_FormClosing);
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_clasificacion;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_usuarios;
        private System.Windows.Forms.ToolStripMenuItem mnu_ingreso;
        private System.Windows.Forms.ToolStripMenuItem mnu_ingreso_actividades;
        private System.Windows.Forms.ToolStripMenuItem mnu_ingreso_mantencion;
        private System.Windows.Forms.ToolStripMenuItem mnu_reportes;
        private System.Windows.Forms.ToolStripMenuItem mnu_reportes_buscar;
        private System.Windows.Forms.ToolStripSeparator mnu_reportes_divisor;
        private System.Windows.Forms.ToolStripMenuItem mnu_reportes_eliminadas;
        private System.Windows.Forms.ToolStripMenuItem mnu_reportes_folios;
        private System.Windows.Forms.ToolStripMenuItem mnu_ventanas;
        private System.Windows.Forms.ToolStripMenuItem mnu_salir;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_especiales;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_especiales_asignacion;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_especiales_estado;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_especiales_permiso;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_especiales_actividad;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_lugares;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_lugares_secciones;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_lugares_lineas;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_lugares_maquinas;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_personas;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_personas_mecanicos;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_personas_solicitantes;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_partes;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_partes_articulos;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_partes_tipos;
        private System.Windows.Forms.ToolStripMenuItem mnu_cerrar_sesion;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_personas_cargos;
        private System.Windows.Forms.ToolStripMenuItem mnu_mant_especiales_control;
        private System.Windows.Forms.ToolStripSeparator mnu_mant_divisor;
        private System.Windows.Forms.ToolStripSeparator mnu_ingreso_divisor;
        private System.Windows.Forms.ToolStripMenuItem mnu_ingreso_administrador;
        private System.Windows.Forms.ToolStripMenuItem mnu_ingreso_administrador_cambio_estado;
        private System.Windows.Forms.ToolStripMenuItem mnu_reportes_buscar_solicitudes;
        private System.Windows.Forms.ToolStripMenuItem mnu_reportes_buscar_actividades;
        private System.Windows.Forms.ToolStripMenuItem eliminaciónDeActividadesToolStripMenuItem;
    }
}

