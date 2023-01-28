using System;

namespace _06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int winnerPoints = 0;
            string winnerName = "";

            string comand;
            while ((comand = Console.ReadLine()) != "Stop")
            {
                string name = comand;
                int currentPoints = 0;
                
                for (int i = 0; i < name.Length; i++)
                {                   
                    int number = int.Parse(Console.ReadLine());

                    if (number == name[i])
                    {
                        currentPoints += 10;
                    }
                    else
                    {
                        currentPoints += 2;
                    }

                    if (currentPoints >= winnerPoints)
                    {
                        winnerPoints = currentPoints;
                        winnerName = name;
                    }
                }              
            }
            Console.WriteLine($"The winner is {winnerName} with {winnerPoints} points!");
           
        }
    }
}
