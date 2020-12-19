using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine()
				.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

			Random rng = new Random();

			for (int i = 0; i < words.Length; i++)
			{
				int index = rng.Next(0, words.Length);
				string word = words[i];

				words[i] = words[index];
				words[index] = word;
			}
			Console.WriteLine(string.Join(Environment.NewLine, words));
		}

		
	}
}
