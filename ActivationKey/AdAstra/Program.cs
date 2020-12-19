using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|\|])([A-Za-z\s?A-Za-z]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(\d+)\1";
            string input = Console.ReadLine();

            Regex rexex = new Regex(pattern);

            var matches = Regex.Matches(input, pattern);
            int calories = 0;
            foreach (Match match in matches)
            {
                
                if (match.Success)
                {
                    int calProduct = int.Parse(match.Groups[4].Value);
                    calories += calProduct;
                }
                
            }
            Console.WriteLine($"You have food to last you for: {calories/2000} days!");
            foreach (Match match in matches)
            {
                string name = match.Groups[2].Value;
                string date = match.Groups[3].Value;
                int calori = int.Parse(match.Groups[4].Value);
                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calori}");
            }

        }
    }
}
