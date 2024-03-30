using System;

namespace _01.Read_Text_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "";

            string check = "";

            while (check != "Stop")
            {

                tekst = tekst + check + "\n";

                check = Console.ReadLine();

            }

            Console.WriteLine(tekst);
        }
    }
}
