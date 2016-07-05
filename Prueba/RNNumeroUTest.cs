using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;

namespace Prueba
{
    /// <summary>
    /// Descripción resumida de RNNumeroUTest
    /// </summary>
    [TestClass]
    public class RNNumeroUTest
    {
        Negocio.RNEntero N = new Negocio.RNEntero();

        public RNNumeroUTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        //Metodos del Negocio de la Clase RNNumero
       [TestMethod]
        public void EsPrimo()
        {
            N.Num = 200;
            Assert.AreEqual(false, N.Primo(), "Devuevle si Un numero es Primo");
        }

        [TestMethod]
        public void EsPar()
        {
            N.Num = 1235;
            Assert.AreEqual(false, N.Par(), "Devuevle si Un numero es Par");
        }

        [TestMethod]
        public void InvertirNumero()
        {
            N.Num = 12345;
            Assert.AreEqual(54321, N.Invertir(), "Devuelve el Numero Invertido");
        }
        
    }
}
