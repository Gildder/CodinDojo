using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class RNEntero
    {
        public int Num { get; set; }

        public void entero()
        {
            Num = 0;
        }

        public void Entero(int num)
        {
            Num = num;
        }

        public Int64 Factorial()
        {
            Int64 fact = 1;
            for(int i = 1; i <= Num; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public Boolean Primo()
        {
            int Aux = Num;
            int a = 0, i;

            for (i = 1; i < (Aux + 1); i++)
            {
                if (Aux % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                return false;
            }
            else
            {
                return true;
            };
        }

        public Boolean Par()
        {
            return (Num % 2 == 0);
        }

        public Int32 Invertir()
        {
            Int32 Aux = Num;
            Int32 NuevoNumero=0;
            while(Aux>0){
                Int32 Digito=Aux%10;
                NuevoNumero=NuevoNumero*10+Digito;
                Aux=Aux/10;       
            }
            return NuevoNumero;
        }

        public bool Capicua()
        {
            string aux = "";
            string numero = Num.ToString();
            bool capicua = false;
            for(int i = 0; i < numero.Length; i++)
            {
                aux = numero.Substring(i, 1) + aux;
            }

            if(aux == numero)
            {
                capicua = true;
            }
            return capicua;
        }


    }
}
