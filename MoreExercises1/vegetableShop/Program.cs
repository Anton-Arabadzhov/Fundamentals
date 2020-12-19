using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetableShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVageKg = double.Parse(Console.ReadLine());
            double priceFruitKg = double.Parse(Console.ReadLine());
            double weightVage = double.Parse(Console.ReadLine());
            double weightFruit = double.Parse(Console.ReadLine());

            double price = (priceVageKg * weightVage) + (weightFruit * priceFruitKg);
            double europrice = price / 1.94;

            Console.WriteLine("{0:f2}", europrice);
        }
    }
}
