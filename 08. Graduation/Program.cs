using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();


            int klas = 0;
            double sum = 0.0;

            bool izkluchen = false;

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
                        izkluchen = true;
                        break;
                    }
                    ocenka = double.Parse(Console.ReadLine());
                }

                if (izkluchen)
                {
                    break;
                }

                sum += ocenka;
            }


            if (!izkluchen)
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {klas} grade");
            }


        }
    }
}
