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
    public partial class frm_rep_buscar : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();

        public frm_rep_buscar()
        {
            InitializeComponent();
        }

        private void frm_rep_buscar_Load(object sender, EventArgs e)
        {
            sql.llenar_combo(cmb_seccion, "SELECT * FROM seccion ORDER BY nombre", "seccion", "nombre", "id_seccion");
            opt_rep_todas.Checked = true;
            opt_sec_todas.Checked = true;
            dtp_fecha.Value = DateTime.Today;
            dtp_fecha.MaxDate = DateTime.Today;
        }

        private void opt_sec_una_CheckedChanged(object sender, EventArgs e)
        {
            cmb_seccion.Enabled = opt_sec_una.Checked;
        }

        private void cmd_imprimir_Click(object sender, EventArgs e)
        {
            if (opt_rep_ranking.Checked)
            {
                frm_ranking_responsables ranking = new frm_ranking_responsables();
                ranking.fecha = dtp_fecha.Value;
                ranking.ShowDialog(this);
            }
            else
            {
                int id_seccion = 0, id_estado_mantencion = 0;
                if (opt_rep_pendientes.Checked)
                {
                    id_estado_mantencion = 1;
                }
                else if (opt_rep_finalizadas.Checked)
                {
                    id_estado_mantencion = 2;
                }
                else if (opt_rep_todas.Checked)
                {
                    id_estado_mantencion = 0;
                }
                if (opt_sec_una.Checked)
                {
                    id_seccion = int.Parse(cmb_seccion.SelectedValue.ToString());
                }
                else if (opt_sec_todas.Checked)
                {
                    id_seccion = 0;
                }
                String consulta = "";
                if (id_estado_mantencion != 0 && id_seccion != 0)
                {
                    consulta = "SELECT COUNT(*) FROM mantencion man INNER JOIN solicitud sol ON man.id_solicitud=sol.id_solicitud ";
                    consulta += "WHERE man.id_estado_mantencion = " + id_estado_mantencion + " AND sol.id_seccion = " + id_seccion;
                }
                else if (id_estado_mantencion != 0 && id_seccion == 0)
                {
                    consulta = "SELECT COUNT(*) FROM mantencion man INNER JOIN solicitud sol ON man.id_solicitud=sol.id_solicitud ";
                    consulta += "WHERE man.id_estado_mantencion = " + id_estado_mantencion;
                }
                else if (id_estado_mantencion == 0 && id_seccion != 0)
                {
                    consulta = "SELECT COUNT(*) FROM mantencion man INNER JOIN solicitud sol ON man.id_solicitud=sol.id_solicitud ";
                    consulta += "WHERE man.id_estado_mantencion <> 3 AND sol.id_seccion = " + id_seccion;
                }
                else
                {
                    consulta = "SELECT COUNT(*) FROM mantencion man INNER JOIN solicitud sol ON man.id_solicitud=sol.id_solicitud ";
                    consulta += "WHERE man.id_estado_mantencion <> 3";
                }
                SqlDataReader contar = sql.consulta(consulta);
                contar.Read();
                int a = contar.GetInt32(0);
                contar.Dispose();
                if (a > 0)
                {
                    frm_imprimir_actividades reporte = new frm_imprimir_actividades();
                    reporte.id_estado_mantencion = id_estado_mantencion;
                    reporte.id_seccion = id_seccion;
                    reporte.ShowDialog(this);
                }
                else
                {
                    aux.dialogo("No hay datos con los criterios seleccionados", this.Text, 3);
                }
            }         
        }

        private void frm_rep_buscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setActividades(null);
            this.Dispose();
        }

        private void opt_rep_pendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rep_pendientes.Checked)
            {
                fra_seccion.Enabled = true;
                fra_fecha.Enabled = false;
            }
            else
            {
                fra_seccion.Enabled = false;
                fra_fecha.Enabled = true;
            }
        }

        private void opt_rep_finalizadas_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rep_finalizadas.Checked)
            {
                fra_seccion.Enabled = true;
                fra_fecha.Enabled = false;
            }
            else
            {
                fra_seccion.Enabled = false;
                fra_fecha.Enabled = true;
            }
        }

        private void opt_rep_todas_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rep_todas.Checked)
            {
                fra_seccion.Enabled = true;
                fra_fecha.Enabled = false;
            }
            else
            {
                fra_seccion.Enabled = false;
                fra_fecha.Enabled = true;
            }
        }

        private void opt_rep_ranking_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rep_ranking.Checked)
            {
                fra_seccion.Enabled = false;
                fra_fecha.Enabled = true;
            }
            else
            {
                fra_seccion.Enabled = true;
                fra_fecha.Enabled = false;
            }
        }
    }
}
