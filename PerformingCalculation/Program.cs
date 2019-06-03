using System;

namespace PerformingCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("It's a mistake. Try once more;)");
            }
            else
            {
                var firsNumber = int.Parse(args[0]);
                var secondNumber = int.Parse(args[1]);

                Console.WriteLine($"Amount from calculator application = {firsNumber + secondNumber}");
            }
        }
    }
}
