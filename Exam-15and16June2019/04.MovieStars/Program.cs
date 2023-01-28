using System;

namespace _04.MovieStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            bool budgetEnd = false;
            string comand;
            while ((comand = Console.ReadLine()) != "ACTION")
            {
                string name = comand;
                double price = 0;

                if (name.Length > 15)
                {
                    price = budget * 0.20;
                }
                else
                {
                    price = double.Parse(Console.ReadLine());
                    
                }

                budget -= price;
               
                if (budget <= 0)
                {                    
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    budgetEnd = true;
                    break;
                }               
            }
            if (!budgetEnd)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            
        }
    }
}
