using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end" )
            {
                switch (command[0])
                {
                    case "Add":
                        int NumAdd = int.Parse(command[1]);
                        numbers.Add(NumAdd);
                        break;
                    case "Remove":
                        int numRemove = int.Parse(command[1]);
                        numbers.Remove(numRemove);
                        break;
                    case "RemoveAt":
                        int numAtRemove = int.Parse(command[1]);
                        numbers.RemoveAt(numAtRemove);
                        break;
                    case "Insert":
                        int numInsert = int.Parse(command[1]);
                        int IndexToInsert = int.Parse(command[2]);
                        numbers.Insert(IndexToInsert, numInsert);
                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }      
}
