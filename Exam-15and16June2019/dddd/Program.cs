﻿using System;

namespace _04.Movie_Stars
{
    class P04_MovieStars
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command;
            bool endBudget = false;
            while ((command = Console.ReadLine()) != "ACTION")
            {
                string actor = command;
                double salary = 0;
                if (actor.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    salary = 0.20 * budget;
                }
                budget -= salary;
                if (budget <= 0)
                {

                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    endBudget = true;
                    break;
                }                
            }
            if (!endBudget)
            {
                Console.WriteLine($"We are left with {budget:F2} leva.");
            }
        }
    }
}
