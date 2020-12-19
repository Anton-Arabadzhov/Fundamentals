using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> student = Console.ReadLine().Split(' ').ToList();

		}
	}
	class Student
	{
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public int Age { get; set; }
		public string City { get; set; }
	}
}
