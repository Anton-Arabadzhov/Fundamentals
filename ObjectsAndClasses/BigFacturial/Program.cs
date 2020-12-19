using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigFacturial
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			BigInteger facturial = 1;

			for (int i = 2; i <= num; i++)
			{
				facturial *= i;
			}
			Console.WriteLine(facturial);
		}
	}
}
