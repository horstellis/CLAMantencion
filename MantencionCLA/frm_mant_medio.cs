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
    public partial class frm_mant_medio : Form
    {
        sql sql = new sql();
        auxiliar aux = new auxiliar();
        public string nombre_tabla = "";
        private string descripcion = "";
        private int id = 0;

        public frm_mant_medio()
        {
            InitializeComponent();
        }

        private void llena_tabla()
        {
            sql.llenar_grid(dat_tabla, "SELECT id_" + nombre_tabla + ", nombre Descripcion, observacion FROM " + nombre_tabla);
            dat_tabla.Columns[0].Visible = false;
            dat_tabla.Columns[2].Visible = false;
        }

        private void dat_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dat_tabla.Rows[e.RowIndex];
            txt_descripcion.Text = fila.Cells[1].Value.ToString();
            txt_observacion.Text = fila.Cells[2].Value.ToString();
            id = int.Parse(fila.Cells[0].Value.ToString());
            descripcion = fila.Cells[1].Value.ToString();
        }

        private Boolean valida_campos()
        {
            if (txt_descripcion.Text.Equals(""))
            {
                aux.dialogo("Debe indicar descripción / nombre", this.Text, 3);
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
            String query = "";
            if (valida_campos())
            {
                if (sql.verificar("SELECT * FROM " + nombre_tabla + " WHERE nombre = '" + descripcion +"'"))
                {
                    if (aux.dialogo("¿Desea actualizar registro seleccionado?", this.Text, 1) == DialogResult.Yes)
                    {
                        if (txt_observacion.Equals(""))
                        {
                            if (aux.dialogo("¿Agregar sin observación?", this.Text, 1) == DialogResult.Yes)
                            {
                                query = "UPDATE " + nombre_tabla + " SET nombre = '" + txt_descripcion.Text.Trim() + "' WHERE id_" + nombre_tabla + " = " + id;
                            }
                            else
                            {
                                txt_observacion.Focus();
                            }
                        }
                        else
                        {
                            query = "UPDATE " + nombre_tabla + " SET nombre = '" + txt_descripcion.Text.Trim() + "', observacion = '" + txt_observacion.Text.Trim() + "' WHERE id_" + nombre_tabla + " = " + id;
                        }
                        int exec = sql.ejecutar(query);
                        if (exec > 0)
                        {
                            aux.dialogo("Actualización correcta", this.Text, 2);
                            llena_tabla();
                            txt_descripcion.Clear();
                            txt_observacion.Clear();
                        }
                        else
                        {
                            aux.dialogo("No se pudo actualizar", this.Text, 3);
                        }
                    }
                }
                else
                {
                    if (txt_observacion.Equals(""))
                    {
                        query = "INSERT INTO " + nombre_tabla + "(nombre) VALUES ('" + txt_descripcion.Text.Trim() + "')";
                    }
                    else
                    {
                        query = "INSERT INTO " + nombre_tabla + "(nombre,observacion) VALUES ('" + txt_descripcion.Text.Trim() + "','"+ txt_observacion.Text.Trim() +"')";
                    }
                    int exec = sql.ejecutar(query);
                    if (exec > 0)
                    {
                        aux.dialogo("Registro ingresado", this.Text, 2);
                        llena_tabla();
                        txt_descripcion.Clear();
                        txt_observacion.Clear();
                    }
                    else
                    {
                        aux.dialogo("No se pudo agregar el registro", this.Text, 3);
                    }
                }
            }
        }

        private void frm_mant_medio_Load(object sender, EventArgs e)
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

        private void frm_mant_medio_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.getMenu().Show();
            this.Dispose();
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                if (aux.dialogo("¿Desea eliminar el registro seleccionado?", this.Text, 1) == DialogResult.Yes)
                {
                    int exec = sql.ejecutar("DELETE FROM " + nombre_tabla + " WHERE id_" + nombre_tabla + " = " + id);
                    if (exec > 0)
                    {
                        aux.dialogo("Registro eliminado", this.Text, 2);
                        llena_tabla();
                        txt_descripcion.Clear();
                        txt_observacion.Clear();
                    }
                    else
                    {
                        aux.dialogo("No se pudo eliminar el registro", this.Text, 3);
                    }
                }
            }
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            txt_descripcion.Clear();
            txt_observacion.Clear();
        }
    }
}
