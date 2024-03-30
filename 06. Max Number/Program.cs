using System;

namespace _06.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int max = int.MinValue;

            while (input != "Stop")
            {
                int inputAsInt= int.Parse(input);
                
                if (inputAsInt > max)
                {
                    max = inputAsInt;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(max);

        }
    }
}
