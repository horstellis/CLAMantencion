using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantencionCLA
{
    class util
    {
        private static frm_login login;
        private static frm_principal menu;
        private static String usuario;

        public static void setLogin(frm_login login)
        {
            util.login = login;
        }

        public static frm_login getLogin()
        {
            return util.login;
        }

        public static void setMenu(frm_principal menu)
        {
            util.menu = menu;
        }

        public static frm_principal getMenu()
        {
            return util.menu;
        }

        public static void setUsuario(String usuario)
        {
            util.usuario = usuario;
        }

        public static String getUsuario()
        {
            return util.usuario;
        }

    }
}
