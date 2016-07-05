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
            RNConjunto aux = A;
            for(int i = 0; i < B.Pn; i++)
            {
                if(!aux.Existe(B.LeerVector(i).Num))
                {
                    aux.Insertar(B.LeerVector(i));
                }
            }

            aux.Ordenar();
            return aux;
        }

        public RNConjunto Intercepcion(RNConjunto A, RNConjunto B)
        {
            return new RNConjunto();
        }

        public RNConjunto DiferenciaA(RNConjunto A, RNConjunto B)
        {
            return new RNConjunto();
        }

        public RNConjunto DiferenciaB(RNConjunto A, RNConjunto B)
        {
            return new RNConjunto();
        }

        public RNConjunto DiferenciaSimetrica(RNConjunto A, RNConjunto B)
        {
            return new RNConjunto();
        }

        public bool SubconjuntoAB(RNConjunto A, RNConjunto B)
        {
            return false;
        }

        public bool SubconjuntoBA(RNConjunto A, RNConjunto B)
        {
            return false;
        }
    }
}
