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
    public partial class frm_mant_basico : Form
    {
        private sql sql = new sql();
        private auxiliar aux = new auxiliar();
        private string nombre_tabla = "", nombre = "", titulo = "", msg_error = "";
        private int id = 0;

        public frm_mant_basico()
        {
            InitializeComponent();
        }

        public void setNombreTabla(String nombre_tabla)
        {
            this.nombre_tabla = nombre_tabla;
        }

        public void setNombreDescripcion(String nombre_descripcion)
        {
            this.lbl_descripcion.Text = nombre_descripcion;
        }

        private void llena_tabla()
        {
            try
            {
                sql.llenar_grid(dat_tabla, "SELECT id_" + nombre_tabla + ", nombre Descripcion FROM " + nombre_tabla);
                dat_tabla.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                util.getMenu().setMsgError(ex.Message);
            }
        }

        private void dat_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dat_tabla.Rows[e.RowIndex];
                txt_descripcion.Text = fila.Cells[1].Value.ToString();
                id = int.Parse(fila.Cells[0].Value.ToString());
                nombre = fila.Cells[1].Value.ToString();
            }
            catch { }
        }

        private Boolean valida_campos()
        {
            if (txt_descripcion.Text.Trim().Length==0)
            {
                aux.dialogo("Debe indicar descripción", this.Text, 3);
                txt_descripcion.Focus();
                return false;
            }
            else if (txt_descripcion.Text.Trim().Length < 3)
            {
                aux.dialogo("Debe como mínimo ingresar tres caracteres", this.Text, 3);
                txt_descripcion.Focus();
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
                if (!sql.verificar("SELECT * FROM " + nombre_tabla + " WHERE nombre = '" + txt_descripcion.Text + "'"))
                {
                    if (id != 0)
                    {
                        if (aux.dialogo("¿Desea actualizar registro seleccionado?", this.Text, 1) == DialogResult.Yes)
                        {
                            int exec = sql.ejecutar("UPDATE " + nombre_tabla + " SET nombre = '" + txt_descripcion.Text.Trim() + "' WHERE id_" + nombre_tabla + " = " + id);
                            if (exec > 0)
                            {
                                aux.dialogo("Actualización correcta", this.Text, 2);
                                llena_tabla();
                                txt_descripcion.Clear();
                            }
                            else
                            {
                                aux.dialogo("No se pudo actualizar", this.Text, 3);
                            }
                        }
                    }
                    else
                    {
                        int exec = sql.ejecutar("INSERT INTO " + nombre_tabla + "(nombre) VALUES ('" + txt_descripcion.Text.Trim() + "')");
                        if (exec > 0)
                        {
                            aux.dialogo("Registro ingresado", this.Text, 2);
                            llena_tabla();
                            txt_descripcion.Clear();
                        }
                        else
                        {
                            aux.dialogo("No se pudo agregar el registro", this.Text, 3);
                        }
                    }
                }
                else
                {
                    aux.dialogo("Ya existe un registro con ese nombre", this.Text, 3);
                    txt_descripcion.SelectAll();
                    txt_descripcion.Focus();
                }
            }
        }

        private void frm_mant_basico_Load(object sender, EventArgs e)
        {
            String titulo;
            if (nombre_tabla.Contains('_'))
            {
                int a = nombre_tabla.IndexOf('_') + 1;
                titulo = titulo = nombre_tabla.Substring(0, 1).ToUpper() + nombre_tabla.Substring(1, a - 2) + " " + nombre_tabla.Substring(a, 1).ToUpper() + nombre_tabla.Substring(a + 1);
            }
            else
            {
                titulo = nombre_tabla.Substring(0, 1).ToUpper() + nombre_tabla.Substring(1);
            }
            this.Text = "Mantenedor " + titulo;
            llena_tabla();
        }

        private void frm_mant_basico_FormClosing(object sender, FormClosingEventArgs e)
        {
            anular_ventanas();
            this.Dispose();
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (valida_campos() && id != 0)
            {
                if (aux.dialogo("¿Desea eliminar el registro seleccionado?", this.Text, 1) == DialogResult.Yes)
                {
                    int exec = sql.ejecutar("DELETE FROM " + nombre_tabla + " WHERE id_" + nombre_tabla + " = " + id);
                    if (exec > 0)
                    {
                        aux.dialogo("Registro eliminado", this.Text, 2);
                        llena_tabla();
                        txt_descripcion.Clear();
                    }
                    else
                    {
                        aux.dialogo("No se pudo eliminar el registro", this.Text, 3);
                    }
                }
            }
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            txt_descripcion.Clear();
            nombre = "";
            id = 0;
        }

        private void anular_ventanas()
        {
            if (util.getAsignacion() != null)
            {
                util.setAsignacion(null);
            }
            else if (util.getEstado() != null)
            {
                util.setEstado(null);
            }
            else if (util.getTipoArticulo() != null)
            {
                util.setTipoArticulo(null);
            }
            else if (util.getPermiso() != null)
            {
                util.setPermiso(null);
            }
            else if (util.getClasificacion() != null)
            {
                util.setClasificacion(null);
            }
            else if (util.getSeccion() != null)
            {
                util.setSeccion(null);
            }
            else if (util.getEstadoMantencion() != null)
            {
                util.setEstadoMantencion(null);
            }
        }
    }
}
