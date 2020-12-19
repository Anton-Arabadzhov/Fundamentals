using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(a => a.Length % 2 == 0).ToArray();

            string[] wordss = Console.ReadLine().Split().Where(a => a.Length % 2 == 0).ToArray();
            for (int i = 0; i < words.Length; i++)
            

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
