using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantencionCLA
{
    class util
    {
        private static frm_login inicio;
        private static frm_principal menu;
        private static frm_activa_usuario activar;
        private static frm_solicitud solicitud;
        private static frm_mant_usuarios usuarios;
        private static frm_mant_basico asignacion;
        private static frm_mant_basico estado;
        private static frm_mant_basico tipo_articulo;
        private static frm_mant_basico permiso;
        private static frm_mant_basico clasificacion;
        private static frm_mant_basico solicitante;
        private static frm_mant_basico seccion;
        private static frm_mant_basico estado_mantencion;
        private static frm_mant_basico cargo;
        private static frm_mant_basico fecha;
        private static frm_mant_basico control;
        private static frm_mant_foraneo maquina;
        private static frm_mant_foraneo linea;
        private static frm_mant_responsable responsable;
        private static frm_mant_articulos articulos;
        private static frm_mantencion mantencion;
        private static frm_especial1 especial1;
        private static frm_listar_solicitudes solicitudes;
        private static frm_rep_buscar actividades;

        public static frm_login getInicio()
        {
            return inicio;
        }

        public static void setInicio(frm_login inicio)
        {
            util.inicio = inicio;
        }

        public static frm_principal getMenu()
        {
            return menu;
        }

        public static void setMenu(frm_principal menu)
        {
            util.menu = menu;
        }

        public static frm_activa_usuario getActivar()
        {
            return activar;
        }

        public static void setActivar(frm_activa_usuario activar)
        {
            util.activar = activar;
        }

        public static frm_solicitud getSolicitud()
        {
            return solicitud;
        }

        public static void setSolicitud(frm_solicitud solicitud)
        {
            util.solicitud = solicitud;
        }

        public static frm_mant_usuarios getUsuarios()
        {
            return usuarios;
        }

        public static void setUsuarios(frm_mant_usuarios usuarios)
        {
            util.usuarios = usuarios;
        }

        public static frm_mant_basico getAsignacion()
        {
            return asignacion;
        }

        public static void setAsignacion(frm_mant_basico asignacion)
        {
            util.asignacion = asignacion;
        }

        public static frm_mant_basico getEstado()
        {
            return estado;
        }

        public static void setEstado(frm_mant_basico estado)
        {
            util.estado = estado;
        }

        public static frm_mant_basico getTipoArticulo()
        {
            return tipo_articulo;
        }

        public static void setTipoArticulo(frm_mant_basico tipo_articulo)
        {
            util.tipo_articulo = tipo_articulo;
        }

        public static frm_mant_basico getPermiso()
        {
            return permiso;
        }

        public static void setPermiso(frm_mant_basico permiso)
        {
            util.permiso = permiso;
        }

        public static frm_mant_basico getClasificacion()
        {
            return clasificacion;
        }

        public static void setClasificacion(frm_mant_basico clasificacion)
        {
            util.clasificacion = clasificacion;
        }

        public static frm_mant_basico getSolicitante()
        {
            return solicitante;
        }

        public static void setSolicitante(frm_mant_basico solicitante)
        {
            util.solicitante = solicitante;
        }

        public static frm_mant_basico getSeccion()
        {
            return seccion;
        }

        public static void setSeccion(frm_mant_basico seccion)
        {
            util.seccion = seccion;
        }

        public static frm_mant_basico getEstadoMantencion()
        {
            return estado_mantencion;
        }

        public static void setEstadoMantencion(frm_mant_basico estado_mantencion)
        {
            util.estado_mantencion = estado_mantencion;
        }

        public static frm_mant_basico getCargo()
        {
            return cargo;
        }

        public static void setCargo(frm_mant_basico cargo)
        {
            util.cargo = cargo;
        }

        public static frm_mant_basico getFecha()
        {
            return fecha;
        }

        public static void setFecha(frm_mant_basico fecha)
        {
            util.fecha = fecha;
        }

        public static frm_mant_basico getControl()
        {
            return control;
        }

        public static void setControl(frm_mant_basico control)
        {
            util.control = control;
        }

        public static frm_mant_foraneo getMaquina()
        {
            return maquina;
        }

        public static void setMaquina(frm_mant_foraneo maquina)
        {
            util.maquina = maquina;
        }

        public static frm_mant_foraneo getLinea()
        {
            return linea;
        }

        public static void setLinea(frm_mant_foraneo linea)
        {
            util.linea = linea;
        }

        public static frm_mant_responsable getResponsable()
        {
            return responsable;
        }

        public static void setResponsable(frm_mant_responsable responsable)
        {
            util.responsable = responsable;
        }

        public static frm_mant_articulos getArticulos()
        {
            return articulos;
        }

        public static void setArticulos(frm_mant_articulos articulos)
        {
            util.articulos = articulos;
        }

        public static frm_mantencion getMantencion()
        {
            return mantencion;
        }

        public static void setMantencion(frm_mantencion mantencion)
        {
            util.mantencion = mantencion;
        }

        public static frm_especial1 getEspecial1()
        {
            return especial1;
        }

        public static void setEspecial1(frm_especial1 especial1)
        {
            util.especial1 = especial1;
        }

        public static frm_listar_solicitudes getSolicitudes()
        {
            return solicitudes;
        }

        public static void setSolicitudes(frm_listar_solicitudes solicitudes)
        {
            util.solicitudes = solicitudes;
        }

        public static frm_rep_buscar getActividades()
        {
            return util.actividades;
        }

        public static void setActividades(frm_rep_buscar actividades)
        {
            util.actividades = actividades;
        }
    }
}
