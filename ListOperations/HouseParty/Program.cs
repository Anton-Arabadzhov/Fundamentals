using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            
            
            for (int going = 0; going < n; going++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string name = command[0];
                string inOrNo = command[2];
                if (inOrNo == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
            
            
        }
    }
}
