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
    public partial class frm_listar_solicitudes : Form
    {
        private sql sql = new sql();

        public frm_listar_solicitudes()
        {
            InitializeComponent();
        }

        private void frm_listar_solicitudes_Load(object sender, EventArgs e)
        {
            dtp_desde.Value = DateTime.Now;
            dtp_desde.MaxDate = DateTime.Now;
            dtp_hasta.Value = DateTime.Now;
            dtp_hasta.MaxDate = DateTime.Now;
            sql.llenar_combo(cmb_solicitante, "SELECT * FROM solicitante ORDER BY nombre", "solicitante", "nombre", "id_solicitante");
        }

        private void cmd_lista_Click(object sender, EventArgs e)
        {
            int id_solicitante = int.Parse(cmb_solicitante.SelectedValue.ToString());
            DateTime finicio = dtp_desde.Value;
            DateTime ftermino = dtp_hasta.Value;
            this.listar_solcitudesTableAdapter.Fill(this.mantencionDataSet.listar_solcitudes,id_solicitante,finicio,ftermino);
            this.reportViewer1.RefreshReport();
        }

        private void frm_listar_solicitudes_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setSolicitudes(null);
            this.Dispose();
        }
    }
}
