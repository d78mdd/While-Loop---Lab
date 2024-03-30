using System;

namespace _08.Graduation_prev
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double ocenka = double.Parse(Console.ReadLine());

            int klas = 0;

            int skasan = 0;
            double sum = 0.0;
            sum += ocenka;
            if (ocenka <= 3)
            {
                skasan += 1;
            }

            if (ocenka >= 4)
            {
                klas++;
            }

            Console.WriteLine(klas + " " + sum + " " + ocenka + " " + skasan + " ");

            while (skasan < 2 && klas < 12)
            {
                if (ocenka >= 4)
                {
                    klas++;
                }

                ocenka = double.Parse(Console.ReadLine());
                if (ocenka <= 3)
                {
                    skasan += 1;
                }
                sum += ocenka;

                Console.WriteLine(klas + " " + sum + " " + ocenka + " " + skasan + " ");
            }

            double average = sum / 12;

            if (average >= 4.00)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {klas} grade");
            }
        }
    }
}
