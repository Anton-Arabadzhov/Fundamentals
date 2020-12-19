using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysPlunder = double.Parse(Console.ReadLine());
            double daylyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            if (daylyPlunder > 50)
            {
                daylyPlunder = 50;
            }
            double result = 0;

            for (int i = 1; i <= daysPlunder; i++)
            {
                

                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        result += daylyPlunder;
                        result += daylyPlunder / 2;
                    }
                    else if (i % 5 == 0 && i %3 != 0)
                    {
                        result += daylyPlunder;
                        result *= 0.7;
                    }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    result += daylyPlunder;
                    result += daylyPlunder / 2;
                    result *= 0.7;
                }
               
                     else
                    {
                        result += daylyPlunder;
                    }
                
               
            }
            Convert.ToDecimal(result);
            if (result >= expectedPlunder)
            {
                
                Console.WriteLine($"Ahoy! {result:f2} plunder gained.");
            }
            else
            {
                result = (result / expectedPlunder) * 100.0;
                

                Console.WriteLine($"Collected only {result:f2}% of the plunder.");
            }
            
        }
    }
}
