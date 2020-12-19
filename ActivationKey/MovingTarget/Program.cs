using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] comarg = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = comarg[0];
                int index = int.Parse(comarg[1]);
                int amount = int.Parse(comarg[2]);
                if (targets.Count > 0)
                {


                    if (action == "Shoot")
                    {
                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= amount;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                    }
                    else if (action == "Add")
                    {
                        if (index >= 0 && index < targets.Count && amount > 0)
                        {
                            targets.Insert(index, amount);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid placement!");
                        }
                    }
                    else if (action == "Strike")
                    {
                        if (index >= 0 && index < targets.Count && amount > 0)
                        {
                            if (index - amount >= 0 && index + amount < targets[targets.Count - 1])
                            {

                                targets.RemoveRange(index - amount,amount * 2 + 1); 
                            }
                            else
                            {
                                Console.WriteLine($"Strike missed!");
                            }
                        }
                    }



                    comand = Console.ReadLine();
                }
            }
            Console.WriteLine(string.Join('|', targets));
        }
    }
}
