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
            // Metodo para validar teclas ingresadas en los textbox, forma normal
            switch (tipo)
            {
                case 1:
                    // Solo numeros (0-9) y teclas de control
                    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 2:
                    // Solo letras y teclas de control
                    if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 3:
                    // Solo numeros (0-9), letras y teclas de control
                    if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                default:
                    return true;
            }
        }

        public Boolean valida_teclas(String cadena, KeyPressEventArgs e)
        {
            // Metodo sobrecargado para incluir cadena, no usa Switch
            if (cadena.Contains(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean valida_user(KeyPressEventArgs e)
        {
            String cadena = "abcdefghijklmnopqrstuvwxyz";
            cadena += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            cadena += ".";
            if (cadena.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean valida_pass(KeyPressEventArgs e)
        {
            String cadena = "abcdefghijklmnopqrstuvwxyz";
            cadena += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            cadena += "0123456789";
            if (cadena.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cambia_tecla(KeyPressEventArgs e)
        {
            //Metodo que permite cambiar Enter por TAB
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        //public DateTime numero_fecha(int numero)
        //{
        //    String strNum = numero.ToString();
        //    int dia, mes, anio;

        //    DateTime fecha = DateTime.Now;

        //    try
        //    {
        //        //If date is not in valid format 
        //        if (strNum.Length == 7) strNum = "0" + strNum;
        //        mes = Convert.ToInt32(strNum.Substring(0, 2));
        //        dia = Convert.ToInt32(strNum.Substring(2, 2));
        //        anio = Convert.ToInt32(strNum.Substring(4, 4));
        //        fecha = new DateTime(anio, mes, dia);
        //    }

        //    catch (Exception Ex)
        //    {
        //        //Ex.Message
        //    }

        //    return fecha;
        //}
    }
}
