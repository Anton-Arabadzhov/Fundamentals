using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                
                    switch (command[0])
                    {
                        case "Add":
                        int index = int.Parse(command[1]);
                        numbers.Add(index);

                            break;
                        case "Remove":
                        int index2 = int.Parse(command[1]);

                        if (index2 > numbers.Count || index2 < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(index2);
                        }
                        break;
                        case "Shift":
                        int num = int.Parse(command[2]);
                        if (command[1] == "right")
                        {
                            
                            for (int i = 0; i < num; i++)
                            {
                                int currNum = numbers[numbers.Count - 1];
                                numbers.Reverse();
                                numbers.RemoveAt(0);
                                numbers.Add(currNum);
                                numbers.Reverse();
                                
                            }
                        }
                        else if (command[1] == "left")
                        {
                            for (int i = 0; i < num; i++)
                            {
                                int currNum = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(currNum);
                                
                            }
                        }
                            break;
                        case "Insert":
                        int insertNum = int.Parse(command[1]);
                        int insertIndex = int.Parse(command[2]);
                        if (insertIndex > numbers.Count || insertIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(insertIndex, insertNum);
                        }

                        break;
                        default:
                        Console.WriteLine("Invalid index");

                            break;
                    }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
