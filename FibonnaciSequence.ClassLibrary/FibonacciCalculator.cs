using System;
using System.Collections.Generic;
using System.Text;

namespace FibonnaciSequence.ClassLibrary
{
  public   class FibonacciCalculator
    {
        public int Fibonacci(int n)
        {
            
            if (n < 1 || n > 100)
            {
                return -1;

            }
            else
            {
                int firstNumber = 0, secondNumber = 1, nextNumber = 0;
                // To return the first Fibonacci number  
                if (n == 1)
                    return secondNumber;
                for (int i = 2; i <= n; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
                return secondNumber;
            }
        }
    }
}
