using System;
using System.Linq;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().ToArray();

            StringBuilder repoeat = new StringBuilder();

            foreach (var item in word)
            {
                int count = item.Length;
                for (int i = 0; i < count; i++)
                {
                    repoeat.Append(item);
                }
            }
            Console.WriteLine(repoeat);

        }
    }
}
