using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);


            }

            foreach (var item in students.OrderByDescending(x=>x.Value.Average()))
            {
                double gradeTotal = item.Value.Average();
                if (gradeTotal >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {gradeTotal:f2}");
                }
                
            }
        }
    }
}
