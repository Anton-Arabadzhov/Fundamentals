using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] comand = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            bool isBlacklist = false;
            int blacklistedCounts = 0;
            int lostNamesCounts = 0;

            while (comand[0] != "Report")
            {
                if (comand[0] == "Blacklist")
                {

                    for (int i = 0; i < names.Count; i++)
                    {
                        if (comand[1] == names[i])
                        {

                            Console.WriteLine($"{names[i]} was blacklisted.");
                            names[i] = "Blacklisted";
                            isBlacklist = true;
                            blacklistedCounts++;
                            break;
                        }




                    }
                    if (!isBlacklist)
                    {
                        Console.WriteLine($"{comand[1]} was not found.");
                    }


                }
                else if (comand[0] == "Error")
                {
                    int index = int.Parse(comand[1]);
                    if (names[index] != "Blacklisted" && names[index] != "Lost")
                    {

                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names[index] = "Lost";
                        lostNamesCounts++;
                    }
                }
                else if (comand[0] == "Change")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        int index = int.Parse(comand[1]);
                        if (i == index)
                        {
                            Console.WriteLine($"{names[index]} changed his username to {comand[2]}.");
                            names[index] = comand[2];

                        }
                    }
                }
                comand = Console.ReadLine().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine($"Blacklisted names: {blacklistedCounts}");
            Console.WriteLine($"Lost names: {lostNamesCounts}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
