using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLenguage
{
    class Program
    {
        static void Main(string[] args)
        {
            string Country = Console.ReadLine();

            if (Country == "England" || Country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (Country == "Spain" || Country == "Argentina" || Country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
