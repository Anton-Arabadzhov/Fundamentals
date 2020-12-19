using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            //todo second dictionary


            while (input != "Lumpawaroo")
            {
                if (input.Contains(" s "))
                {
                    string[] comand = input.Split(" | ");
                    string user = comand[1];
                    string side = comand[0];
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }
                    if (!sides[side].Contains(user))
                    {
                        sides[side].Add(user);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] comand = input.Split(" -> ");
                    string user = comand[0];
                    string side = comand[1];

                    if (sides[side].Contains(user))
                    {

                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in sides.OrderByDescending(x=>x.Value.Count).ThenBy(a=>a.Key))
            {
                Console.WriteLine($"Side; {item.Key}, Members: {item.Value.Count}");
                foreach (var itms in item.Value.OrderBy(a=>a))
                {
                    Console.WriteLine($"! {itms}");
                }
            }
        }
    }
}
