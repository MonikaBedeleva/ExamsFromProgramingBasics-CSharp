using System;

namespace _04.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomPlaces = int.Parse(Console.ReadLine());

            bool fullCinema = false;
            double ticketPrice = 0;
            string comand;
            while ((comand = Console.ReadLine()) != "Movie time!")
            {
                int peopleCnt = int.Parse(comand);
                roomPlaces -= peopleCnt;
                if (0 > roomPlaces)
                {
                    Console.WriteLine("The cinema is full.");
                    fullCinema = true;
                    break;
                }

                if (peopleCnt % 3 == 0)
                {
                    ticketPrice += (peopleCnt * 5 - 5);
                }
                else
                {
                    ticketPrice += peopleCnt * 5;
                }             
            }

            if (!fullCinema)
            {               
                Console.WriteLine($"There are {roomPlaces} seats left in the cinema.");
            }
            
            Console.WriteLine($"Cinema income - {ticketPrice} lv.");
        }
    }
}
