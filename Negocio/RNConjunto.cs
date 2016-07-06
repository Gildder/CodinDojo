using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class RNConjunto : RNVectorEntero
    {
        public RNConjunto Union(RNConjunto A, RNConjunto B)
        {
            RNConjunto aux = new RNConjunto();
            for(int i = 0; i < B.Pn; i++)
            {
               aux.Insertar(B.LeerVector(i));
            }

            for(int i = 0; i < A.Pn; i++)
            {
                aux.Insertar(A.LeerVector(i));
            }

            aux.EliminarRepetidos();
            aux.Ordenar();
            return aux;
        }

        public RNConjunto Intercepcion(RNConjunto A, RNConjunto B)
        {
            RNConjunto aux = new RNConjunto();
            for(int i = 0; i < B.Pn; i++)
            {
                if(A.Existe(B.LeerVector(i).Num))
                {
                    aux.Insertar(B.LeerVector(i));
                }
            }

            aux.Ordenar();
            aux.EliminarRepetidos();
            return aux;
        }

        public RNConjunto DiferenciaA(RNConjunto A, RNConjunto B)
        {

            RNConjunto aux = new RNConjunto();
            for(int j = 0; j < A.Pn; j++)
            {
                if(!B.Existe(A.LeerVector(j).Num))
                {
                    aux.Insertar(A.LeerVector(j));
                }
            }

            aux.Ordenar();
            aux.EliminarRepetidos();
            return aux;
        }

        public RNConjunto DiferenciaB(RNConjunto A, RNConjunto B)
        {
            RNConjunto aux = new RNConjunto();
            for(int i = 0; i < B.Pn; i++)
            {
                if(!A.Existe(B.LeerVector(i).Num))
                {
                    aux.Insertar(B.LeerVector(i));
                }
            }

            aux.Ordenar();
            aux.EliminarRepetidos();
            return aux;
        }

        public RNConjunto DiferenciaSimetrica(RNConjunto A, RNConjunto B)
        {
            RNConjunto aux = new RNConjunto();
            A.EliminarRepetidos();
            B.EliminarRepetidos();
            for(int i = 0; i < B.Pn; i++)
            {
                if(!A.Existe(B.LeerVector(i).Num))
                {
                    aux.Insertar(B.LeerVector(i));
                }
            }

            for(int j = 0; j < A.Pn; j++)
            {
                if(!B.Existe(A.LeerVector(j).Num))
                {
                    aux.Insertar(A.LeerVector(j));
                }
            }

            aux.Ordenar();

            return aux;
        }

        public bool SubconjuntoAB(RNConjunto A, RNConjunto B)
        {
            bool b = true;
            RNConjunto aux = A;
            for(int i = 0; i < B.Pn; i++)
            {
                if(!A.Existe(B.LeerVector(i).Num))
                {
                    b = false;
                }
            }

            return b;
        }

        public bool SubconjuntoBA(RNConjunto A, RNConjunto B)
        {
            bool b = true;
            RNConjunto aux = B;
            for(int i = 0; i < A.Pn; i++)
            {
                if(!B.Existe(A.LeerVector(i).Num))
                {
                    b = false;
                }
            }

            return b;
        }
    }
}
