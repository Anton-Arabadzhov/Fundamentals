using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder final = new StringBuilder();
            string longNum = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            int leftResult = 0;

            if (num <= 0 || longNum == "")
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var item in longNum.Reverse())
            {
                int number = int.Parse(item.ToString());
                int result = number * num + leftResult;
                int leftdigit = result % 10;

                leftResult = result / 10;
               
                final.Insert(0, leftdigit);
            }
            if (leftResult > 0)
            {
                final.Insert(0, leftResult);
            }
            
            Console.WriteLine(final.ToString());
        }
    }
}
