using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int curNumber = numbers[i];
                if (curNumber % 2 == 0)
                {
                    evenSum += curNumber;
                }
                else
                {
                    oddSum += curNumber;
                }
            }
            int diference = evenSum - oddSum;
            Console.WriteLine(diference);
        }
    }
}
