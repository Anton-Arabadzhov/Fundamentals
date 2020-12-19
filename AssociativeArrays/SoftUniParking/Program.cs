using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, string> costumers = new Dictionary<string, string>();

            for (int i = 0; i < lines; i++)
            {
                string[] comand = Console.ReadLine().Split();
                string action = comand[0];
                string name = comand[1];
                
                if (action == "register")
                {
                    string plate = comand[2];
                    if (costumers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else
                    {
                        costumers.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (!costumers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        foreach (var item in costumers)
                        {
                            if (item.Key == name)
                            {
                                Console.WriteLine($"{item.Key} unregistered successfully");
                                costumers.Remove(item.Key);
                                
                            }
                        }
                    }
                }

            }
            foreach (var item in costumers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
