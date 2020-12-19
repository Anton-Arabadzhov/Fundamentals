using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string curr = arr[i];
                int currCount = 1;

                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (curr == arr[k])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;

                    }

                }
                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
