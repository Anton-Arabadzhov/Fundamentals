using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            List<string> Operation = Console.ReadLine().Split().ToList();

            while (Operation[0] != "end")
            {
                switch (Operation[0])
                {
                    case "Delete":
                        int numToDelete = int.Parse(Operation[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numToDelete)
                            {
                                numbers.RemoveAt(i);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(Operation[2]);
                        int numToInsert = int.Parse(Operation[1]);
                        numbers.Insert(index, numToInsert);
                        break;
                        
                    default:
                        break;
                        
                }
                Operation = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
