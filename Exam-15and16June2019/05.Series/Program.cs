using System;

namespace _05.Seriess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serial = int.Parse(Console.ReadLine());

            for (int i = 0; i < serial; i++)
            {
                string nameSerial = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (nameSerial == "Thrones")
                {
                    price -= price * 0.50;
                }
                else if (nameSerial == "Lucifer")
                {
                    price -= price * 0.40;
                }
                else if (nameSerial == "Protector")
                {
                    price -= price * 0.30;
                }
                else if (nameSerial == "TotalDrama")
                {
                    price -= price * 0.20;
                }
                else if (nameSerial == "Area")
                {
                    price -= price * 0.10;
                }

                budget -= price;
            }
            if (budget >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
            }
        }
    }
}