using System;

namespace _04.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hight = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());  
            int percentNoColored = int.Parse(Console.ReadLine());
          
            int area = (hight * width) * 4;           

            double metersArea = Math.Ceiling (area - area * 1.0 * percentNoColored / 100);
           
            string comand;
            while ((comand = Console.ReadLine()) != "Tired!")
            {
                int paintLitres = int.Parse(comand);
                metersArea -= paintLitres;

                if (metersArea <= 0)
                {
                    break;
                }
            }
            if (metersArea == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            else if (metersArea < 0)
            {
                double leftPaint = -1 * metersArea;
                Console.WriteLine($"All walls are painted and you have {leftPaint} l paint left!");
                return;
            }
            else
            {
                Console.WriteLine($"{metersArea} quadratic m left.");
            }            
        }
    }
}
