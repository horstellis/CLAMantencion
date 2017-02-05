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
    public partial class frm_solicitud : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private int seccion = 0, solicitante = 0, solicitud = 0;
        private static String usuario = util.getInicio().ver_usuario();
        private frm_imprimir_solicitud imprimir;

        public frm_solicitud()
        {
            InitializeComponent();
        }

        private void frm_solicitud_Load(object sender, EventArgs e)
        {
            sql.llenar_combo(cmb_seccion, "SELECT * FROM seccion ORDER BY id_seccion", "seccion", "nombre", "id_seccion");
            cmb_seccion.SelectedIndex = -1;
            sql.llenar_combo(cmb_solicitante, "SELECT * FROM solicitante ORDER BY id_solicitante", "solicitante", "nombre", "id_solicitante");
            cmb_solicitante.SelectedIndex = -1;
            this.Height = 340;
            dt_fsolicitud.Value = DateTime.Today;
            dt_fsolicitud.MaxDate = DateTime.Today;
        }

        private void cmd_lista_Click(object sender, EventArgs e)
        {
            try
            {
                sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud 0");
                dat_solicitud.Columns[4].Visible = false;
                dat_solicitud.Columns[5].Visible = false;
                dat_solicitud.Columns[6].Visible = false;
                this.Height = 520;
            }
            catch { }
        }

        private void frm_solicitud_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setSolicitud(null);
            this.Dispose();
        }

        private void limpiar()
        {
            cmb_seccion.SelectedIndex = -1;
            cmb_solicitante.SelectedIndex = -1;
            txt_folio.Clear();
            lbl_solicitud.ResetText();
            txt_detalle.Clear();
            dt_fsolicitud.Value = DateTime.Today;
            seccion = 0;
            solicitante = 0;
            solicitud = 0;
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Height = 340;
        }

        private void dat_solicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dat_solicitud.Rows[e.RowIndex];
                dt_fsolicitud.Value = DateTime.Parse(fila.Cells[1].Value.ToString());
                txt_detalle.Text = fila.Cells[6].Value.ToString();
                lbl_solicitud.Text = fila.Cells[0].Value.ToString();
                cmb_seccion.SelectedValue = int.Parse(fila.Cells[4].Value.ToString());
                seccion = int.Parse(fila.Cells[4].Value.ToString());
                cmb_solicitante.SelectedValue = int.Parse(fila.Cells[5].Value.ToString());
                solicitante = int.Parse(fila.Cells[5].Value.ToString());
                solicitud = int.Parse(fila.Cells[0].Value.ToString());
                SqlDataReader dr = sql.consulta("SELECT * FROM solicitud_folio WHERE id_solicitud = " + solicitud);
                if (dr.Read())
                {
                    txt_folio.Text = dr[1].ToString();
                }
                else
                {
                    txt_folio.Clear();
                }
            }catch { }
        }

        private void cmb_seccion_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                seccion = int.Parse(cmb_seccion.SelectedValue.ToString());
                sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + cmb_seccion.SelectedValue);
                dat_solicitud.Columns[4].Visible = false;
                dat_solicitud.Columns[5].Visible = false;
                dat_solicitud.Columns[6].Visible = false;
                this.Height = 520;
            }
            catch { }
        }

        private void cmb_solicitante_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                solicitante = int.Parse(cmb_solicitante.SelectedValue.ToString());
            }
            catch { }
        }

        private void cmd_insertar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                int num = 0;
                if (txt_folio.Text.Length > 0)
                {
                    num = int.Parse(txt_folio.Text);
                }
                if (solicitud == 0)
                {
                    SqlDataReader folio = sql.consulta("SELECT * FROM solicitud_folio WHERE folio = " + num);
                    if (folio.Read())
                    {
                        aux.dialogo("No se puede duplicar numero de folio", this.Text, 3);
                        txt_folio.SelectAll();
                        txt_folio.Focus();
                    }
                    else
                    {
                        //Inserta nuevo dato
                        String query = "EXEC ingresar_solicitud 0,";
                        query += num + ",";
                        query += "'" + dt_fsolicitud.Value.ToShortDateString() + "',";
                        query += "'" + txt_detalle.Text + "',";
                        query += seccion + ",";
                        query += solicitante + ",'";
                        query += usuario + "'";
                        int exec = sql.ejecutar(query);
                        if (exec > 0)
                        {
                            aux.dialogo("Solicitud ingresada correctamente", this.Text, 2);
                            SqlDataReader id = sql.consulta("SELECT TOP 1 id_solicitud FROM solicitud ORDER BY id_solicitud DESC");
                            id.Read();
                            String soli = id.GetInt32(0).ToString();
                            id.Dispose();
                            lbl_solicitud.Text = soli;
                            sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + seccion);
                        }
                        else
                        {
                            aux.dialogo("No se pudo ingresar la solicitud", this.Text, 3);
                        }
                    }
                }
                else
                {
                    int sol = 0;
                    SqlDataReader folio = sql.consulta("SELECT id_solicitud FROM solicitud_folio WHERE folio = " + num);
                    if (folio.Read())
                    {
                        sol = folio.GetInt32(0);
                    }
                    if (sol != 0 && !(sol == solicitud))
                    {
                        aux.dialogo("No se puede duplicar numero de folio", this.Text, 3);
                        txt_folio.SelectAll();
                        txt_folio.Focus();
                    }
                    else
                    {
                        //Actualiza dato
                        if (sql.verificar("SELECT * FROM mantencion WHERE id_solicitud = " + solicitud))
                        {
                            aux.dialogo("La solicitud ya ha sido asignada a mantención\nNo puede modificar una solicitud en curso", this.Text, 3);
                        }
                        else
                        {
                            if (aux.dialogo("¿Desea actualizar la solicitud?", this.Text, 1) == DialogResult.Yes)
                            {
                                String query = "EXEC ingresar_solicitud " + solicitud + ",";
                                query += num + ",";
                                query += "'" + dt_fsolicitud.Value.ToShortDateString() + "',";
                                query += "'" + txt_detalle.Text + "',";
                                query += seccion + ",";
                                query += solicitante + ",'";
                                query += usuario + "'";
                                int exec = sql.ejecutar(query);
                                if (exec > 0)
                                {
                                    aux.dialogo("Solicitud actualizada correctamente", this.Text, 2);
                                    sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + seccion);
                                    limpiar();
                                }
                                else
                                {
                                    aux.dialogo("No se pudo actualizar la solicitud", this.Text, 3);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (sql.verificar("SELECT * FROM mantencion WHERE id_solicitud = " + solicitud))
            {
                aux.dialogo("La solicitud ya ha sido asignada a mantención\nNo puede eliminar una solicitud en curso", this.Text, 3);
            }
            else
            {
                if (aux.dialogo("¿Desea eliminar la solicitud?", this.Text, 1) == DialogResult.Yes)
                {
                    if ((sql.ejecutar("UPDATE solicitud SET id_estado = 3 WHERE id_solicitud = " + solicitud)) > 0)
                    {
                        sql.ejecutar("EXEC registro_solicitud " + solicitud + ", '" + usuario + "', 3");
                        aux.dialogo("Solicitud marcada como eliminada correctamente", this.Text, 2);
                        cmd_limpiar.PerformClick();
                    }
                    else
                    {
                        aux.dialogo("No se pudo marcar como eliminada la solicitud", this.Text, 3);
                    }       
                }
            }
        }

        private Boolean valida_campos()
        {
            if (txt_detalle.Text.Trim().Length == 0)
            {
                aux.dialogo("Debe indicar detalle", this.Text, 3);
                txt_detalle.Focus();
                return false;
            }
            else if (txt_detalle.Text.Trim().Length < 10)
            {
                aux.dialogo("Detalle debe tener al menos 10 caracteres", this.Text, 3);
                txt_detalle.Focus();
                return false;
            }
            else if (cmb_seccion.SelectedIndex == -1)
            {
                aux.dialogo("Debe seleccionar Sección", this.Text, 3);
                cmb_seccion.Focus();
                return false;
            }
            else if (cmb_solicitante.SelectedIndex == -1)
            {
                aux.dialogo("Debe seleccionar Solicitante", this.Text, 3);
                cmb_solicitante.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txt_folio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 1);
        }

        private void lbl_solicitud_TextChanged(object sender, EventArgs e)
        {
            if (lbl_solicitud.Text.Length > 0)
            {
                cmd_imprimir.Enabled = true;
            }
            else
            {
                cmd_imprimir.Enabled = false;
            }
        }

        private void cmd_imprimir_Click(object sender, EventArgs e)
        {
            imprimir = new frm_imprimir_solicitud();
            imprimir.id_solicitud = int.Parse(lbl_solicitud.Text);
            imprimir.ShowDialog(this);
        }
    }
}
