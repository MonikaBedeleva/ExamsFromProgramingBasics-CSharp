using System;
using System.Net.NetworkInformation;

namespace _03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string shugar = Console.ReadLine();
            int cntDrinks = int.Parse(Console.ReadLine());

            double priceDrink = 0;

            if (drink == "Espresso")
            {
                if (shugar == "Without")
                {
                    priceDrink += 0.90 - (0.90 * 0.35);
                }
                else if (shugar == "Normal")
                {
                    priceDrink += 1;
                }
                else if (shugar == "Extra")
                {
                    priceDrink += 1.20;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (shugar == "Without")
                {
                    priceDrink += 1 - (1 * 0.35);
                }
                else if (shugar == "Normal")
                {
                    priceDrink += 1.20;
                }
                else if (shugar == "Extra")
                {
                    priceDrink += 1.60;
                }
            }
            else if (drink == "Tea")
            {
                if (shugar == "Without")
                {
                    priceDrink += 0.50 - (0.50 * 0.35);
                }
                else if (shugar == "Normal")
                {
                    priceDrink += 0.60;
                }
                else if (shugar == "Extra")
                {
                    priceDrink += 0.70;
                }
            }

            double total = cntDrinks * priceDrink;

            if (cntDrinks >= 5 && drink == "Espresso")
            {
                total -= total * 0.25;
            }
            if (total > 15)
            {
                total -= total * 0.20;
            }
            Console.WriteLine($"You bought {cntDrinks} cups of {drink} for {total:f2} lv.");
        }
    }
}
