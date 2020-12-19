using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] userNames = Console.ReadLine().Split(", ");

            for (int i = 0; i < userNames.Length; i++)
            {
                string curr = userNames[i];
                if (isValid(curr))
                {
                    Console.WriteLine(curr);
                }
            }
        }
        public static bool isValid(string current)
        {
            return current.Length >= 3 && current.Length <= 16 && 
                current.All(c => char.IsLetterOrDigit(c) ||
                current.Contains("_")||
                current.Contains("-"));
        }
    }
}
