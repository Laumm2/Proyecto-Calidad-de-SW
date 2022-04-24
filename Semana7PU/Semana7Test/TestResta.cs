using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace Semana7Test
{
    class TestResta
    {
        [DataRow(-10, -8, -2)]
        [DataRow(100, -1, 101)]
        [DataRow(95, 5, 90)]
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
