using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            int count = 0;
            while (command != "Stop")
            {
                string[] cmnarg = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string hapynes = cmnarg[0];
                string guest = cmnarg[1];
                string meal = cmnarg[2];
                if (hapynes == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());
                        
                    }
                    if (!guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }

                }
                else
                {
                    if (guests.ContainsKey(guest))
                    {
                        if (guests[guest].Contains(meal))
                        {
                            guests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    
                }
                command = Console.ReadLine();
            }

            foreach (var guest in guests.OrderByDescending(v=>v.Value.Count).ThenBy(g=>g.Key))
            {
                Console.Write($"{guest.Key}: ");
                foreach (var item in guest.Value)
                {
                    var result = string.Join(", ", guest.Value.ToArray());
                    Console.Write($"{result}");
                    break;
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
