using System;

namespace _01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            double entranceCharge = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalChargeEntrance = peopleCnt * entranceCharge;
            double totalUmbrellas = Math.Ceiling ((double)peopleCnt / 2);
            double priceForUmbrella = totalUmbrellas * umbrellaPrice;
            double totalLoungePrice = Math.Ceiling(peopleCnt * 0.75) * loungePrice;

            double totalSum = totalChargeEntrance + priceForUmbrella + totalLoungePrice;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
