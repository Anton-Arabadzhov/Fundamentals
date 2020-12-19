using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            if (sorted.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", sorted));
            }
        }
    }
}
