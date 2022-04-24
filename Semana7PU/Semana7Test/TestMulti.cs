using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace Semana7Test
{
    class TestMulti
    {
        [DataRow(10, 10, 100)]
        [DataRow(5, -3, -15)]
        [DataRow(-9, -9, 81)]
        [TestMethod]
        public void Multi_retonaValor(int a, int b, int esperado)
        {
            //arrange
            // int a = 10;
            //  int b = 8;
            // int esperado = 2;

            //Act

            int actual = Calculadora.multi(a, b);

            //Assert

            Assert.AreEqual(esperado, actual);

        }
    }
}
