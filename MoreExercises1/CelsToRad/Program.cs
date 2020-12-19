using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsToRad
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double radians = (celsius * 18) / 10 + 32;

            Console.WriteLine("{0:f2}", radians);
        }
    }
}
