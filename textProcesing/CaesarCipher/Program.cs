using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                char currchar = (char)(item + 3);
                Console.Write(currchar);
            }
            
            
        }
    }
}
