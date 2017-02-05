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
    public partial class frm_especial1 : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private static String usuario = util.getInicio().ver_usuario();

        public frm_especial1()
        {
            InitializeComponent();
        }

        private void frm_especial1_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setEspecial1(null);
            this.Dispose();
        }

        private void llena_tabla(int op)
        {
            try
            {
                sql.llenar_grid(dat_especial, "EXEC ver_actividades " + op);
                dat_especial.Columns[4].Visible = false;
                dat_especial.Columns[5].Visible = false;
                dat_especial.Columns[5].Visible = false;
            }
            catch { }
        }

        private void cmd_lista_Click(object sender, EventArgs e)
        {
            llena_tabla(0);
        }

        private void frm_especial1_Load(object sender, EventArgs e)
        {
            try
            {
                sql.llenar_combo(cmb_seccion, "SELECT * FROM seccion ORDER BY nombre", "seccion", "nombre", "id_seccion");
                sql.llenar_combo(cmb_solicitante, "SELECT * FROM solicitante ORDER BY nombre", "solicitante", "nombre", "id_solicitante");
            }
            catch { }
        }

        private void cmb_seccion_DropDownClosed(object sender, EventArgs e)
        {
            if (cmb_seccion.SelectedIndex != -1)
            {
                llena_tabla(int.Parse(cmb_seccion.SelectedValue.ToString()));
            }
        }

        private void dat_especial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dat_especial.Rows[e.RowIndex];
            txt_mantencion.Text = fila.Cells[0].Value.ToString();
            txt_solicitud.Text = fila.Cells[1].Value.ToString();
            cmb_seccion.SelectedValue = int.Parse(fila.Cells[5].Value.ToString());
            cmb_solicitante.SelectedValue = int.Parse(fila.Cells[6].Value.ToString());
            int estado = int.Parse(fila.Cells[4].Value.ToString());
            if (estado == 1)
            {
                opt_pendiente.Checked = true;
            }
            else if (estado == 2)
            {
                opt_finalizado.Checked = true;
            }
            else if (estado == 3)
            {
                opt_eliminado.Checked = true;
            }
        }

        private void cmd_insertar_Click(object sender, EventArgs e)
        {
            int estado = 0;
            if(opt_pendiente.Checked)
            {
                estado = 1;
            }
            else if (opt_finalizado.Checked)
            {
                estado = 2;
            }
            else if (opt_eliminado.Checked)
            {
                estado = 3;
            }
            else
            {
                aux.dialogo("Debe seleccionar un estado", this.Text, 3);
                return;
            }

            if (txt_mantencion.TextLength > 0 && txt_solicitud.TextLength > 0)
            {
                String query = "UPDATE mantencion SET id_estado_mantencion = " + estado + " WHERE id_mantencion = " + txt_mantencion.Text;
                if (aux.dialogo("¿Desea cambiar el estado a la mantencion?", this.Text, 1) == DialogResult.Yes)
                {
                    if ((sql.ejecutar(query)) > 0)
                    {
                        sql.ejecutar("EXEC registro_mantencion " + txt_mantencion.Text + ",'" + usuario + "',4");
                        aux.dialogo("Estado cambiado", this.Text, 2);
                        llena_tabla(0);
                        limpia_campos();
                    }
                    else
                    {
                        aux.dialogo("No se cambio estado", this.Text, 3);
                    }
                }
            }
            else
            {
                aux.dialogo("Faltan campos", this.Text, 3);
            }
        }

        private void limpia_campos()
        {
            txt_mantencion.Clear();
            txt_solicitud.Clear();
            opt_pendiente.Checked = false;
            opt_finalizado.Checked = false;
            opt_eliminado.Checked = false;
        }
    }
}
