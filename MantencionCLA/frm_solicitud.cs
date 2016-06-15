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
        private static DateTime ahora = DateTime.Today;
        private static String usuario = util.getInicio().ver_usuario();

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
            this.Height = 310;
            txt_fsolicitud.Text = ahora.ToShortDateString();
        }

        private void cmd_lista_Click(object sender, EventArgs e)
        {
            try
            {
                sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud 0,2");
                dat_solicitud.Columns[3].Visible = false;
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
            txt_detalle.Clear();
            txt_fsolicitud.Text = ahora.ToShortDateString();
            seccion = 0;
            solicitante = 0;
            solicitud = 0;
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Height = 310;
        }

        private void dat_solicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dat_solicitud.Rows[e.RowIndex];
                txt_fsolicitud.Text = fila.Cells[0].Value.ToString().Substring(0,10);
                txt_detalle.Text = fila.Cells[6].Value.ToString();
                cmb_seccion.SelectedValue = int.Parse(fila.Cells[4].Value.ToString());
                seccion = int.Parse(fila.Cells[4].Value.ToString());
                cmb_solicitante.SelectedValue = int.Parse(fila.Cells[5].Value.ToString());
                solicitante = int.Parse(fila.Cells[5].Value.ToString());
                solicitud = int.Parse(fila.Cells[3].Value.ToString());
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
                sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + cmb_seccion.SelectedValue + ",1");
                dat_solicitud.Columns[3].Visible = false;
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
            int num = 0;
            if (txt_folio.Text.Length > 0)
            {
                num = int.Parse(txt_folio.Text);
            }
            if (solicitud == 0)
            {
                //Inserta nuevo dato
                SqlDataReader folio = sql.consulta("SELECT * FROM solicitud_folio WHERE folio = " + num);
                if (folio.Read())
                {
                    aux.dialogo("No se puede duplicar numero de folio",this.Text,3);
                    txt_folio.SelectAll();
                    txt_folio.Focus();
                }
                else
                {
                    String query = "INSERT INTO solicitud (fsolicitud,id_seccion,id_solicitante,detalle,usuario) VALUES(";
                    query += "'" + txt_fsolicitud.Text + "',";
                    query += seccion + ",";
                    query += solicitante + ",";
                    query += "'" + txt_detalle.Text + "','";
                    query += usuario + "')";
                    int exec = sql.ejecutar(query);
                    if (exec > 0)
                    {
                        SqlDataReader id = sql.consulta("SELECT id_solicitud FROM solicitud ORDER BY id_solicitud DESC");
                        id.Read();
                        solicitud = int.Parse(id[0].ToString());
                        int exes = sql.ejecutar("INSERT INTO solicitud_folio VALUES(" + solicitud + "," + num + ")");
                        if (exes > 0)
                        {
                            aux.dialogo("Solicitud ingresada correctamente", this.Text, 2);
                            sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + seccion + ",1");
                            limpiar();
                        }
                        else
                        {
                            aux.dialogo("No se ingreso correctamente el número de folio", this.Text, 3);
                        }
                    }
                    else
                    {
                        aux.dialogo("No se pudo ingresar la solicitud", this.Text, 3);
                    }
                }
            }
            else
            {
                //Actualiza dato
                SqlDataReader folio = sql.consulta("SELECT * FROM solicitud_folio WHERE id_solicitud <> " + solicitud + " AND folio = " + num);
                if (folio.Read())
                {
                    aux.dialogo("No se puede duplicar numero de folio", this.Text, 3);
                    txt_folio.SelectAll();
                    txt_folio.Focus();
                }
                else
                {
                    if (aux.dialogo("¿Desea actualizar la solicitud?", this.Text, 1) == DialogResult.Yes)
                    {
                        String query = "UPDATE solicitud SET ";
                        query += "fsolicitud = '" + txt_fsolicitud.Text + "', ";
                        query += "id_seccion = " + seccion + ", ";
                        query += "id_solicitante = " + solicitante + ", ";
                        query += "detalle = '" + txt_detalle.Text + "', ";
                        query += "usuario = '" + usuario + "' ";
                        query += "WHERE id_solicitud = " + solicitud;
                        int exec = sql.ejecutar(query);
                        if (exec > 0)
                        {
                            int error = 0;
                            SqlDataReader dr = sql.consulta("SELECT folio FROM solicitud_folio WHERE id_solicitud = " + solicitud);
                            if (dr.Read())
                            {
                                int er = sql.ejecutar("DELETE FROM solicitud_folio WHERE id_solicitud = " + solicitud);
                                if (er == 0)
                                {
                                    aux.dialogo("Error al eliminar folio", this.Text, 3);
                                    error = 1;
                                }
                            }
                            if (num != 0)
                            {
                                int sf = sql.ejecutar("INSERT INTO solicitud_folio VALUES(" + solicitud + "," + num + ")");
                                if (sf == 0)
                                {
                                    aux.dialogo("Error al ingresar folio", this.Text, 3);
                                    error = 1;
                                }
                            }
                            if (error == 0)
                            {
                                aux.dialogo("Solicitud actualizada exitosamente", this.Text, 2);
                                sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + seccion + ",1");
                                limpiar();
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
                    int exec = 0,error = 0;
                    if (sql.verificar("SELECT * FROM solicitud_folio WHERE id_solicitud = " + solicitud))
                    {
                        exec = sql.ejecutar("DELETE FROM solicitud_folio WHERE id_solicitud = " + solicitud);
                        if (exec == 0)
                        {
                            aux.dialogo("Error al intentar eliminar el folio", this.Text, 3);
                            error = 1;
                        }
                    }
                    if (error != 1)
                    {
                        exec = sql.ejecutar("DELETE FROM solicitud WHERE id_solicitud = " + solicitud);
                        if (exec > 0)
                        {
                            aux.dialogo("Solicitud eliminada exitosamente", this.Text, 2);
                            sql.llenar_grid(dat_solicitud, "EXEC ver_solicitud " + seccion + ",1");
                            limpiar();
                        }
                        else
                        {
                            aux.dialogo("No se pudo eliminar la solicitud", this.Text, 3);
                        }
                    }       
                }
            }
        }
    }
}
