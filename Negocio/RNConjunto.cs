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
            return new RNConjunto();
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
