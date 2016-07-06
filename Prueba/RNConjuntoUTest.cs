using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;

namespace Prueba
{
    [TestClass]
    public class RNConjuntoUTest
    {
        RNConjunto conjuntoA;
        RNConjunto conjuntoB;
        RNConjunto conjuntoR;

        [TestMethod]
        public void TestUnion()
        {
            conjuntoA = new RNConjunto();
            Int32[] A = { 2, 3, 12, 8, 23 };
            for(int i = 0; i < 5;i++ )
                conjuntoA.Insertar(i, A[i]);

            conjuntoB = new RNConjunto();
            Int32[] B = { 2, 11, 21, 2, 9 };
            for(int i = 0; i < 5; i++)
                conjuntoB.Insertar(i, B[i]);

            Int32[] union = { 2, 3, 8, 9, 11,12,21,23 };

            conjuntoR = new RNConjunto();
            conjuntoR = conjuntoR.Union(conjuntoA, conjuntoB);
            Assert.AreEqual(true, conjuntoR.CompararIgual(union), "Devuelve la true si la union es correcta");
        }
        
        [TestMethod]
        public void TestInterseccion()
        {
            conjuntoA = new RNConjunto();
            Int32[] A = { 2, 3, 12, 8, 23 };
            for(int i = 0; i < 5; i++)
                conjuntoA.Insertar(i, A[i]);

            conjuntoB = new RNConjunto();
            Int32[] B = { 2, 11, 21, 2, 9 };
            for(int i = 0; i < 5; i++)
                conjuntoB.Insertar(i, B[i]);

            Int32[] interseccion = { 2 };

            conjuntoR = new RNConjunto();
            conjuntoR = conjuntoR.Intercepcion(conjuntoA, conjuntoB);
            Assert.AreEqual(true, conjuntoR.CompararIgual(interseccion), "Devuelve la true si la interseccion es correcta");
        }

        [TestMethod]
        public void TestDiferenciaAB()
        {
            conjuntoA = new RNConjunto();
            Int32[] A = { 2, 3, 12, 8, 23 };
            for(int i = 0; i < 5; i++)
                conjuntoA.Insertar(i, A[i]);

            conjuntoB = new RNConjunto();
            Int32[] B = { 2, 11, 21, 2, 9 };
            for(int i = 0; i < 5; i++)
                conjuntoB.Insertar(i, B[i]);

            Int32[] diferenciaAB = { 3, 8, 12, 23 };

            conjuntoR = new RNConjunto();
            conjuntoR = conjuntoR.DiferenciaA(conjuntoA, conjuntoB);
            Assert.AreEqual(true, conjuntoR.CompararIgual(diferenciaAB), "Devuelve la true si la diferenciaAB es correcta");
        }

        [TestMethod]
        public void TestDiferenciaBA()
        {
            conjuntoA = new RNConjunto();
            Int32[] A = { 2, 3, 12, 8, 23 };
            for(int i = 0; i < 5; i++)
                conjuntoA.Insertar(i, A[i]);

            conjuntoB = new RNConjunto();
            Int32[] B = { 2, 11, 21, 2, 9 };
            for(int i = 0; i < 5; i++)
                conjuntoB.Insertar(i, B[i]);

            Int32[] diferenciaBA = { 9, 11, 21 };

            conjuntoR = new RNConjunto();
            conjuntoR = conjuntoR.DiferenciaB(conjuntoA, conjuntoB);
            Assert.AreEqual(true, conjuntoR.CompararIgual(diferenciaBA), "Devuelve la true si la diferenciaBA es correcta");
        }

        [TestMethod]
        public void TestDiferenciaSimetrica()
        {
            conjuntoA = new RNConjunto();
            Int32[] A = { 2, 3, 12, 8, 23 };
            for(int i = 0; i < 5; i++)
                conjuntoA.Insertar(i, A[i]);

            conjuntoB = new RNConjunto();
            Int32[] B = { 2, 11, 21, 2, 9 };
            for(int i = 0; i < 5; i++)
                conjuntoB.Insertar(i, B[i]);

            Int32[] diferenciaSimetrica = { 3, 8, 9, 11, 12, 21, 23 };

            conjuntoR = new RNConjunto();
            conjuntoR = conjuntoR.DiferenciaSimetrica(conjuntoA, conjuntoB);
            Assert.AreEqual(true, conjuntoR.CompararIgual(diferenciaSimetrica), "Devuelve la true si la diferencia simetrica es correcta");
        }

    }
}
