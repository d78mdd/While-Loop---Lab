using System;

namespace _01.Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "";

            for ( ; ; )
            {
                string check = Console.ReadLine();

                if (check == "Stop")
                {
                    break;
                }

                tekst = tekst + check + "\n";
            }

            Console.WriteLine(tekst);
        }
    }
}
