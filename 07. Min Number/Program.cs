using System;

namespace _07.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int min = int.MaxValue;

            while (input != "Stop")
            {
                int inputAsInt = int.Parse(input);

                if (inputAsInt < min)
                {
                    min = inputAsInt;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(min);

        }
    }
}
