using System;

namespace _05.PCGameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hearthstone = 0;
            int fornite = 0;
            int overwatch = 0;
            int others = 0;

            for (int i = 0; i < n; i++)
            {
                string nameGame = Console.ReadLine();

                if (nameGame == "Hearthstone")
                {
                    hearthstone += 1;
                }
                else if (nameGame == "Fornite")
                {
                    fornite += 1;
                }
                else if (nameGame == "Overwatch")
                {
                    overwatch += 1;
                }
                else
                {
                    others += 1;
                }
            }
            double percent = 100 / (n * 1.0);
           
            Console.WriteLine($"Hearthstone - {percent * hearthstone:f2}%");
            Console.WriteLine($"Fornite - {percent * fornite:f2}%");
            Console.WriteLine($"Overwatch - {percent * overwatch:f2}%");
            Console.WriteLine($"Others - {percent * others:f2}%");

        }
    }
}
