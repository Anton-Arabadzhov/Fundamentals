using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double radians = (Math.PI * celsius) / 180.0;

            Console.WriteLine($"{radians:f2}");
        }
    }
}
