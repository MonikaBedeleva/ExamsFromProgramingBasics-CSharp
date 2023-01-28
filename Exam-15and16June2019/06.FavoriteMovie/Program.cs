using System;

namespace _06.FavoriteMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie;

            int movieCnt = 0;
            string winnerMovie = "";
            int winnerPoints = int.MinValue;

            while ((movie = Console.ReadLine()) != "STOP")
            {
                movieCnt++;
                int sum = 0;
                for (int i = 0; i < movie.Length; i++)
                {
                    char currentLetter = movie[i];
                    if (currentLetter >= 65 && currentLetter <= 90)
                    {
                        sum += currentLetter - movie.Length;
                    }
                    else if (currentLetter >= 97 && currentLetter <= 122)
                    {
                        sum += currentLetter - (2 * movie.Length);
                    }
                    else
                    {
                        sum += currentLetter;
                    }
                }
                if (sum > winnerPoints)
                {
                    winnerPoints = sum;
                    winnerMovie = movie;
                }
                if (movieCnt == 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }
            }
            Console.WriteLine($"The best movie for you is {winnerMovie} with {winnerPoints} ASCII sum.");
        }
    }
}
