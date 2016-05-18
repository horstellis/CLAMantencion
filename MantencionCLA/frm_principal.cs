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
    public partial class frm_principal : Form
    {
        auxiliar aux = new auxiliar();
        public frm_principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            frm_mant_usuarios form = new frm_mant_usuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            util.setMenu(this);
            login.Show();
            this.Enabled = false;
        }

        private void solicitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mant_solicitante form = new frm_mant_solicitante();
            form.MdiParent = this;
            form.Show();
        }
    }
}
