using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class RNVectorEntero
    {
        private RNEntero[] V;
        private int n;
        private int Max = 100;

        public int Pn
        {
            get { return n; }
            set { n = value; }
        }

        public RNVectorEntero()
        {
            V = new RNEntero[Max];
            n = 0;
        }

        public RNVectorEntero(int pos, int ele)
        {
            V = new RNEntero[Max];

            RNEntero entero = new RNEntero();
            entero.Entero(ele);

            V[pos] = entero;
        }

        public RNEntero LeerVector(int pos)
        {
            return V[pos];
        }

        public void Insertar(int pos, RNEntero ele)
        {
            V[pos] = ele;
            n++;
        }

        public void Insertar(int pos, int ele)
        {
            RNEntero entero = new RNEntero();
            entero.Entero(ele);

            V[pos] = entero;
            n++;
        }

        public bool Lleno()
        {
            if(n == Max)
            {
                return true;
            }
            return false;
        }

        public int ContarPrimosVector()
        {
            int contador = 0;
            for(int i = 0; i < n; i++)
            {
                if(V[i].Primo())
                {
                    contador++;
                }
            }

            return contador;
        }

        public int ContarCapicuaVector()
        {
            Int32 contador = 0;
            for(int i = 0; i < n; i++)
            {
                if(V[i].Capicua())
                {
                    contador++;
                }
            }

            return contador;
        }

        private void Intercacmbiar(RNEntero ele1, RNEntero ele2)
        {
            
        }

        public void Ordenar()
        {
            int salto = 0;
            int sw = 0;
            RNEntero aux;
            int e = 0;
            salto = n / 2;
            while(salto > 0)
            {
                sw = 1;
                while(sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while(e <= (n - salto))
                    {
                        if(V[e - 1].Num > V[(e - 1) + salto].Num)
                        {
                            aux = V[(e - 1) + salto];
                            V[(e - 1) + salto] = V[e - 1];
                            V[(e - 1)] = aux;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }

        public void Insertar(RNEntero ele)
        {
            V[n] = ele;
            n++;
        }

        public bool Existe(Int32 ele)
        {
            for(int i = 0; i < n; i++)
            {
                if(ele == V[i].Num)
                {
                    return true;
                }
            }
            return false;
        }

        public void FactorialVector()
        {
            for(int i = 0; i < n; i++)
            {
                V[i].Num = Convert.ToInt32(V[i].Factorial());
            }
        }

        public void InvertirVector()
        {
            int n_aux = n;
            for(int i = 0; i < n; i++, n_aux--)
            {
                RNEntero aux = V[i];
                V[i] = V[n_aux];
                V[n_aux] = aux;
            }
        }


        private void Eliminar(int pos)
        {
            RNEntero[] aux = new RNEntero[n - 1];
            Int32 index = 0;
            for(int i = 0; i < n; i++)
            {
                if(i != pos)
                {
                    aux[index] = V[i];
                    index++;
                }
            }

            V = aux;
            n--;
        }

        public string MostrarPrimoVector()
        {
            string primos = "";
            for(int i = 0; i < n; i++)
            {
                if(V[i].Primo())
                {
                    primos = primos + V[i].Num.ToString();
                }
            }

            return primos;
        }

        public decimal PromedioPrimos()
        {
            decimal promedio = 0;
            int total = 0;
            int contador = 0;
            for(int i = 0; i < n; i++)
            {
                if(V[i].Primo())
                {
                    total = total + V[i].Num;
                    contador++;
                }
            }

            promedio = total / contador;
            return promedio;
        }

        public string PromMay()
        {
            return "";
        }

        public string PromMenorIgual()
        {
            return "";
        }

        public int ContarPares()
        {
            int contador = 0;
            for(int i = 0; i < n; i++)
            {
                if(V[i].Par())
                {
                    contador++;
                }
            }

            return contador;
        }

        public decimal PromedioImpares()
        {
            decimal promedio = 0;
            int total = 0;
            int contador = 0;
            for(int i = 0; i < n; i++)
            {
                if(!V[i].Par())
                {
                    total = total + V[i].Num;
                    contador++;
                }
            }

            promedio = total / contador;
            return promedio;
        }
        
        public void EliminarCapicuas()
        {
            Int32 i = 0;
            while( i < n )
            {
                if(V[i].Capicua())
                {
                    Eliminar(i);
                }
                else
                {
                    i++;
                }
            }
        }

        public bool ContarNum(RNEntero ele)
        {
            for(int i = 0; i < n; i++)
            {
                if(ele.Num == V[i].Num)
                {
                    return true;
                }
            }
            return false;
        }

        public void EliminarRepetidos()
        {
            int i = 0;
            while( i < n)
            {
                int j = i + 1;
                while( j < n)
                {
                    if(V[i].Num == V[j].Num)
                    {
                        Eliminar(j);
                    }
                    else
                    {
                        j++;
                    }
                }
                i++;
            }
        }

        public void EliminarPrimos()
        {
            Int32 i = 0;
            while(i < n)
            {
                if(V[i].Primo())
                {
                    Eliminar(i);
                }
                else
                {
                    i++;
                }
            }
        }

        public string SepararNumCapicuasPrimos()
        {
            string primos = "Primos: ";
            string capicuas = "Capicuas: ";
            for(int i = 0; i < n; i++)
            {
                if(V[i].Primo())
                {
                    primos = primos + V[i].Num.ToString();
                }

                if(V[i].Capicua())
                {
                    capicuas = capicuas + V[i].Num.ToString();
                }
            }
            return primos +" - "+ capicuas;
        }

        public bool CompararIgual(Int32[] ordenados)
        {
            for(int i = 0; i < n; i++)
            {
                if(V[i].Num != ordenados[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
