using System;

namespace _05.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());


            for (int i = 0; i < jury; i++)
            {
                string personFromJury = Console.ReadLine();
                double pointsJury = double.Parse(Console.ReadLine());

                startingPoints += (personFromJury.Length * pointsJury) / 2;
                if (startingPoints > 1250.5)
                {
                    break;
                }
            }
            if (startingPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {startingPoints:f1}!");
            }
            else
            {
                double neededPoints = 1250.5 - startingPoints;
                Console.WriteLine($"Sorry, {name} you need {neededPoints:f1} more!");
            }
        }
    }
}