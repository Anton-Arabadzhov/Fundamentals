using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseArrayofString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split().ToArray();

            Console.WriteLine(string.Join(" ", symbols.Reverse()));

        }
    }
}
