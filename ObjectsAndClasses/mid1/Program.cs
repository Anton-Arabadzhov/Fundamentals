using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid1
{
	class Program
	{
		static void Main(string[] args)
		{
			int students = int.Parse(Console.ReadLine());
			int lectures = int.Parse(Console.ReadLine());
			int bonus = int.Parse(Console.ReadLine());

			int num = 0;


			for (int i = 0; i < students; i++)
			{
				int atendence = int.Parse(Console.ReadLine());

				if (atendence >= num)
				{
					num = atendence;
				}

			}
			double finalScore = ((num * 1.0) / lectures * (5 + bonus));
			double result = Math.Ceiling(finalScore);
			if (lectures == 0 || students == 0)
			{
				Console.WriteLine($"Max Bonus: {0}.");
				Console.WriteLine($"The student has attended {0} lectures.");
			}
			else
			{
				Console.WriteLine($"Max Bonus: {result}.");
				Console.WriteLine($"The student has attended {num} lectures.");
			}
		}
	}
}
