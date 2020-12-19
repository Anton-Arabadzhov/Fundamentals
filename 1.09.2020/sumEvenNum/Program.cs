using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int curNum = nums[i];
                if (curNum % 2 == 0)
                {
                    sum += curNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
