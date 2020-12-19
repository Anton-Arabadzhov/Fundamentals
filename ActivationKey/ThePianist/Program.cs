using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pianist = new Dictionary<string, List<string>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = tokens[0];
                string compositor = tokens[1];
                string key = tokens[2];

                pianist.Add(piece, new List<string>()
                { compositor, key });

        }
            foreach (var piece in pianist)
            {
                string compositor = piece.Value[0];
                string key = piece.Value[1];
                Console.WriteLine($"{piece.Key} {compositor} {key}");
            }
        }
    }
   
}
