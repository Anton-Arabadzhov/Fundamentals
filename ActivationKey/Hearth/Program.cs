using System;
using System.Collections.Generic;
using System.Linq;

namespace Hearth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] hearths = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            
            string command = Console.ReadLine();
            int position = 0;
            while (command != "Love!")
            {
                string[] comarg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string jump = comarg[0];
                int lengh = int.Parse(comarg[1]);

                if (lengh + position >= hearths.Length || lengh + position < 0)
                {
                    if (hearths[0] == 2)
                    {
                        hearths[0] -= 2;
                        position = 0;
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                    else if (hearths[0] < 2)
                    {
                        Console.WriteLine($"Place {position} already had Valentine's day.");
                    }
                    else if (hearths[0] > 2)
                    {
                        hearths[0] -= 2;
                        position = 0;
                    }
                    
                }
                else
                {
                    if (hearths[position + lengh] == 2)
                    {
                        hearths[position + lengh] -= 2;
                        position = position + lengh;
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                    else if (hearths[position + lengh] < 2)
                    {
                        Console.WriteLine($"Place {position} already had Valentine's day.");
                    }
                    else if (hearths[position + lengh] > 2)
                    {
                        hearths[position + lengh] -= 2;
                        position = position + lengh;
                    }
                    
                }
                
                command = Console.ReadLine();
            }
            bool istrue = true;
            int count = 0;
            for (int i = 0; i < hearths.Length; i++)
            {
                if (hearths[i] > 0)
                {
                    count++;
                    
                }
            }
            Console.WriteLine($"Cupid's last position was {position}.");
            if (count == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
            
            
        }
    }
}
