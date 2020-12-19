using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roundingNumvers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 0;
                }
                Console.WriteLine($"{arr[i]} => {Convert.ToDecimal(Math.Round(arr[i], MidpointRounding.AwayFromZero))}");
            }
        }
    }
}
