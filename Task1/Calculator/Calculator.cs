using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public static int Sum(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (a > 0 && b == int.MaxValue))
            {
                throw new ArgumentOutOfRangeException();
            }

            return a + b;
        }

        public static int Minus(int a, int b)
        {
            if (a == int.MinValue && b > 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return a - b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("B is equal to 0");
            }

            return a / b;
        }

        public static int Multiplication(int a, int b)
        {
            if ((a == int.MaxValue && b > 1) || (a > 1 && b == int.MaxValue))
            {
                throw new ArgumentOutOfRangeException();
            }

            return a * b;
        }
    }
}
