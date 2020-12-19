using System;
using System.Linq;

namespace ShootfortheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string comand = Console.ReadLine();
            int count = 0;
            while (comand != "End")
            {
                int num = int.Parse(comand);
                
                if (num >= 0 && num < targets.Length)
                {
                    int target = targets[num];
                    targets[num] = -1;
                    count++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] != -1 && targets[i] > target)
                        {
                            targets[i] -= target;
                        }
                        else if (targets[i] != -1 && targets[i] <= target)
                        {
                            targets[i] += target;
                        }
                    }
                }





                comand = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");
        }
    }
}
