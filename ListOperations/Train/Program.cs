using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int num = int.Parse(command[1]);
                    Wagons.Add(num);
                }
                else
                {
                    for (int i = 0; i < Wagons.Count; i++)
                    {
                        int pplToAdd = int.Parse(command[0]);
                        if (Wagons[i] + pplToAdd <= maxCapacity)
                        {
                            Wagons[i] += pplToAdd;
                            break;
                        }

                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", Wagons));

        }
    }
}
