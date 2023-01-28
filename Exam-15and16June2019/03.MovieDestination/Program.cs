using System;
using System.IO;

namespace _03.MovieDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCnt = int.Parse(Console.ReadLine());

            double priceForOneDay = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    priceForOneDay += 45000;
                }
                else if (season == "Summer")
                {
                    priceForOneDay += 40000;
                }
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    priceForOneDay += 17000;
                }
                else if (season == "Summer")
                {
                    priceForOneDay += 12500;
                }
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    priceForOneDay += 24000;
                }
                else if (season == "Summer")
                {
                    priceForOneDay += 20250;
                }
            }

            double totalSum = daysCnt * priceForOneDay;
            if (destination == "Dubai")
            {
                totalSum -= totalSum * 0.30;
            }
            else if (destination == "Sofia")
            {
                totalSum += totalSum * 0.25;
            }

            if (totalSum <= budget)
            {
                double leftMoney = budget - totalSum;
                Console.WriteLine($"The budget for the movie is enough! We have {leftMoney:f2} leva left!");
            }
            else
            {
                double neededMoney = totalSum - budget;
                Console.WriteLine($"The director needs {neededMoney:f2} leva more!");
            }
        }
    }
}
