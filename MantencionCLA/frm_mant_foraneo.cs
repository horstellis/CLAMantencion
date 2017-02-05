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
    public partial class frm_mant_foraneo : Form
    {
        /* 
         * Formulario para mantener tablas que tengan id autonumérico y un campo de nombre
         * requiere que la estructura de tablas se mantenga de forma uniforme
         * si la tabla se llama "tabla", los campos son "tabla_id" y "tabla_nombre"
         * donde "tabla_id" es campo primario y autonumérico
         */
        
        sql sql = new sql();
        sqlaux sqlaux = new sqlaux();
        auxiliar aux = new auxiliar();
        private string nombre_tabla = "", nombre_foraneo = "", nombre = "", titulo = "", titulo_foraneo = "";
        private int id = 0, id_foraneo = 0;

        public frm_mant_foraneo()
        {
            InitializeComponent();
        }

        public void setNombreTablas(String nombre_tabla, String nombre_foraneo)
        {
            /*
             * Se utiliza para establecer la tabla a mantener y la tabla foranea
             * nombre_tabla >>> tabla a mantener
             * nombre_foraneo >>> tabla donde esta la clave foranea
             * Se utiliza luego de instancear la ventana
             */
            this.nombre_tabla = nombre_tabla;
            this.nombre_foraneo = nombre_foraneo;
        }

        public void setNombreDescripcion(String nombre_descripcion)
        {
            /*
             * Permite cambiar el nombre por defecto del label que acompaña
             * al cuadro de texto de descripcion
             * Se utiliza luego de instancear la ventana
             */
            this.lbl_descripcion.Text = nombre_descripcion;
        }

        private void llena_tabla()
        {
            sql.llenar_grid(dat_tabla, "SELECT id_" + nombre_tabla + ", nombre FROM " + nombre_tabla + " WHERE id_" + nombre_foraneo + " = " + id_foraneo);
            dat_tabla.Columns[0].Visible = false;
        }

        private void dat_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dat_tabla.Rows[e.RowIndex];
                txt_nombre.Text = fila.Cells[1].Value.ToString();
                id = int.Parse(fila.Cells[0].Value.ToString());
                nombre = fila.Cells[1].Value.ToString();
            }
            catch { }
        }

        private Boolean valida_campos()
        {
            if (cmb_foraneo.SelectedIndex == -1)
            {
                aux.dialogo("Debe indicar " + titulo_foraneo, this.Text, 3);
                cmb_foraneo.Focus();
                return false;
            }
            else if (txt_nombre.Text.Trim().Length==0)
            {
                aux.dialogo("Debe indicar nombre o descripción", this.Text, 3);
                txt_nombre.Focus();
                return false;
            }
            else if (txt_nombre.Text.Trim().Length < 3)
            {
                aux.dialogo("Debe como mínimo ingresar tres caracteres", this.Text, 3);
                txt_nombre.Focus();
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
                if (!sql.verificar("SELECT * FROM " + nombre_tabla + " WHERE nombre = '" + txt_nombre.Text + "'"))
                {
                    if (sql.verificar("SELECT * FROM " + nombre_tabla + " WHERE nombre = '" + nombre + "'"))
                    {
                        if (aux.dialogo("¿Desea actualizar registro seleccionado?", this.Text, 1) == DialogResult.Yes)
                        {
                            int exec = sql.ejecutar("UPDATE " + nombre_tabla + " SET nombre = '" + txt_nombre.Text.Trim() + "', id_" + nombre_foraneo + " = " + id_foraneo + " WHERE id_" + nombre_tabla + " = " + id);
                            if (exec > 0)
                            {
                                aux.dialogo("Actualización correcta", this.Text, 2);
                                llena_tabla();
                                txt_nombre.Clear();
                                //cmb_foraneo.SelectedIndex = -1;
                            }
                            else
                            {
                                aux.dialogo("No se pudo actualizar", this.Text, 3);
                            }
                        }
                    }
                    else
                    {
                        int exec = sql.ejecutar("INSERT INTO " + nombre_tabla + "(nombre, id_" + nombre_foraneo + ") VALUES ('" + txt_nombre.Text.Trim() + "'," + id_foraneo + ")");
                        if (exec > 0)
                        {
                            aux.dialogo("Registro ingresado", this.Text, 2);
                            llena_tabla();
                            txt_nombre.Clear();
                            //cmb_foraneo.SelectedIndex = -1;
                        }
                        else
                        {
                            aux.dialogo("No se pudo agregar el registro", this.Text, 3);
                        }
                    }
                }
                else
                {
                    aux.dialogo("No se puede duplicar el registro", this.Text, 3);
                    txt_nombre.SelectAll();
                    txt_nombre.Focus();
                }
            }
        }

        private void frm_mant_foraneo_Load(object sender, EventArgs e)
        {
            if (nombre_tabla.Contains('_'))
            {
                int a = nombre_tabla.IndexOf('_') + 1;
                titulo = titulo = nombre_tabla.Substring(0, 1).ToUpper() + nombre_tabla.Substring(1, a - 2) + " " + nombre_tabla.Substring(a, 1).ToUpper() + nombre_tabla.Substring(a + 1);
            }
            else
            {
                titulo = nombre_tabla.Substring(0, 1).ToUpper() + nombre_tabla.Substring(1);
            }
            if (nombre_foraneo.Contains('_'))
            {
                int a = nombre_foraneo.IndexOf('_') + 1;
                titulo_foraneo = nombre_foraneo.Substring(0, 1).ToUpper() + nombre_foraneo.Substring(1, a - 2) + " " + nombre_foraneo.Substring(a, 1).ToUpper() + nombre_foraneo.Substring(a + 1);
            }
            else
            {
                titulo_foraneo = nombre_foraneo.Substring(0, 1).ToUpper() + nombre_foraneo.Substring(1);
            }
            this.Text = "Mantenedor " + titulo;
            sql.llenar_combo(cmb_foraneo, "SELECT * FROM " + nombre_foraneo, nombre_foraneo, "nombre", "id_" + nombre_foraneo);
            cmb_foraneo.SelectedIndex = -1;
            lbl_foraneo.Text = titulo_foraneo;
        }

        private void frm_mant_foraneo_FormClosing(object sender, FormClosingEventArgs e)
        {
            anular_ventanas();
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
                        txt_nombre.Clear();
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
            txt_nombre.Clear();
            nombre = "";
            id_foraneo = 0;
            id = 0;
            dat_tabla.DataSource = null;
            cmb_foraneo.SelectedIndex = -1;
        }

        private void anular_ventanas()
        {
            /*
             * Anula las ventanas en la clase util, que hagan referencia a este formulario
             */
            if (util.getLinea() != null)
            {
                util.setLinea(null);
            }
            else if (util.getMaquina() != null)
            {
                util.setMaquina(null);
            }
        }

        private void cmb_foraneo_DropDownClosed(object sender, EventArgs e)
        {
            if (cmb_foraneo.SelectedValue != null)
            {
                id_foraneo = int.Parse(cmb_foraneo.SelectedValue.ToString());
                llena_tabla();
            }
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
    }
}
