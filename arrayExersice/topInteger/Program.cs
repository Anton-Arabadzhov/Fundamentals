using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isBigger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currendnum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currendnum) 
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(currendnum + " ");
                }
                isBigger = true;
            }
        }
    }
}
