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
    public partial class frm_imprimir_actividades : Form
    {
        public int id_seccion { get; set; }
        public int id_estado_mantencion { get; set; }
        public frm_imprimir_actividades()
        {
            InitializeComponent();
        }

        private void frm_imprimir_actividades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mantencionDataSet.listar_actividades' Puede moverla o quitarla según sea necesario.
            this.listar_actividadesTableAdapter.Fill(this.mantencionDataSet.listar_actividades,id_seccion,id_estado_mantencion);
            // TODO: esta línea de código carga datos en la tabla 'mantencionDataSet.listar_clasificacion' Puede moverla o quitarla según sea necesario.
            this.listar_clasificacionTableAdapter.Fill(this.mantencionDataSet.listar_clasificacion);
            this.reporte.RefreshReport();
            this.reporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
