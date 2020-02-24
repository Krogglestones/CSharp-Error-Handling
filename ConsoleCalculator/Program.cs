using System;
using static System.Console;


namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();

            try
            {
            int result = calculator.Calculate(number1, number2, operation);
            DisplayResult(result);
            }
            catch(ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                WriteLine($"Operation not provided.  {ex}");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                WriteLine($"That's not a math operator. {ex}");
            }
            catch (Exception ex)
            {
                WriteLine($"Something went wrong. {ex}");
            }
            finally
            {
                WriteLine("..finally");
            }


            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteLine($"Sorry, must shut down due to error.  Details {e.ExceptionObject}");
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
