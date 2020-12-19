using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] cmdArr = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string currCmd = cmdArr[0];
                string item = cmdArr[1];

                switch (currCmd)
                {

                    case "Collect":
                        if (!collectingItems.Contains(item))
                        {
                            collectingItems.Add(item);
                        }
                        break;
                    case "Drop":
                        if (collectingItems.Contains(item))
                        {
                            collectingItems.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] combineItems = cmdArr[1]
                            .Split(":", StringSplitOptions.RemoveEmptyEntries);
                        string oldItem = combineItems[0];
                        string newItem = combineItems[1];

                        if (collectingItems.Contains(oldItem))
                        {
                            int getIndex = 0;
                            for (int i = 0; i < collectingItems.Count; i++)
                            {
                                if (collectingItems[i] == oldItem)
                                {
                                    getIndex = i + 1;
                                    break;
                                }
                            }
                            collectingItems.Insert(getIndex, newItem);
                        }
                        break;
                    case "Renew":
                        for (int i = 0; i < collectingItems.Count; i++)
                        {
                            if (collectingItems[i] == item)
                            {
                                collectingItems.Add(item);
                                collectingItems.RemoveAt(i);
                                break;
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", collectingItems));
        }
    }
}
