using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7Calculadora
{
    public class Calculadora
    {

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Resta(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            if (b == 0)
            {
                return -1;
            }
            return a / b;
        }
    }
}
