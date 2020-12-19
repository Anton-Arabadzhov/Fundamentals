using System;
using System.Collections.Generic;
using System.Text;

namespace MidProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] order = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            double budget = double.Parse(Console.ReadLine());
            
            List<double> prices = new List<double>();
            double profits = 0;
            double ticketprice = 0;
            for (int i = 0; i < order.Length; i++)
            {
                string[] saparate = order[i].Split("->",StringSplitOptions.RemoveEmptyEntries);
                string product = saparate[0];
                double price = double.Parse(saparate[1]);
                
                
                if (product == "Clothes" && price <= 50 && price >= 0 && price <= budget)
                {
                    
                    double pricez = Math.Round(price * 1.40,2);
                    prices.Add(pricez);
                    budget -= price;
                    profits += pricez - price;
                    ticketprice += pricez;
                }
                else if (product == "Shoes" && price <= 35 && price >= 0 && price <= budget)
                {
                    
                    double pricez = Math.Round(price * 1.40, 2);
                    prices.Add(pricez);
                    budget -= price;
                    profits += price * 0.4;
                    ticketprice += pricez;
                }
                else if (product == "Accessories" && price <= 20.50 && price >= 0 && price <= budget)
                {
                    
                    double pricez = (price * 1.40);
                    prices.Add(pricez);
                    budget -= price;
                    profits += price * 0.4;
                    ticketprice += pricez;
                }
                

            }
            
            
            
                 
                Console.WriteLine($"{string.Join(" ", prices).TrimEnd()}");
            StringBuilder str = new StringBuilder();
            foreach (var item in prices)
            {
                str.Append($"{item:f2}" + " ");
            }
            Console.WriteLine(str.ToString().TrimEnd());

            Console.WriteLine($"Profit: {profits:f2}");
            if (ticketprice + budget >= 150.0)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
