using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid2
{
	class Program
	{
		static void Main(string[] args)
		{
            string comand = Console.ReadLine();
			string[] comands = comand.Split('|', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();

			int live = 100;
			int bitCoin = 0;
            int count = 0;
			for (int i = 0; i < comands.Length; i++)
			{
                string[] indexi = comands[i].Split(' ', (char)StringSplitOptions.RemoveEmptyEntries) ;
                
			    string currCmd = indexi[0];
				int currAct = int.Parse(indexi[1]);

                count++;

                    if (currCmd == "potion")
                    {


                        if (live + currAct > 100)
                        {
                            Console.WriteLine($"You healed for {Math.Abs(live - 100)} hp.");
                            live = 100;
                            Console.WriteLine($"Current health: {live} hp.");

                        }
                        
                        else
                        {
                            Console.WriteLine($"You healed for {currAct} hp.");
                            Console.WriteLine($"Current health: {live + currAct} hp.");
                        live += currAct;
                        }
                         
                    }
                    else if (currCmd == "chest")
                    {
                        Console.WriteLine($"You found {currAct} bitcoins.");
                        bitCoin += currAct;
                         
                    }
                    else
                    {
                    
                    live -= currAct;
                        if (live <= 0)
                        {
                        
                        Console.WriteLine($"You died! Killed by {currCmd}.");
                            Console.WriteLine($"Best room: {count}");
                        
                        break;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {currCmd}.");
                        }
                }
                
			}
            if (live > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitCoin}");
                Console.WriteLine($"Health: {live}");
            }
            
		}
	}
}
