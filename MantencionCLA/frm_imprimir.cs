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
    public partial class frm_imprimir : Form
    {
        public frm_imprimir()
        {
            InitializeComponent();
        }

        private void frm_imprimir_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mantencionDataSet.lista_usuarios' Puede moverla o quitarla según sea necesario.
            this.lista_usuariosTableAdapter.Fill(this.mantencionDataSet.lista_usuarios);
            visor.LocalReport.ReportEmbeddedResource = "MantencionCLA.rpt_usuarios.rdlc";
            this.visor.RefreshReport();
        }
    }
}
