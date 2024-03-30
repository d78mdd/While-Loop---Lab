using System;

namespace _08.Graduation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int klas;
            double sum = 0.0;

            for (int i = 1; i <= 12; i++)
            {
                klas = i;

                double ocenka = double.Parse(Console.ReadLine());
                int skasan = 0;

                while (ocenka < 4.00)
                {
                    skasan++;
                    if (skasan > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {klas} grade");
                        return;
                    }
                    ocenka = double.Parse(Console.ReadLine());
                }

                sum += ocenka;
            }

            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}
