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
    public partial class frm_mant_usuarios : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private sqlaux saux = new sqlaux();
        private String usuario = "";
        private int permiso = 0, estado = 0;

        public frm_mant_usuarios()
        {
            InitializeComponent();
        }

        private void frm_mant_usuarios_Load(object sender, EventArgs e)
        {
            llena_tabla();
        }

        private void llena_tabla()
        {
            sql.llenar_grid(dat_usuarios, saux.select("*", "lista_usuarios"));
            dat_usuarios.Columns[5].Visible = false;
            dat_usuarios.Columns[6].Visible = false;
            dat_usuarios.Columns[7].Visible = false;
        }

        private void dat_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dat_usuarios.Rows[e.RowIndex];
            txt_usuario.Text = fila.Cells[0].Value.ToString();
            usuario = fila.Cells[0].Value.ToString();
            txt_clave.Text = fila.Cells[5].Value.ToString();
            txt_nombre.Text = fila.Cells[1].Value.ToString();
            permiso = int.Parse(fila.Cells[6].Value.ToString());
            estado = int.Parse(fila.Cells[7].Value.ToString());
            if (estado == 1)
            {
                opt_activo.Checked = true;
            }
            else if (estado == 2)
            {
                opt_inactivo.Checked = true;
            }
            else if (estado == 3)
            {
                opt_bloqueado.Checked = true;
            }
            if (permiso == 1)
            {
                opt_admin.Checked = true;
            }
            else if (permiso == 2)
            {
                opt_usuario.Checked = true;
            }
            else if (permiso == 3)
            {
                opt_visor.Checked = true;
            }
        }

        private void limpiar()
        {
            txt_usuario.Clear();
            txt_clave.Clear();
            txt_nombre.Clear();
            opt_activo.Checked = false;
            opt_inactivo.Checked = false;
            opt_bloqueado.Checked = false;
            opt_admin.Checked = false;
            opt_usuario.Checked = false;
            opt_visor.Checked = false;
            usuario = "";
            permiso = 0;
            estado = 0;
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (aux.dialogo("¿Desea eliminar el usuario " + usuario + "?", this.Text, 1) == DialogResult.Yes)
            {
                Boolean valida = true;
                int a = 0;
                if (util.getInicio().ver_usuario().Equals(usuario))
                {
                    if (aux.dialogo("Esta intentando eliminar el usuario activo\nSi continua se terminara la sesión activa\n¿Desea continuar?", this.Text, 1) == DialogResult.No)
                    {
                        valida = false;
                    }
                    else
                    {
                        a = 1;
                    }
                }
                if (valida)
                {
                    SqlDataReader consulta = sql.consulta("SELECT COUNT(*) FROM usuarios WHERE id_permiso = 1");
                    consulta.Read();
                    int verifica = int.Parse(consulta[0].ToString());
                    if (verifica > 1)
                    {
                        int exec = sql.ejecutar("DELETE FROM usuarios WHERE usuario = '" + usuario + "'");
                        if (exec > 0)
                        {
                            aux.dialogo("Usuario eliminado exitosamente", this.Text, 2);
                            if (a != 1)
                            {
                                limpiar();
                                llena_tabla();
                            }
                            else
                            {
                                aux.dialogo("Se terminará esta sesión del sistema", this.Text, 3);
                                util.getInicio().Show();
                                util.getMenu().Dispose();
                            }
                        }
                        else
                        {
                            aux.dialogo("Ocurrio un error al intentar eliminar el usuario", this.Text, 3);
                        }
                    }
                    else
                    {
                        aux.dialogo("No se pueden eliminar todos los usuarios administradores\nIntente crear o establecer otro usuario como administrador antes de continuar", this.Text, 3);
                    }
                }
            }
        }

        private void cmd_ver_clave_MouseEnter(object sender, EventArgs e)
        {
            //Muestra clave al acercar el mouse
            txt_clave.UseSystemPasswordChar = false;
        }

        private void cmd_ver_clave_MouseLeave(object sender, EventArgs e)
        {
            //Oculta clave al alejar el mouse
            txt_clave.UseSystemPasswordChar = true;
        }

        private Boolean valida_campos()
        {
            if (txt_usuario.Text.Trim().Length==0)
            {
                aux.dialogo("Debe indicar usuario", this.Text, 3);
                txt_usuario.Clear();
                txt_usuario.Focus();
                return false;
            }
            else if (txt_usuario.Text.Trim().Length < 3)
            {
                aux.dialogo("Nombre de usuario debe ser de tres o más caracteres", this.Text, 3);
                txt_usuario.SelectAll();
                txt_usuario.Focus();
                return false;
            }
            else if (txt_clave.Text.Trim().Length==0)
            {
                aux.dialogo("Debe indicar clave", this.Text, 3);
                txt_clave.Clear();
                txt_clave.Focus();
                return false;
            }
            else if (txt_nombre.Text.Trim().Length==0)
            {
                aux.dialogo("Debe indicar nombre del usuario", this.Text, 3);
                txt_nombre.Focus();
                return false;
            }
            else if (!opt_admin.Checked && !opt_usuario.Checked && !opt_visor.Checked)
            {
                aux.dialogo("Debe indicar tipo de acceso", this.Text, 3);
                fra_permisos.Focus();
                return false;
            }
            else if (!opt_activo.Checked && !opt_inactivo.Checked && !opt_bloqueado.Checked)
            {
                aux.dialogo("Debe indicar estado del usuario", this.Text, 3);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cmd_insertar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                if (sql.verificar("SELECT * FROM usuarios WHERE usuario = '" + txt_usuario.Text.Trim() + "'"))
                {
                    if (aux.dialogo("¿Desea actualizar el usuario " + txt_usuario.Text.Trim() + "", this.Text, 1) == DialogResult.Yes)
                    {
                        String query = "UPDATE usuarios SET ";
                        query += "pass = '" + txt_clave.Text.Trim() + "', ";
                        query += "nombre = '" + txt_nombre.Text.Trim() + "', ";
                        query += "id_permiso = " + permiso + ", ";
                        query += "id_estado = " + estado + " ";
                        query += "WHERE usuario = '" + txt_usuario.Text.Trim() + "'";
                        int exec = sql.ejecutar(query);
                        if (exec > 0)
                        {
                            aux.dialogo("Usuario actualizado exitosamente", this.Text, 2);
                            limpiar();
                            llena_tabla();
                        }
                        else
                        {
                            aux.dialogo("Ocurrio un error al intentar actualizar usuario", this.Text, 3);
                        }
                    }
                }
                else
                {
                    String query = "INSERT INTO usuarios(usuario,pass,nombre,id_permiso,id_estado) VALUES (";
                    query += "'" + txt_usuario.Text.Trim() + "',";
                    query += "'" + txt_clave.Text.Trim() + "',";
                    query += "'" + txt_nombre.Text.Trim() + "',";
                    query += permiso + "," + estado + ")";
                    int exec = sql.ejecutar(query);
                    if (exec > 0)
                    {
                        aux.dialogo("Usuario agregado con exito", this.Text, 2);
                        limpiar();
                        llena_tabla();
                    }
                    else
                    {
                        aux.dialogo("Ocurrio un error al intentar agregar el usuario", this.Text, 3);
                    }
                }
            }
        }

        private void opt_admin_Click(object sender, EventArgs e)
        {
            permiso = 1;
        }

        private void opt_usuario_Click(object sender, EventArgs e)
        {
            permiso = 2;
        }

        private void opt_visor_Click(object sender, EventArgs e)
        {
            permiso = 3;
        }

        private void opt_activo_Click(object sender, EventArgs e)
        {
            estado = 1;
        }

        private void opt_inactivo_Click(object sender, EventArgs e)
        {
            estado = 2;
        }

        private void opt_bloqueado_Click(object sender, EventArgs e)
        {
            estado = 3;
        }
    }
}
