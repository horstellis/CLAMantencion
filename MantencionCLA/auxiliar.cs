using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantencionCLA
{
    public class auxiliar
    {
        public DialogResult dialogo(String mensaje, String titulo, int tipo)
        {
            DialogResult rs = new DialogResult();
            switch (tipo)
            {
                case 1:
                    rs = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                case 2:
                    rs = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    rs = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return rs;
        }

        public Boolean valida_teclas(KeyPressEventArgs e, int tipo)
        {
            //Metodo para validar teclas ingresadas en los textbox, forma normal
            Boolean resp = true;
            switch(tipo){
                case 1:
                    //Solo números (0-9) y teclas de control
                    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        resp = false;
                    }
                    else
                    {
                        resp = true;
                    }
                    break;
                case 2:
                    //Solo letras y teclas de control
                    if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        resp = false;
                    }
                    else
                    {
                        resp = true;
                    }
                    break;
                case 3:
                    //Solo números (0-9), letras y teclas de control
                    if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        resp = false;
                    }
                    else
                    {
                        resp = true;
                    }
                    break;
            }
            return resp;
        }
        public Boolean valida_teclas(String cadena, KeyPressEventArgs e)
        {
            //Metodo sobrecargado para incluir cadena, no usa Switch
            Boolean resp = true;
            if (cadena.Contains(e.KeyChar))
            {
                resp = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                resp = false;
            }
            else
            {
                resp = true;
            }
            return resp;
        }
    }
}
