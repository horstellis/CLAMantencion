using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantencionCLA
{
    public partial class frm_principal : Form
    {
        private auxiliar aux = new auxiliar();
        private int id_permiso = 0;
        private String msg_error = "";

        public frm_principal()
        {
            InitializeComponent();
        }

        public void setMsgError(String msg_error)
        {
            this.msg_error = msg_error;
        }

        public void setIdPermiso(int id_permiso)
        {
            this.id_permiso = id_permiso;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aux.dialogo("¿Desea salir del sistema?", this.Text, 1) == DialogResult.Yes)
            {
                util.getInicio().Dispose();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            frm_mant_usuarios form = new frm_mant_usuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            if (id_permiso == 2)
            {
                mnu_mant_especiales.Visible = false;
                mnu_mant_usuarios.Visible = false;
            }
            else if (id_permiso == 3)
            {
                mnu_mant.Visible = false;
                mnu_ingreso_mantencion.Visible = false;
                mnu_reportes_eliminadas.Visible = false;
                mnu_reportes_folios.Visible = false;
                mnu_reportes_generar.Visible = false;
                mnu_reportes_divisor.Visible = false;
            }
        }

        private void mnu_mant_especiales_asignacion_Click(object sender, EventArgs e)
        {
            if (util.getAsignacion() == null)
            {
                util.setMenu(this);
                util.setAsignacion(new frm_mant_basico());
                util.getAsignacion().MdiParent = this;
                util.getAsignacion().setNombreTabla("asignacion");
                util.getAsignacion().Show();
                if (!msg_error.Equals(""))
                {
                    util.getAsignacion().Dispose();
                    util.setAsignacion(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getAsignacion().Activate();
            }
        }

        private void mnu_mant_especiales_estado_Click(object sender, EventArgs e)
        {
            if (util.getEstado() == null)
            {
                util.setMenu(this);
                util.setEstado(new frm_mant_basico());
                util.getEstado().MdiParent = this;
                util.getEstado().setNombreTabla("estado");
                util.getEstado().Show();
                if (!msg_error.Equals(""))
                {
                    util.getEstado().Dispose();
                    util.setEstado(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getEstado().Activate();
            }
        }

        private void mnu_mant_especiales_mantencion_Click(object sender, EventArgs e)
        {
            if (util.getEstadoMantencion() == null)
            {
                util.setMenu(this);
                util.setEstadoMantencion(new frm_mant_basico());
                util.getEstadoMantencion().MdiParent = this;
                util.getEstadoMantencion().setNombreTabla("estado");
                util.getEstadoMantencion().Show();
                if (!msg_error.Equals(""))
                {
                    util.getEstadoMantencion().Dispose();
                    util.setEstadoMantencion(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getEstadoMantencion().Activate();
            }
        }

        private void mnu_mant_especiales_permiso_Click(object sender, EventArgs e)
        {
            if (util.getPermiso() == null)
            {
                util.setMenu(this);
                util.setPermiso(new frm_mant_basico());
                util.getPermiso().MdiParent = this;
                util.getPermiso().setNombreTabla("permiso");
                util.getPermiso().Show();
                if (!msg_error.Equals(""))
                {
                    util.getPermiso().Dispose();
                    util.setPermiso(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getPermiso().Activate();
            }
        }

        private void mnu_mant_personas_solicitantes_Click(object sender, EventArgs e)
        {
            if (util.getSolicitante() == null)
            {
                util.setMenu(this);
                util.setSolicitante(new frm_mant_basico());
                util.getSolicitante().MdiParent = this;
                util.getSolicitante().setNombreTabla("solicitante");
                util.getSolicitante().Show();
                if (!msg_error.Equals(""))
                {
                    util.getSolicitante().Dispose();
                    util.setSolicitante(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getSolicitante().Activate();
            }
        }

        private void mnu_mant_partes_tipos_Click(object sender, EventArgs e)
        {
            if (util.getTipoArticulo() == null)
            {
                util.setMenu(this);
                util.setTipoArticulo(new frm_mant_basico());
                util.getTipoArticulo().MdiParent = this;
                util.getTipoArticulo().setNombreTabla("tipo_articulo");
                util.getTipoArticulo().Show();
                if (!msg_error.Equals(""))
                {
                    util.getTipoArticulo().Dispose();
                    util.setTipoArticulo(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getTipoArticulo().Activate();
            }
        }

        private void mnu_mant_lugares_secciones_Click(object sender, EventArgs e)
        {
            if (util.getSeccion() == null)
            {
                util.setMenu(this);
                util.setSeccion(new frm_mant_basico());
                util.getSeccion().MdiParent = this;
                util.getSeccion().setNombreTabla("seccion");
                util.getSeccion().Show();
                if (!msg_error.Equals(""))
                {
                    util.getSeccion().Dispose();
                    util.setSeccion(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getSeccion().Activate();
            }
        }

        private void mnu_mant_clasificacion_Click(object sender, EventArgs e)
        {
            if (util.getClasificacion() == null)
            {
                util.setMenu(this);
                util.setClasificacion(new frm_mant_basico());
                util.getClasificacion().MdiParent = this;
                util.getClasificacion().setNombreTabla("clasificacion");
                util.getClasificacion().Show();
                if (!msg_error.Equals(""))
                {
                    util.getClasificacion().Dispose();
                    util.setClasificacion(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getClasificacion().Activate();
            }
        }

        private void mnu_mant_lugares_lineas_Click(object sender, EventArgs e)
        {
            if (util.getLinea() == null)
            {
                util.setMenu(this);
                util.setLinea(new frm_mant_foraneo());
                util.getLinea().MdiParent = this;
                util.getLinea().setNombreTablas("linea","seccion");
                util.getLinea().Show();
                if (!msg_error.Equals(""))
                {
                    util.getLinea().Dispose();
                    util.setLinea(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getLinea().Activate();
            }
        }

        private void mnu_mant_lugares_maquinas_Click(object sender, EventArgs e)
        {
            if (util.getMaquina() == null)
            {
                util.setMenu(this);
                util.setMaquina(new frm_mant_foraneo());
                util.getMaquina().MdiParent = this;
                util.getMaquina().setNombreTablas("maquina", "seccion");
                util.getMaquina().Show();
                if (!msg_error.Equals(""))
                {
                    util.getMaquina().Dispose();
                    util.setMaquina(null);
                    aux.dialogo("Error al intentar abrir ventana\nFavor contactese con soporte e informe:\n" + msg_error, this.Text, 3);
                    msg_error = "";
                }
            }
            else
            {
                util.getMaquina().Activate();
            }
        }

        private void mnu_ingreso_actividades_Click(object sender, EventArgs e)
        {
            if (util.getSolicitud() == null)
            {
                util.setMenu(this);
                util.setSolicitud(new frm_solicitud());
                util.getSolicitud().MdiParent = this;
                util.getSolicitud().Show();
            }
            else
            {
                util.getSolicitud().Activate();
            }
        }

        private void mnu_cerrar_sesion_Click(object sender, EventArgs e)
        {
            if (aux.dialogo("¿Desea cerrar sesión?", this.Text, 1) == DialogResult.Yes)
            {
                util.getInicio().Show();
                util.getInicio().reiniciar();
                this.Dispose();
            }
        }

        private void mnu_mant_personas_cargos_Click(object sender, EventArgs e)
        {
            if (util.getCargo() == null)
            {
                util.setMenu(this);
                util.setCargo(new frm_mant_basico());
                util.getCargo().MdiParent = this;
                util.getCargo().setNombreTabla("cargo");
                util.getCargo().Show();
            }
            else
            {
                util.getCargo().Activate();
            }
        }

        private void mnu_mant_personas_mecanicos_Click(object sender, EventArgs e)
        {
            if (util.getResponsable() == null)
            {
                util.setMenu(this);
                util.setResponsable(new frm_mant_responsable());
                util.getResponsable().MdiParent = this;
                util.getResponsable().Show();
            }
            else
            {
                util.getResponsable().Activate();
            }
        }

        private void mnu_mant_partes_articulos_Click(object sender, EventArgs e)
        {
            if (util.getArticulos() == null)
            {
                util.setMenu(this);
                util.setArticulos(new frm_mant_articulos());
                util.getArticulos().MdiParent = this;
                util.getArticulos().Show();
            }
            else
            {
                util.getArticulos().Activate();
            }
        }

    }
}
