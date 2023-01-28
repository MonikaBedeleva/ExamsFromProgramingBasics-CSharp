using System;

namespace _01.SeriesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int seasonsCnt = int.Parse(Console.ReadLine());
            int epsodCnt = int.Parse(Console.ReadLine());
            double normalEpisodTimeWithoutAdd = double.Parse(Console.ReadLine());

            double addForEpisod = normalEpisodTimeWithoutAdd * 0.20;
            double episodWithAdd = addForEpisod + normalEpisodTimeWithoutAdd;
            double specialEpisods = seasonsCnt * 10;

            double totalTime = episodWithAdd * epsodCnt * seasonsCnt + specialEpisods;
            Console.WriteLine($"Total time needed to watch the {movieName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
