using System;

namespace _06.TheMostPowerfulWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mostPowerfullWord = 0;
            string powerfulWord = "";

            string comand;
            while ((comand = Console.ReadLine()) != "End of words")
            {
                string word = comand;
                double wordPower = 0;
                
                for (int i = 0; i < word.Length; i++)
                {
                    wordPower += word[i];
                }

                int numberLength = word.Length;
                string firstLetter = word.ToLower();
                
                if (firstLetter[0] == 'a' || firstLetter[0] == 'o' || firstLetter[0] == 'e' || firstLetter[0] == 'u' || firstLetter[0] == 'i' || firstLetter[0] == 'y')
                {
                    wordPower = wordPower * numberLength;
                    if (wordPower > mostPowerfullWord)
                    {
                        mostPowerfullWord = wordPower;
                        powerfulWord = word;
                    }
                }
                else
                {
                    wordPower = Math.Floor (wordPower / numberLength);
                    if (wordPower > mostPowerfullWord)
                    {
                        mostPowerfullWord = wordPower;
                        powerfulWord = word;
                    }
                }               
            }
            Console.WriteLine($"The most powerful word is {powerfulWord} - {mostPowerfullWord}");
        }
    }
}
