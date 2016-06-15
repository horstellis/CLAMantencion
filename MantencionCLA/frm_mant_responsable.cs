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
    public partial class frm_mant_responsable : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private int id = 0, estado = 0, cargo = 0;
        private String nombre = "";

        public frm_mant_responsable()
        {
            InitializeComponent();
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
            else if (cmb_cargo.SelectedIndex == -1)
            {
                aux.dialogo("Debe seleccionar un cargo", this.Text, 3);
                cmb_cargo.Focus();
                return false;
            }
            else if (opt_activo.Checked == false && opt_inactivo.Checked == false)
            {
                aux.dialogo("Debe seleccionar un estado", this.Text, 3);
                return false;
            }
            else
            {
                return true;
            } 
        }

        private void llena_tabla()
        {
            sql.llenar_grid(dat_responsable, "SELECT * FROM mostrar_responsables");
            dat_responsable.Columns[3].Visible = false;
            dat_responsable.Columns[4].Visible = false;
            dat_responsable.Columns[5].Visible = false;
        }

        private void frm_mant_responsable_Load(object sender, EventArgs e)
        {
            llena_tabla();
            sql.llenar_combo(cmb_cargo, "SELECT * FROM cargo ORDER BY nombre", "cargo", "nombre", "id_cargo");
            limpiar_campos();
        }

        private void frm_mant_responsable_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setResponsable(null);
            this.Dispose();
        }

        private void dat_responsable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dat_responsable.Rows[e.RowIndex];
                txt_nombre.Text = fila.Cells[0].Value.ToString();
                nombre = fila.Cells[0].Value.ToString();
                id = int.Parse(fila.Cells[3].Value.ToString());
                cargo = int.Parse(fila.Cells[4].Value.ToString());
                cmb_cargo.SelectedValue = int.Parse(fila.Cells[4].Value.ToString());
                estado = int.Parse(fila.Cells[5].Value.ToString());
                if (estado == 1)
                {
                    opt_activo.Checked = true;
                }
                else if (estado == 2)
                {
                    opt_inactivo.Checked = false;
                }
            }
            catch { }
        }

        private void limpiar_campos()
        {
            txt_nombre.Clear();
            cmb_cargo.SelectedIndex = -1;
            opt_activo.Checked = false;
            opt_inactivo.Checked = false;
            nombre = "";
            id = 0;
        }

        private void cmd_insertar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                if (id != 0)
                {
                    if (!sql.verificar("SELECT * FROM responsable WHERE nombre = '" + txt_nombre.Text + "'"))
                    {
                        if (aux.dialogo("¿Desea actualizar responsable?", this.Text, 1) == DialogResult.Yes)
                        {
                            int exec = sql.ejecutar("UPDATE responsable SET nombre = '" + txt_nombre.Text + "', id_cargo = " + cargo + ", id_estado = " + estado + " WHERE id_responsable = " + id);
                            if (exec > 0)
                            {
                                aux.dialogo("Responsable actualizado exitosamente", this.Text, 2);
                                llena_tabla();
                                limpiar_campos();
                            }
                            else
                            {
                                aux.dialogo("No se pudo actualizar el responsable", this.Text, 3);
                            }
                        }
                    }
                    else
                    {
                        aux.dialogo("No se permite duplicar responsable", this.Text, 3);
                        txt_nombre.SelectAll();
                        txt_nombre.Focus();
                    }
                    
                }
                else
                {
                    if (!sql.verificar("SELECT * FROM responsable WHERE nombre = '" + txt_nombre.Text + "'"))
                    {
                        int exec = sql.ejecutar("INSERT INTO responsable(nombre,id_cargo,id_estado) VALUES ('" + txt_nombre.Text + "'," + cargo + "," + estado + ")");
                        if (exec > 0)
                        {
                            aux.dialogo("Responsable agregado exitosamente", this.Text, 2);
                            llena_tabla();
                            limpiar_campos();
                        }
                        else
                        {
                            aux.dialogo("No se pudo agregar el responsable", this.Text, 3);
                        }
                    }
                    else
                    {
                        aux.dialogo("No se permite duplicar responsable", this.Text, 3);
                        txt_nombre.SelectAll();
                        txt_nombre.Focus();
                    }
                }
            }
        }

        private void opt_activo_Click(object sender, EventArgs e)
        {
            estado = 1;
        }

        private void opt_inactivo_Click(object sender, EventArgs e)
        {
            estado = 2;
        }

        private void cmb_cargo_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                cargo = int.Parse(cmb_cargo.SelectedValue.ToString());
            }
            catch { }
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (aux.dialogo("¿Desea eliminar el responsable seleccionado?", this.Text, 1) == DialogResult.Yes)
                {
                    int exec = sql.ejecutar("DELETE FROM responsable WHERE id_responsable = " + id);
                    if (exec > 0)
                    {
                        aux.dialogo("Responsable eliminado exitosamente", this.Text, 2);
                        llena_tabla();
                        limpiar_campos();
                    }
                    else
                    {
                        aux.dialogo("No se pudo eliminar el responsable", this.Text, 3);
                    }
                }
            }
            else
            {
                aux.dialogo("No ha seleccionado ningún responsable", this.Text, 3);
            }
        }

        private void cmd_nuevo_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            String cadena = "abcdefghijklmnñopqrstuvwxyz";
            cadena += "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            cadena += "áéíóúÁÉÍÓÚüÇç";
            cadena += "-";
            e.Handled = aux.valida_teclas(cadena, e);
        }
    }
}
