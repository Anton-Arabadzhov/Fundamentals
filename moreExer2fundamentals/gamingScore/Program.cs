using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamingScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double spendMoney = 0;
            double moneyGame = 0;

            while (true)
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    if (budget > 0)
                    {
                        Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${budget:f2}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    
                }
                if (game == "OutFall 4")
                {
                    moneyGame= 39.99;
                }
                else if (game == "CS: OG")
                {
                    moneyGame = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    moneyGame = 19.99;
                }
                else if (game == "Honored 2")
                {
                    moneyGame = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    moneyGame = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    moneyGame = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    game = string.Empty;
                }

                if (budget < moneyGame)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (game == "RoverWatch Origins Edition" || game == "RoverWatch" || 
                    game == "Honored 2" || game == "Zplinter Zell" || game == "CS: OG" || game == "OutFall 4")
                {
                    Console.WriteLine($"Bought {game}");
                    spendMoney += moneyGame;
                    budget -= moneyGame;
                    
                }
                
                
            }
        }
    }
}
