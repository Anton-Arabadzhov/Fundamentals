using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string resource = Console.ReadLine();

            Dictionary<string, int> collects = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quatity = int.Parse(Console.ReadLine());

                if (collects.ContainsKey(resource))
                {
                    collects[resource] += quatity;
                }
                else
                {
                    collects.Add(resource, quatity);
                }
                resource = Console.ReadLine();
            }
            foreach (var item in collects)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        
    }
}
