using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    
        public static class Calculator
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Subtract(int a, int b)
            {
                return a - b;
            }

            public static int Multiply(int a, int b)
            {
                return a * b;
            }

            public static int Divide(int a, int b)
            {
                if (b == 0)
                {
                    throw new ArgumentException("Cannot divide by zero.");
                }

                return a / b;
            }
        
        }

}
