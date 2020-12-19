using System;
using System.Linq;

namespace Digits_LettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char item in input)
            {
                char a = item;
                if (char.IsDigit(item))
                {
                    Console.Write(item);
                }
                
            }
            Console.WriteLine();
            foreach (var item in input)
            {
                char a = item;
                if (char.IsLetter(item))
                {
                    Console.Write(item);
                }
              
            }
            Console.WriteLine();
            foreach (var item in input)
            {
                char a = item;
                if (!char.IsLetterOrDigit(item))
                {
                    Console.Write(item);
                }
               
            }
        }
    }
}
