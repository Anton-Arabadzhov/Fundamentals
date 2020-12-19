﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool isChanged = true;
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        int NumAdd = int.Parse(command[1]);
                        numbers.Add(NumAdd);
                        isChanged = false;
                        break;
                    case "Remove":
                        int numRemove = int.Parse(command[1]);
                        numbers.Remove(numRemove);
                        isChanged = false;
                        break;
                    case "RemoveAt":
                        int numAtRemove = int.Parse(command[1]);
                        numbers.RemoveAt(numAtRemove);
                        isChanged = false;
                        break;
                    case "Insert":
                        int numInsert = int.Parse(command[1]);
                        int IndexToInsert = int.Parse(command[2]);
                        numbers.Insert(IndexToInsert, numInsert);
                        isChanged = false;
                        break;
                    case "Contains":
                        bool isTrue = false;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int numToCampere = int.Parse(command[1]);

                            if (numToCampere == numbers[i])
                            {
                                isTrue = true;
                                break;
                            }
                            else
                            {
                                isTrue = false;
                            }
                        }
                        if (isTrue)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                   
                    case "Filter":


                        if (command[1] == "<=" || command[1] == ">=")
                        {

                            if (command[1] == "<=")
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int currNum = int.Parse(command[2]);
                                    if (numbers[i] <= currNum)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            else if (command[1] == ">=")
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int currNum = int.Parse(command[2]);
                                    if (numbers[i] >= currNum)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            List<char> c = command[1].Split().Select(char.Parse).ToList();
                            if (c[0] == '<')
                            {

                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int currNum = int.Parse(command[2]);
                                    if (numbers[i] < currNum)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            else if (c[0] == '>')
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int currNum = int.Parse(command[2]);
                                    if (numbers[i] > currNum)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        break;

                }


                command = Console.ReadLine().Split().ToList();
            }
            if (!isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

    }
}
