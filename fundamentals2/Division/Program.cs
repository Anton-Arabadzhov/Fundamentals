using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int numResult = 0;

            if (num % 2 == 0)
            {
                numResult = 2;
            }
            if (num % 3 == 0)
            {
                numResult = 3;
            }
            if (num % 6 == 0)
            {
                numResult = 6;
            }
            if (num % 7 == 0)
            {
                numResult = 7;
            }
            if (num % 10 == 0)
            {
                numResult = 10;
            }
            if (numResult != 0)
            {
                Console.WriteLine($"The number is divisible by {numResult}");
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }
        }
    }
}
