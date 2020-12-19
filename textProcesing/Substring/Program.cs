using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string shortword = Console.ReadLine().ToLower();
            string longWord = Console.ReadLine().ToLower();

            int index = longWord.IndexOf(shortword);

            while (index != -1)
            {
                longWord = longWord.Remove(index, shortword.Length);
                index = longWord.IndexOf(shortword);
            }
            Console.WriteLine(longWord);
        }
    }
}
