using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());

            double maxPoints = 0;

            for (int i = 0; i < students; i++)
            {
                int attendence = int.Parse(Console.ReadLine());
                if (attendence > maxPoints)
                {
                    maxPoints = attendence;
                }
            }
            double max1 = (maxPoints / lectures)* 1.0;
            double max2 = (5 + bonus)*1.0;
            double max = Math.Ceiling(max1 * max2);
            Console.WriteLine($"Max Bonus: {max}.");
            Console.WriteLine($"The student has attended {maxPoints} lectures.");
        }
    }
}
