using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {

            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (ArithmeticException ex)
                {
                    throw new CalculationException(ex);
                }

            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
