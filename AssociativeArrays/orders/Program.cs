using System;
using System.Collections.Generic;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] currProducts = input.Split();
                string productName = currProducts[0];
                double price = double.Parse(currProducts[1]);
                double quantity = double.Parse(currProducts[2]);

                if (!products.ContainsKey(productName))
                {
                    
                    products.Add(productName, new List<double> { price, quantity });
                }
                else
                {
                    products[productName][0] = price;
                    products[productName][1] += quantity;
                }


                input = Console.ReadLine();
            }
            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
