using System;

namespace _03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string package = Console.ReadLine();
            string discount = Console.ReadLine();
            int daysCnt = int.Parse(Console.ReadLine());

            double priceForOneDay = 0;            

            if (cityName == "Bansko" || cityName == "Borovets")
            {
                if (package == "noEquipment")
                {
                    priceForOneDay = 80;
                    if (discount == "yes")
                    {
                        priceForOneDay -= priceForOneDay * 0.05;
                    }
                }
                else if (package == "withEquipment")
                {
                    priceForOneDay = 100;
                    if (discount == "yes")
                    {
                        priceForOneDay -= priceForOneDay * 0.1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if (cityName == "Varna" || cityName == "Burgas")
            {
                if (package == "noBreakfast")
                {
                    priceForOneDay = 100;
                    if (discount == "yes")
                    {
                        priceForOneDay -= priceForOneDay * 0.07;
                    }
                }
                else if (package == "withBreakfast")
                {
                    priceForOneDay = 130;
                    if (discount == "yes")
                    {
                        priceForOneDay -= priceForOneDay * 0.12;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            
            if (daysCnt > 7)
            {
                daysCnt -= 1;
            }
            else if (daysCnt <= 0)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            double totalPrice = priceForOneDay * daysCnt;
            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");

        }
    }
}
