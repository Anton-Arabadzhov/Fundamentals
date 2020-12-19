using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] cmdarg = command.Split(" : ");
                string course = cmdarg[0];
                string student = cmdarg[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(student);
                 
                command = Console.ReadLine();
            }
            foreach (var item in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var itema in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {itema}");
                }
            }
        }
    }
}
