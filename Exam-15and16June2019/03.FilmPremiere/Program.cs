using System;

namespace _03.FilmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
                  //         John Wick    Star Wars    Jumanji
                  //Напитка  12 лв./бр.   18 лв./бр.   9 лв./бр.
                  //Пуканки  15 лв./бр.   25 лв./бр.   11 лв./бр.
                  //   Меню  19 лв./бр.   30 лв./бр.   14 лв./бр.

            string movieName = Console.ReadLine();
            string pack = Console.ReadLine();
            int ticketsCnt = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
           
            if (movieName == "John Wick")
            {
                if (pack == "Drink")
                {
                    ticketPrice += 12;
                }
                else if (pack == "Popcorn")
                {
                    ticketPrice += 15;
                }
                else if (pack == "Menu")
                {
                    ticketPrice += 19; 
                }
            }
            else if (movieName == "Star Wars")
            {
                if (pack == "Drink")
                {
                    ticketPrice += 18;
                }
                else if (pack == "Popcorn")
                {
                    ticketPrice += 25;
                }
                else if (pack == "Menu")
                {
                    ticketPrice += 30;
                }                
            }
            else if (movieName == "Jumanji")
            {
                if (pack == "Drink")
                {
                    ticketPrice += 9;
                }
                else if (pack == "Popcorn")
                {
                    ticketPrice += 11;
                }
                else if (pack == "Menu")
                {
                    ticketPrice += 14;
                }
            }
            double totalSum = ticketsCnt * ticketPrice;

            if (movieName == "Star Wars" && ticketsCnt >= 4)
            {
                totalSum -= totalSum * 0.30;
            }
            else if (movieName == "Jumanji" && ticketsCnt == 2)
            {
                totalSum -= totalSum * 0.15;
            }
            Console.WriteLine($"Your bill is {totalSum:f2} leva.");
        }
    }
}
