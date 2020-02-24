using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation { get; }

        public CalculationOperationNotSupportedException() : base("That's not a math operator.")
        {

        }

        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        public CalculationOperationNotSupportedException(string message, Exception innerException) : base (message, innerException)
        {

        }

        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }

        public override string Message
        {
            get
            {
                string message = base.Message;

                if(Operation != null)
                {
                    return message + Environment.NewLine + $"Unsupported operation: {Operation}";
                }

                return message;
            }
        }
    }
}
