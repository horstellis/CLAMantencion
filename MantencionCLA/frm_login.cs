using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MantencionCLA
{
    public partial class frm_login : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private int intentos = 3;
        public Boolean resultado = false;
        public frm_login()
        {
            InitializeComponent();
        }

        public void activar()
        {
            txt_password.Clear();
            txt_password.Focus();
        }

        public void reiniciar()
        {
            txt_usuario.Clear();
            txt_password.Clear();
            txt_usuario.Focus();
        }

        public String ver_usuario()
        {
            return txt_usuario.Text.Trim();
        }

        private Boolean valida_campos()
        {
            if (txt_usuario.Text.Trim().Equals(""))
            {
                aux.dialogo("Debe indicar usuario", this.Text, 3);
                txt_usuario.Focus();
                return false;
            }
            else if (txt_password.Text.Trim().Equals(""))
            {
                aux.dialogo("Debe indicar clave", this.Text, 3);
                txt_password.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                if (sql.verificar("SELECT * FROM usuarios WHERE usuario = '" + txt_usuario.Text.Trim() + "'"))
                {
                    SqlDataReader dr = sql.consulta("SELECT * FROM usuarios WHERE usuario = '" + txt_usuario.Text.Trim() + "'");
                    dr.Read();
                    //Pasa cada uno de los valores del DataReader a variables locales
                    String usuario = dr[0].ToString();
                    String clave = dr[1].ToString();
                    String nombre = dr[2].ToString();
                    int permiso = int.Parse(dr[3].ToString());
                    int estado = int.Parse(dr[4].ToString());
                    int intentos = int.Parse(dr[5].ToString());
                    if (estado == 1)
                    {
                        if (intentos < 3)
                        {
                            if (txt_password.Text.Trim().Equals(clave))
                            {
                                int exec = sql.ejecutar("UPDATE usuarios SET intentos_sesion = 0 WHERE usuario = '" + txt_usuario.Text.Trim() + "'");
                                if (exec > 0)
                                {
                                    aux.dialogo("Bienvenido " + nombre, this.Text, 2);
                                    util.setInicio(this);
                                    util.setMenu(new frm_principal());
                                    util.getMenu().setIdPermiso(permiso);
                                    util.getMenu().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    aux.dialogo("Error al procesar ingreso\nIntente nuevamente", this.Text, 3);
                                }
                            }
                            else
                            {
                                intentos++;
                                if (intentos < 3)
                                {
                                    int exec = sql.ejecutar("UPDATE usuarios SET intentos_sesion = " + intentos + " WHERE usuario = '" + txt_usuario.Text.Trim() + "'");
                                    if (exec > 0)
                                    {
                                        aux.dialogo("Clave incorrecta", this.Text, 3);
                                        txt_password.SelectAll();
                                        txt_password.Focus();
                                    }
                                    else
                                    {
                                        aux.dialogo("Error al procesar usuario, no se establecio intentos\nAvise de este error a un administrador.", this.Text, 3);
                                        this.Dispose();
                                    }
                                }
                                else
                                {
                                    int exec = sql.ejecutar("UPDATE usuarios SET id_estado = 3, intentos_sesion = 3 WHERE usuario = '" + txt_usuario.Text.Trim() + "'");
                                    if (exec > 0)
                                    {
                                        aux.dialogo(nombre + " su cuenta ha sido bloqueada\nHa superado el límite de intentos de sesión\nFavor comuniquese con un administrador", this.Text, 3);
                                        this.Dispose();
                                    }
                                    else
                                    {
                                        aux.dialogo("Error al procesar usuario, no se establecio intentos\nAvise de este error a un administrador.", this.Text, 3);
                                        this.Dispose();
                                    }
                                }
                            }
                        }
                    }
                    else if (estado == 2)
                    {
                        aux.dialogo("Usuario inactivo. Debe de activar su cuenta antes de continuar.", this.Text, 3);
                        util.setInicio(this);
                        util.setActivar(new frm_activa_usuario());
                        util.getActivar().setUsuarioActivo(usuario);
                        util.getActivar().Show();
                        this.Hide();

                    }
                    else if (estado == 3)
                    {
                        aux.dialogo("Usuario bloqueado. Contacte a un administrador.", this.Text, 3);
                        txt_usuario.Clear();
                        txt_password.Clear();
                        txt_usuario.Focus();
                    }

                }
                else
                {
                    aux.dialogo("Usuario no existe", this.Text, 3);
                    txt_usuario.Clear();
                    txt_password.Clear();
                    txt_usuario.Focus();
                }
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            aux.cambia_tecla(e);
            e.Handled = aux.valida_teclas(e, 2);
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.getMenu().Dispose();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 3);
            if (e.KeyChar == '\r')
            {
                btn_ingresar.PerformClick();
            }
        }

    }
}
