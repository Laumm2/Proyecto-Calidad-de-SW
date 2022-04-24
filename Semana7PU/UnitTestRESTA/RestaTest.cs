using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace UnitTestRESTA
{
    [TestClass]
    public class RestaTest
    {
        [TestMethod]
        public void Resta_retonaValor(int a, int b, int esperado)
        {
            //arrange
            // int a = 10;
            //  int b = 8;
            // int esperado = 2;

            //Act

            int actual = Calculadora.resta(a, b);

            //Assert

            Assert.AreEqual(esperado, actual);

        }
    }
}
