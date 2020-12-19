using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddevesum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int digits = 1;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(digits);
                sum += digits;
                digits += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
