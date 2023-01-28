using System;

namespace _04.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());

            double price = 0;

            string comand;
            while ((comand = Console.ReadLine()) != "Party!")
            {
                double priceDrink = 0;
                int drinkCnt = int.Parse(Console.ReadLine());

                priceDrink = drinkCnt * comand.Length;
                
                if (priceDrink % 2 != 0)
                {
                    priceDrink -= priceDrink * 0.25;
                }
                price += priceDrink;

                if (price >= profit)
                {                    
                    break;
                }
                
            }
            if (comand == "Party!")
            {
                double neededSum = profit - price;
                Console.WriteLine($"We need {neededSum:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {price:f2} leva.");
        }
    }
}
