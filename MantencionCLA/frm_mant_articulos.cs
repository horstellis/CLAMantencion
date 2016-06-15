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
    public partial class frm_mant_articulos : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private int id = 0, tipo = 0, cantidad = 0;
        private String nombre = "";

        public frm_mant_articulos()
        {
            InitializeComponent();
        }

        private void limpia_campos()
        {
            txt_nombre.Clear();
            txt_cantidad.Clear();
            cmb_tipo.SelectedIndex = -1;
            id = 0;
            tipo = 0;
            cantidad = 0;
            nombre = "";
        }

        private void llena_tabla()
        {
            sql.llenar_grid(dat_articulo, "SELECT * FROM mostrar_articulos");
            dat_articulo.Columns[3].Visible = false;
            dat_articulo.Columns[4].Visible = false;
        }

        private void frm_mant_articulos_Load(object sender, EventArgs e)
        {
            llena_tabla();
            sql.llenar_combo(cmb_tipo, "SELECT * FROM tipo_articulo ORDER BY nombre", "tipo_articulo", "nombre", "id_tipo_articulo");
            limpia_campos();
        }

        private void frm_mant_articulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setArticulos(null);
            this.Dispose();
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            limpia_campos();
        }

        private void dat_articulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dat_articulo.Rows[e.RowIndex];
                txt_nombre.Text = fila.Cells[0].Value.ToString();
                nombre = fila.Cells[0].Value.ToString();
                cmb_tipo.SelectedValue = int.Parse(fila.Cells[4].Value.ToString());
                txt_cantidad.Text = fila.Cells[2].Value.ToString();
                id = int.Parse(fila.Cells[3].Value.ToString());
                tipo = int.Parse(fila.Cells[4].Value.ToString());
            }
            catch { }
        }

        private Boolean valida_campos()
        {
            if (txt_nombre.Text.Trim().Length == 0)
            {
                aux.dialogo("Debe escribir un nombre", this.Text, 3);
                txt_nombre.Focus();
                return false;
            }
            else if (txt_nombre.Text.Trim().Length < 3)
            {
                aux.dialogo("Debe escribir por lo menos tres caracteres", this.Text, 3);
                txt_nombre.SelectAll();
                txt_nombre.Focus();
                return false;
            }
            else if (cmb_tipo.SelectedIndex == -1)
            {
                aux.dialogo("Debe seleccionar un tipo", this.Text, 3);
                cmb_tipo.Focus();
                return false;
            }
            else if (txt_cantidad.Text.Length==0)
            {
                aux.dialogo("Debe indicar cantidad", this.Text, 3);
                txt_cantidad.Focus();
                return false;
            }
            else if (int.Parse(txt_cantidad.Text) == 0)
            {
                aux.dialogo("Cantidad debe ser mayor a 0", this.Text, 3);
                txt_cantidad.SelectAll();
                txt_cantidad.Focus();
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
                if (id != 0)
                {
                    if (!sql.verificar("SELECT * FROM articulo WHERE nombre = '" + txt_nombre.Text + "'"))
                    {
                        if (aux.dialogo("¿Desea actualizar articulo?", this.Text, 1) == DialogResult.Yes)
                        {
                            int exec = sql.ejecutar("UPDATE articulo SET nombre = '" + txt_nombre.Text + "', id_tipo_articulo = " + tipo + ", cantidad = " + txt_cantidad.Text + " WHERE id_articulo = " + id);
                            if (exec > 0)
                            {
                                aux.dialogo("Articulo actualizado exitosamente", this.Text, 2);
                                llena_tabla();
                                limpia_campos();
                            }
                            else
                            {
                                aux.dialogo("No se pudo actualizar el articulo", this.Text, 3);
                            }
                        }
                    }
                    else
                    {
                        aux.dialogo("No se permite duplicar articulos", this.Text, 3);
                        txt_nombre.SelectAll();
                        txt_nombre.Focus();
                    }

                }
                else
                {
                    if (!sql.verificar("SELECT * FROM articulo WHERE nombre = '" + txt_nombre.Text + "'"))
                    {
                        int exec = sql.ejecutar("INSERT INTO articulo(nombre,id_tipo_articulo,cantidad) VALUES ('" + txt_nombre.Text + "'," + tipo + "," + txt_cantidad.Text + ")");
                        if (exec > 0)
                        {
                            aux.dialogo("Articulo agregado exitosamente", this.Text, 2);
                            llena_tabla();
                            limpia_campos();
                        }
                        else
                        {
                            aux.dialogo("No se pudo agregar el articulo", this.Text, 3);
                        }
                    }
                    else
                    {
                        aux.dialogo("No se permite duplicar articulos", this.Text, 3);
                        txt_nombre.SelectAll();
                        txt_nombre.Focus();
                    }
                }
            }
        }

        private void cmb_tipo_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                tipo = int.Parse(cmb_tipo.SelectedValue.ToString());
            }
            catch { }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            String cadena = "abcdefghijklmnñopqrstuvwxyz";
            cadena += "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            cadena += "áéíóúÁÉÍÓÚüÇç";
            cadena += "0123456789";
            cadena += "-";
            e.Handled = aux.valida_teclas(cadena, e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 1);
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (aux.dialogo("¿Desea eliminar el articulo seleccionado?", this.Text, 1) == DialogResult.Yes)
                {
                    int exec = sql.ejecutar("DELETE FROM articulo WHERE id_articulo = " + id);
                    if (exec > 0)
                    {
                        aux.dialogo("Articulo eliminado exitosamente", this.Text, 2);
                        llena_tabla();
                        limpia_campos();
                    }
                    else
                    {
                        aux.dialogo("No se pudo eliminar el articulo", this.Text, 3);
                    }
                }
            }
            else
            {
                aux.dialogo("No ha seleccionado ningún articulo", this.Text, 3);
            }
        }
    }
}
