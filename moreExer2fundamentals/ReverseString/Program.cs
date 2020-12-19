using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            string drow = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                drow += word[i];
            }
            Console.WriteLine(drow);
        }
    }
}
