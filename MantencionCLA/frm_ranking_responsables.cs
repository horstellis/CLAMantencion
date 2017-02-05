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
    public partial class frm_ranking_responsables : Form
    {
        public DateTime fecha { get; set; }
        public frm_ranking_responsables()
        {
            InitializeComponent();
        }

        private void frm_ranking_responsables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mantencionDataSet.ranking_responsables' Puede moverla o quitarla según sea necesario.
            this.ranking_responsablesTableAdapter.Fill(this.mantencionDataSet.ranking_responsables,fecha);
            this.reporte.RefreshReport();
            this.reporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
