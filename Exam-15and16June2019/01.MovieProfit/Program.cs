using System;

namespace _01.MovieProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysCnt = int.Parse(Console.ReadLine());
            int ticketsCnt = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double cinemaPercent = double.Parse(Console.ReadLine());

            double Profit = (daysCnt * ticketsCnt) * ticketPrice;
            double cinemaProfit = Profit * cinemaPercent / 100;
            cinemaProfit = Profit - cinemaProfit;

            Console.WriteLine($"The profit from the movie {movieName} is {cinemaProfit:f2} lv.");
        }
    }
}
