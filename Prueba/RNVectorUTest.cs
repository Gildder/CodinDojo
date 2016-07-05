using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;

namespace Prueba
{
    [TestClass]
    public class RNVectorUTest
    {
        RNVectorEntero vector = new RNVectorEntero();
           

        [TestMethod]
        public void TestContarCapicuas()
        {
            Int32[] elemento = {2,34,22,45,23};
            for(int i = 0; i < 5;i++ )
                vector.Insertar(i,elemento[i]);

            Assert.AreEqual(2, vector.ContarCapicuaVector(), "Devuelve la cantidad de elementos capicuas");
        }
        
        [TestMethod]
        public void TestContarPrimos()
        {
            Int32[] elemento = { 2, 34, 7, 45, 23 };
            for(int i = 0; i < 5; i++)
                vector.Insertar(i, elemento[i]);

            Assert.AreEqual(3, vector.ContarPrimosVector(), "Devuelve la cantidad de elementos primos");
        }

        [TestMethod]
        public void TestOrdenarVector()
        {
            Int32[] elemento = { 12, 34, 22, 45, 23 };
            Int32[] ordenados = { 12, 22, 23, 34, 45 };

            for(int i = 0; i < 5; i++)
                vector.Insertar(i, elemento[i]);

            vector.Ordenar();
            Assert.AreEqual(true, vector.CompararIgual(ordenados), "Compara los elementos ordenados");
        }

        [TestMethod]
        public void TestEliminarCapicuas()
        {
            Int32[] elemento = { 0, 44, 22, 71, 23 };
            Int32[] eliminados = { 71, 23 };

            for(int i = 0; i < 5; i++)
                vector.Insertar(i, elemento[i]);

            vector.EliminarCapicuas();
            Assert.AreEqual(true, vector.CompararIgual(eliminados), "Compara dos vectores despues de eliminar");
        }

        [TestMethod]
        public void TestEliminarRepetidos()
        {
            Int32[] elemento = { 1, 44, 22, 22, 71, 23, 1 };
            Int32[] eliminados = { 1, 44, 22, 71, 23 };

            for(int i = 0; i < 5; i++)
                vector.Insertar(i, elemento[i]);

            vector.EliminarRepetidos();
            Assert.AreEqual(true, vector.CompararIgual(eliminados), "Compara dos vectores despues de eliminar");
        }

        [TestMethod]
        public void TestEliminarPrimos()
        {
            Int32[] elemento = { 43, 47, 53, 72, 25 };
            Int32[] eliminados = { 72, 25 };

            for(int i = 0; i < 5; i++)
                vector.Insertar(i, elemento[i]);

            vector.EliminarPrimos();
            Assert.AreEqual(true, vector.CompararIgual(eliminados), "Compara dos vectores despues de eliminar");
        }

        [TestMethod]
        public void TestBuscarElemento()
        {
            Int32[] elemento = { 12, 34, 22, 45, 23 };

            for(int i = 0; i < 5; i++)
                vector.Insertar(i, elemento[i]);
            
            Assert.AreEqual(false, vector.Existe(3), "Busca un elemento dentro del vector");
        }

    }
}
