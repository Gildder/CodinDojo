using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion
{
    public class Validar
    {
        public static void OnlyNumeric(System.Windows.Forms.KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if(Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }


        public static void OnlyLetter(System.Windows.Forms.KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if(Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if(Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        public static void OnlyLetterSpace(System.Windows.Forms.KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if(Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if(Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }

        static int _decimales = 3;
        public int Decimales
        {
            get
            {
                return (_decimales);
            }
            set
            {
                _decimales = value;
            }
        }
       
        public static void OnlyNumericDec(
            System.Windows.Forms.TextBox _TextBox,
            System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            if(_TextBox.Text.Length == 0)
            {
                if((e.KeyChar == Convert.ToChar("-")))
                {
                    e.Handled = false;
                    return;
                }
            }
            bool IsDec = false;
            int nroDec = 0;
            for(int i = 0; i < _TextBox.Text.Length; i++)
            {
                if(_TextBox.Text == ".")
                    IsDec = true;

                if(IsDec && nroDec++ >= _decimales)
                {
                    e.Handled = true;
                    return;
                }
            }
            if(e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if(e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        public static void SinLetterNumeric(System.Windows.Forms.KeyPressEventArgs e)
        {
            //Para obligar a que no se introduzca nada
            if(!Char.IsDigit(e.KeyChar))
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
