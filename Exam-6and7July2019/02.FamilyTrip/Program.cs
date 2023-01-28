using System;

namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int night = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            double percentCosts = double.Parse(Console.ReadLine());

            double totalPriceNights = night * priceNight;
            if (night > 7)
            {
                totalPriceNights -= totalPriceNights * 0.05;
            }
            double budgetWithoutCosts = budget - (budget - (budget * (percentCosts / 100)));
            double total = budgetWithoutCosts + totalPriceNights;
            if (total > budget)
            {
                double moneyNeeded = total - budget;
                Console.WriteLine($"{moneyNeeded:f2} leva needed.");
            }
            else
            {
                double moneyLeft = budget - total;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
        }
    }
}
