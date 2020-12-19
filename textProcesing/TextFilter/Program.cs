using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWord = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var item in banWord)
            {
                string replaced = new string('*', item.Length);
                text = text.Replace(item, replaced);
            }
            Console.WriteLine(text);
        }
    }
}
