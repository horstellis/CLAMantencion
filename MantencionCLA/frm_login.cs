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
    public partial class frm_login : Form
    {
        auxiliar aux = new auxiliar();
        sql sql = new sql();
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            util.getMenu().Dispose();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Trim().Equals(""))
            {
                aux.dialogo("Debe ingresar un usuario", this.Text, 3);
                txt_usuario.Focus();
            }
            else if (txt_password.Text.Trim().Equals(""))
            {
                aux.dialogo("Debe ingresar una clave", this.Text, 3);
                txt_password.Focus();
            }
            else
            {
                if (sql.verificar("SELECT * FROM usuarios WHERE usuario = '" + txt_usuario.Text.Trim() + "'"))
                {
                    if (sql.verificar("SELECT * FROM usuarios WHERE usuario = '" + txt_usuario.Text.Trim() + "' AND pass = '" + txt_password.Text.Trim() + "'"))
                    {
                        SqlDataReader dr = sql.consulta("SELECT nombre FROM usuarios WHERE usuario = '" + txt_usuario.Text.Trim() + "'");
                        dr.Read();
                        aux.dialogo("Bienvenido "+dr[0].ToString(), this.Text, 2);
                        util.getMenu().Enabled = true;
                        this.Dispose();
                        util.getMenu().Focus();
                    }
                    else
                    {
                        aux.dialogo("Clave incorrecta", this.Text, 3);
                        txt_password.SelectAll();
                        txt_password.Focus();
                    }
                }
                else
                {
                    aux.dialogo("Usuario no existe", this.Text, 3);
                    txt_password.Clear();
                    txt_usuario.SelectAll();
                    txt_usuario.Focus();
                }
            }
        }
    }
}
