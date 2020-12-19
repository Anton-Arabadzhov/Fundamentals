using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInOrder = 0;

            while (true)
            {

                string money = (Console.ReadLine());
                if (money == "Start")
                {
                    break;
                }
                double monets = double.Parse(money);
                if (monets == 1 || monets == 0.1 || monets == 0.2 || monets == 0.5 || monets == 2)
                {
                    
                    moneyInOrder += monets;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {monets}");
                    
                }
                
            }
            while (true)
            {
                string product = Console.ReadLine();
                double unitMoney = 0;

                if (product == "End")
                {
                    break;
                }
                if (product == "Coke" )
                {
                    unitMoney = 1;
                }
                else if (product == "Nuts")
                {
                    unitMoney = 2;
                }
                else if (product == "Water")
                {
                    unitMoney = 0.7;
                }
                else if (product == "Crisps")
                {
                    unitMoney = 1.5;
                }
                else if (product == "Soda")
                {
                    unitMoney = 0.8;
                }
                if (unitMoney == 0 && product != "Start")
                {
                    Console.WriteLine("Invalid product");
                }
                if (moneyInOrder >= unitMoney && unitMoney != 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    moneyInOrder -= unitMoney;
                }
                else if (unitMoney > moneyInOrder)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                unitMoney = 0;
            }
            Console.WriteLine($"Change: {moneyInOrder:f2}");
        }
    }
}
