using System;
using System.Linq;
using System.Collections.Generic;


namespace WordsSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
           var num = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>() { synonym });
                }
                else
                {
                    words[word].Add(synonym);
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
