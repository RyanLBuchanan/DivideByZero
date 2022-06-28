using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class DivideByZeroExceptionHandling
    {
        static void Main(string[] args)
        {
            var continueLoop = true;  // Determines whether to keep looping

            do
            {
                // Retrieve user input and calculate the quotient
                try
                {
                    // int.Parse generates FormatException if argument cannot be converted to an integer
                    Console.Write("Enter an integer numerator: ");
                    var numerator = int.Parse(Console.ReadLine());
                    Console.Write("Enter an integer denominator: ");
                    var denominator = int.Parse(Console.ReadLine());

                    // Division generates DivideByZeroException if denominator is 0
                    var result = numerator / denominator;

                    // Display result
                    Console.WriteLine(
                        $"\nResult: {numerator} / {denominator} = {result}");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\n{formatException.Message}");
                    Console.WriteLine(
                        $"You must enter two integers. Please try again.\n");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine($"\n{divideByZeroException.Message}");
                    Console.WriteLine(
                        "Zero is an invalid denominator. Please try again.\n");
                }
            } while (continueLoop);
        }
    }
}
