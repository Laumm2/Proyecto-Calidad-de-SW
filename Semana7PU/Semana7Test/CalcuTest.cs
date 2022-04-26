using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace Semana7Test
{
    [TestClass]
    public class CalcuTest
    {
        [DataRow(4,4,8)]
        [DataRow(4, 0, 4)]
        [DataRow(0, 0, 0)]
        [TestMethod]
        public void Suma_retonaValor(int a,int b, int esperado)
        {
            //arrange
            //int a = 4;
            // int b = 4;
            // int esperado = 7;

            //Act
            int actual = Calculadora.suma(a, b);

            //Assert

            Assert.AreEqual(esperado, actual);

        }
        // Test Driven Development
        //programacion entre pares


        [DataRow(4, 4, 1)]
        [DataRow(4, 0, -1)]
        [DataRow(20, 5, 4)]
        [TestMethod]
        public void Div_retonaValor(int a, int b, int esperado)
        {
            //arrange
            //int a = 4;
            // int b = 4;
            // int esperado = 7;

            //Act
            int actual = Calculadora.div(a, b);

            //Assert

            Assert.AreEqual(esperado, actual);

        }


        [DataRow(4, 0, 0)]
        [TestMethod]
        public void Div_EntreCero(int a, int b, int esperado)
        {
            //arrange
            //int a = 4;
            // int b = 4;
            // int esperado = 7;

            //Act
            int actual = Calculadora.div(a, b);

            //Assert

            Assert.AreNotEqual(null, actual);

        }
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
