using System;
using System.Collections.Generic;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstword = input[0];
            string secondword = input[1];

            string longestWord = firstword;
            string shortless = secondword;

            if (firstword.Length <= secondword.Length)
            {
                longestWord = secondword;
                shortless = firstword;
            }
            var total = charManipulator(longestWord, shortless);
            Console.WriteLine(total);
            
        }
        public static int charManipulator(string longestWord, string shorterWord)
        {
            var sum = 0;
            for (int i = 0; i < shorterWord.Length; i++)
            {
                var multyplay = longestWord[i] * shorterWord[i];
                sum += multyplay;
            }
            for (int i = shorterWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }
            return sum;
        }
    }
}
