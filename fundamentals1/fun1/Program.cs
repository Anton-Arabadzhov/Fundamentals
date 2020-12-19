using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fun1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {ages}, Grade: {grade:f2}");
        }
    }
}
