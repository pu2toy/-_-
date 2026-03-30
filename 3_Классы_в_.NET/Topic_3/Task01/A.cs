using System;
namespace Task01
{
    public class A
    {
        private int a;
        private int b;

        public A(int num1, int num2)
        {
            a = num1;
            b = num2;
        }

        public int Difference()
        {
            return a - b;
        }

        public float Expression()
        {
            if ( a == b )
            {
                throw new DivideByZeroException("Деление на нуль!");
            }

            return (float)(a + b) / (a - b);
        }
    }
}

