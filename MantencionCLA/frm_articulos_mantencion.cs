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
    public partial class frm_articulos_mantencion : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        public int mantencion = 0, maquina = 0;
        private int id_articulo = 0, id_tipo_articulo = 0, id_mantencion_maquina = 0;
        private int id = 0, cantidad = 0, dif = 0;

        public frm_articulos_mantencion()
        {
            InitializeComponent();
        }

        private void llena_tabla()
        {
            sql.llenar_grid(dat_articulos, "EXEC ver_articulos_mantencion " + mantencion + "," + maquina);
            dat_articulos.Columns[3].Visible = false;
            dat_articulos.Columns[4].Visible = false;
            dat_articulos.Columns[5].Visible = false;
            dat_articulos.Columns[6].Visible = false;
        }

        private void frm_articulos_mantencion_Load(object sender, EventArgs e)
        {
            try
            {
                sql.llenar_combo(cmb_tipo_articulo, "SELECT * FROM tipo_articulo ORDER BY nombre", "tipo_articulo", "nombre", "id_tipo_articulo");
                cmb_tipo_articulo.SelectedIndex = -1;
                llena_tabla();
            }
            catch { }
        }

        private void cmb_tipo_articulo_DropDownClosed(object sender, EventArgs e)
        {
            if (cmb_tipo_articulo.SelectedIndex != -1)
            {
                try
                {
                    sql.llenar_combo(cmb_articulo, "SELECT * FROM articulo WHERE id_tipo_articulo = " + cmb_tipo_articulo.SelectedValue.ToString() + " ORDER BY nombre", "articulo", "nombre", "id_articulo");
                    cmb_articulo.SelectedIndex = -1;
                    lbl_disponible.Text = "";
                }
                catch { }
            }
        }

        private void cmb_articulo_DropDownClosed(object sender, EventArgs e)
        {
            if (cmb_articulo.SelectedIndex != -1)
            {
                SqlDataReader disp = sql.consulta("SELECT cantidad FROM articulo WHERE id_articulo = " + cmb_articulo.SelectedValue.ToString());
                disp.Read();
                lbl_disponible.Text = disp.GetInt32(0).ToString();
                disp.Dispose();
            }
        }

        private void cmd_insertar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                dif = cantidad - int.Parse(txt_cantidad.Text);
                if (dif < 0)
                {
                    if ((int.Parse(lbl_disponible.Text) + dif) < 0)
                    {
                        aux.dialogo("No hay suficientes artículos", this.Text, 3);
                        txt_cantidad.SelectAll();
                        txt_cantidad.Focus();
                        return;
                    }
                }
                SqlDataReader mant = sql.consulta("SELECT id_mantencion_maquina FROM mantencion_maquina WHERE id_mantencion = " + mantencion + " AND id_maquina = " + maquina);
                if (!(mant == null))
                {
                    mant.Read();
                    id_mantencion_maquina = mant.GetInt32(0);
                    mant.Dispose();
                }
                id_articulo = int.Parse(cmb_articulo.SelectedValue.ToString());
                id_tipo_articulo = int.Parse(cmb_tipo_articulo.SelectedValue.ToString());                    
                if (id == 0)
                {
                    String query = "INSERT INTO mantencion_maquina_articulo(id_articulo,cantidad,id_mantencion_maquina) VALUES (";
                    query += id_articulo + ",";
                    query += txt_cantidad.Text + ",";
                    query += id_mantencion_maquina + ")";
                    if ((sql.ejecutar(query)) > 0)
                    {
                        int saldo = int.Parse(lbl_disponible.Text) + dif;
                        if (sql.ejecutar("UPDATE articulo SET cantidad = " + saldo + " WHERE id_articulo = " + id_articulo) > 0)
                        {
                            aux.dialogo("Se agrego corectamente el articulo y se actualizo la información", this.Text, 2);
                            llena_tabla();
                            limpia_campos();
                        }
                        else
                        {
                            aux.dialogo("Se agrego correctamente el articulo, pero no se pudo actualizar la información", this.Text, 3);
                            llena_tabla();
                            limpia_campos();
                        }
                    }
                    else
                    {
                        aux.dialogo("No se pudo agregar el articulo", this.Text, 3);
                    }
                }
                else if (aux.dialogo("¿Desea actualizar el articulo seleccionado?", this.Text, 1) == DialogResult.Yes)
                {
                    String query = "UPDATE mantencion_maquina_articulo SET ";
                    query += "id_articulo = " + id_articulo + ", ";
                    query += "cantidad = " + txt_cantidad.Text + ", ";
                    query += "id_mantencion_maquina = " + id_mantencion_maquina + " ";
                    query += "WHERE id_mantencion_maquina_articulo = " + id;
                    if ((sql.ejecutar(query)) > 0)
                    {
                        int saldo = int.Parse(lbl_disponible.Text) + dif;
                        if (sql.ejecutar("UPDATE articulo SET cantidad = " + saldo + " WHERE id_articulo = " + id_articulo) > 0)
                        {
                            aux.dialogo("Se actualizo corectamente el articulo y se actualizo la información", this.Text, 2);
                            llena_tabla();
                            limpia_campos();
                        }
                        else
                        {
                            aux.dialogo("Se actualizo correctamente el articulo, pero no se pudo actualizar la información", this.Text, 3);
                            llena_tabla();
                            limpia_campos();
                        }
                    }
                    else
                    {
                        aux.dialogo("No se pudo actualizar el articulo", this.Text, 3);
                    }
                }
            }
        }

        private void limpia_campos()
        {
            txt_cantidad.Clear();
            cmb_articulo.DataSource = null;
            cmb_tipo_articulo.SelectedIndex = -1;
            lbl_disponible.Text = "";
        }

        private Boolean valida_campos()
        {
            if (cmb_tipo_articulo.SelectedIndex == -1)
            {
                aux.dialogo("Debe de indicar Tipo de Artículo", this.Text, 3);
                return false;
            }
            else if (cmb_articulo.SelectedIndex == -1)
            {
                aux.dialogo("Debe de indicar Artículo", this.Text, 3);
                return false;
            }
            else if (txt_cantidad.Text.Length == 0)
            {
                aux.dialogo("Debe de indicar cantidad de artículos", this.Text, 3);
                txt_cantidad.Focus();
                return false;
            }
            else if (int.Parse(txt_cantidad.Text) < 1)
            {
                aux.dialogo("Cantidad desde ser mayor o igual a 1",this.Text,3);
                txt_cantidad.SelectAll();
                txt_cantidad.Focus();
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 1);
        }

        private void dat_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dat_articulos.CurrentRow;
            id = int.Parse(fila.Cells[6].Value.ToString());
            id_mantencion_maquina = int.Parse(fila.Cells[5].Value.ToString());
            id_tipo_articulo = int.Parse(fila.Cells[4].Value.ToString());
            id_articulo = int.Parse(fila.Cells[3].Value.ToString());
            SqlDataReader articulo = sql.consulta("SELECT cantidad FROM articulo WHERE id_articulo = " + id_articulo);
            articulo.Read();
            lbl_disponible.Text = articulo.GetInt32(0).ToString();
            articulo.Dispose();
            txt_cantidad.Text = fila.Cells[2].Value.ToString();
            cantidad = int.Parse(fila.Cells[2].Value.ToString());
            cmb_tipo_articulo.SelectedValue = id_tipo_articulo;
            sql.llenar_combo(cmb_articulo, "SELECT * FROM articulo WHERE id_tipo_articulo = " + id_tipo_articulo + " ORDER BY nombre", "articulo", "nombre", "id_articulo");
            cmb_articulo.SelectedValue = id_articulo;
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Desea eliminar el articulo seleccionado?";
            if (id > 0)
            {
                if (aux.dialogo(mensaje, this.Text, 1) == DialogResult.Yes)
                {
                    if ((sql.ejecutar("DELETE FROM mantencion_maquina_articulo WHERE id_mantencion_maquina_articulo = " + id)) > 0)
                    {
                        int saldo = int.Parse(lbl_disponible.Text) + cantidad;
                        if (sql.ejecutar("UPDATE articulo SET cantidad = " + saldo + " WHERE id_articulo = " + id_articulo) > 0)
                        {
                            aux.dialogo("Se elimino corectamente el articulo y se actualizo la información", this.Text, 2);
                            llena_tabla();
                            limpia_campos();
                        }
                        else
                        {
                            aux.dialogo("Se elimino correctamente el articulo, pero no se pudo actualizar la información", this.Text, 3);
                            llena_tabla();
                            limpia_campos();
                        }
                    }
                    else
                    {
                        aux.dialogo("No se pudo eliminar el articulo asociado a esta mantención de máquina", this.Text, 3);
                    }
                }
            }
        }
    }
}
