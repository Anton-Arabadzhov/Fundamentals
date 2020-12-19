using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;

            int currsentNum = 0;
            int factSum = 0;
            while (number != 0)
            {
                currsentNum = number % 10;
                number /= 10;

                int facturel = 1;

                for (int i = 1; i <= currsentNum; i++)
                {
                    facturel *= i;
                }
                factSum += facturel;
            }
            string result = string.Empty;
            if (input == factSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            Console.WriteLine(result);
        }
    }
}
