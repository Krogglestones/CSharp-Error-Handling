using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occoured during calculation.";

        public CalculationException() : base(DefaultMessage)
        {

        }

        public CalculationException(string message) : base(message)
        {

        }

        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }

        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
