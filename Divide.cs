using System;

namespace DivideByZero
{
    class Divide
    {
        static void Main(string[] args)
        {
            // Get the numerator
            Console.Write("Please enter an integer numerator: ");
            var numerator = int.Parse(Console.ReadLine());

            // Get denominator
            Console.Write("Please enter an integer denominator: ");
            var denominator = int.Parse(Console.ReadLine());

            // Divide the two integers, then display the result
            var result = numerator / denominator;
            Console.WriteLine(
                $"\nResult: {numerator} / {denominator} = {result}");
        }
    }
}
