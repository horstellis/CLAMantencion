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
    public partial class frm_imprimir_solicitud : Form
    {
        public int id_solicitud { get; set; }
        public frm_imprimir_solicitud()
        {
            InitializeComponent();
        }

        private void frm_imprimir_solicitud_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mantencionDataSet.imprimir_solicitud' Puede moverla o quitarla según sea necesario.
            this.mantencionDataSet.EnforceConstraints = false;
            this.imprimir_solicitudTableAdapter.Fill(this.mantencionDataSet.imprimir_solicitud, id_solicitud);
            this.reportViewer1.RefreshReport();
        }
    }
}
