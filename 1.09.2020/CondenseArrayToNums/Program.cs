using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] condensed = new int[nums.Length - 1];
            int sum = 0;
            int count = nums.Length;
            int counter = 1;
            while (count > 1)
            {
                
                
                for (int i = 0; i < nums.Length - counter; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                    nums[i] = condensed[i];
                    sum = condensed[i];
                    
                }
                counter++;
                count--;
                
            }
            if (sum > 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(nums[0]);
            }

            
        }
    }
}
