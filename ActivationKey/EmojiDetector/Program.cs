using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string Emojypattern = @"(:{2}|\*{2})([A-Z][a-z]{2,}\1)";
            string Numberpattern = @"\d";

            string input = Console.ReadLine();

            Regex regex = new Regex(Emojypattern);
            Regex regexNumbers = new Regex(Numberpattern);
            long coolHold = 1;
            regexNumbers.Matches(input)
                .Select(b =>b.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolHold *= x);

            MatchCollection matches = regex.Matches(input);
            int totalEmojis = matches.Count;
            List<string> coolEmojies = new List<string>();
            foreach (Match match in matches)
            {
               long coolIndex = match.Value.Substring(2, match.Value.Length - 4)
                    .ToCharArray()
                    .Sum(a => (int)a);

                if (coolIndex > coolHold)
                {
                    coolEmojies.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolHold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmojies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
