using System;

namespace _05.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "NoMoreMoney")
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                double inputAsDouble = double.Parse(input);
                sum += inputAsDouble;

                Console.WriteLine($"Increase: {inputAsDouble:F2}");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
