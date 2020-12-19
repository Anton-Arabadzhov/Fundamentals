using System;
using System.Collections.Generic;

namespace Shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            string[] input = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                products.Add(item);
            }

            string com = Console.ReadLine();
            while (com != "Go Shopping!")
            {
                string[] command = com.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string item = command[1];
                if (command[0] == "Urgent")
                {
                    if (!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }

                }
                else if (command[0] == "Unnecessary")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                }
                else if (command[0] == "Correct")
                {
                    string newItem = command[2];
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i] == item)
                        {
                            products.Insert(i, newItem);
                            products.Remove(item);
                        }
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                }
                com = Console.ReadLine();
            }

            Console.WriteLine($"{string.Join(", ", products)}");
        }
    }
}
