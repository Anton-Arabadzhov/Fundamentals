using System;
using System.Collections.Generic;

namespace Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordIsLowerCase = word.ToLower();
                if (counts.ContainsKey(wordIsLowerCase))
                {
                    counts[wordIsLowerCase]++;
                }
                else
                {
                    counts.Add(wordIsLowerCase, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
                
            }
        }
    }
}
