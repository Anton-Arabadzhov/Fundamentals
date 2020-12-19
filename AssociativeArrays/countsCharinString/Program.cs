using System;
using System.Collections.Generic;

namespace countsCharinString
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char item in words)
            {
                if (item != ' ' && counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else if (item != ' ' && !counts.ContainsKey(item))
                {
                    counts.Add(item, 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
