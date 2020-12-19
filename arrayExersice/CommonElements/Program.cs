using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            foreach (var item in secondArr)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (item == firstArr[i])
                    {
                        Console.Write(item + " ");
                    }
                }

            }
        }
    }
}
