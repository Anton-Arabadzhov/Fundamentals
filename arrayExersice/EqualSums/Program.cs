using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = true;

            for (int curr = 0; curr < arr.Length; curr++)
            {
                int rightSum = 0;

                for (int i = curr + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }
                int leftSum = 0;
                for (int j = curr - 1; j >= 0; j--)
                {
                    leftSum += arr[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(curr);
                    isFound = false;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
