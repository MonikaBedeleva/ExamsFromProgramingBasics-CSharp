using System;

namespace _05.FootballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int gameCnt = int.Parse(Console.ReadLine());
            if (gameCnt == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
                return;
            }

            int points = 0;
            int wCnt = 0;
            int dCnt = 0;
            int lCnt = 0;

            for (int i = 0; i < gameCnt; i++)
            {
                string game = Console.ReadLine();
                if (game == "W")
                {
                    points += 3;
                    wCnt++;
                }
                else if (game == "D")
                {
                    points += 1;
                    dCnt++;
                }
                else if (game == "L")
                {
                    lCnt++;
                }
            }
            double percentWinGames = wCnt * 1.0 / gameCnt * 100;                  

            Console.WriteLine($"{teamName} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wCnt}");
            Console.WriteLine($"## D: {dCnt}");
            Console.WriteLine($"## L: {lCnt}");
            Console.WriteLine($"Win rate: {percentWinGames:f2}%");
        }
    }
}
