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
    public partial class frm_activa_usuario : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();

        public frm_activa_usuario()
        {
            InitializeComponent();
        }

        public void setUsuarioActivo(String usuario_activo)
        {
            this.lbl_usuario_activo.Text = usuario_activo;
        }

        private void cmd_salir_Click(object sender, EventArgs e)
        {
            if (aux.dialogo("¿Desea cancelar la activación?", this.Text, 1) == DialogResult.Yes)
            {
                util.getInicio().Show();
                this.Dispose();
            }
        }

        private void cmd_ingreso_Click(object sender, EventArgs e)
        {
            if (txt_nueva_1.Text.Trim().Length < 6)
            {
                aux.dialogo("Clave debe tener como mínimo 6 caracteres", this.Text, 3);
                txt_nueva_1.SelectAll();
                txt_nueva_1.Focus();
            }
            else if (!txt_nueva_1.Text.Trim().Equals(txt_nueva_2.Text.Trim()))
            {
                aux.dialogo("Claves no son iguales", this.Text, 3);
                txt_nueva_1.Clear();
                txt_nueva_2.Clear();
                txt_nueva_1.Focus();
            }
            else
            {
                int exec = sql.ejecutar("UPDATE usuarios SET pass = '" + txt_nueva_1.Text.Trim() + "', id_estado = 1 WHERE usuario = '" + lbl_usuario_activo.Text + "'");
                if (exec > 0)
                {
                    aux.dialogo("Clave actualizada y usuario activado", this.Text, 2);
                    util.getInicio().Show();
                    util.getInicio().activar();
                    this.Dispose();
                }
                else
                {
                    aux.dialogo("No se pudo activar usuario", this.Text, 3);
                }
            }
        }
    }
}
