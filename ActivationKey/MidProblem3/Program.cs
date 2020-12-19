using System;
using System.Collections.Generic;
using System.Linq;

namespace MidProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] comarg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = comarg[0];
                
                if (action == "Change")
                {
                    int index = int.Parse(comarg[1]);
                    int newNum = int.Parse(comarg[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == index)
                        {
                            numbers[i] = newNum;
                            break;
                        }
                    }
                }
                else if (action == "Hide")
                {
                    int index = int.Parse(comarg[1]);
                    if (numbers.Contains(index))
                    {
                        numbers.Remove(index);
                    }
                }
                else if (action == "Switch")
                {
                    int index = int.Parse(comarg[1]);
                    int newNum = int.Parse(comarg[2]);
                    if (numbers.Contains(index) && numbers.Contains(newNum))
                    {
                        
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            
                            if (numbers[i] == newNum)
                            {
                                numbers[i] = index;
                                continue;
                            }
                            if (numbers[i] == index)
                            {
                                numbers[i] = newNum;
                                continue;
                            }
                        }

                    }
                }
                else if (action == "Insert")
                {
                    int place = int.Parse(comarg[1]);
                    int num = int.Parse(comarg[2]);
                    if (place <= numbers.Count)
                    {
                        numbers.Insert(place + 1, num);
                    }
                }
                else if (action == "Reverse")
                {
                    numbers.Reverse();
                }
                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
