using System;

namespace _03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimumSum = int.Parse(Console.ReadLine());

            int numberToAdd = int.Parse(Console.ReadLine());

            int actualSum = 0;
            actualSum += numberToAdd;

            while (actualSum < minimumSum)
            {
                numberToAdd = int.Parse(Console.ReadLine());
             
                actualSum += numberToAdd;
            }

            Console.WriteLine(actualSum);

        }
    }
}
