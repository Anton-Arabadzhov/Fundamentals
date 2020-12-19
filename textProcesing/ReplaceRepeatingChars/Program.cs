using System;
using System.Linq;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                char currchar = input[i];
                char currchar1 = input[i + 1];

                if (currchar != currchar1)
                {
                    result += currchar;
                }
                
                
            }
            char ch = input[input.Length - 1];
            result+=ch;

            Console.WriteLine(result);
        }
    }
}
