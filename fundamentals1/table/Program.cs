using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                int sum = num * x;
                Console.WriteLine($"{num} X {x} = {sum}");
                x++;
                if (x > 10)
                {
                    break;
                }
            }
        }
    }
}
