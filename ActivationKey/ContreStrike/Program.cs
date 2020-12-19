using System;

namespace ContreStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string distance = (Console.ReadLine());

            int count = 0;
            while (energy >= 0)

            {
                if (distance == "End of battle")
                {
                    Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
                    break;
                }
                
                int dist = int.Parse(distance);
                
                
                if (energy - dist < 0)
                {
                    
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    break;
                }
                energy -= dist;
                count++;
                if (count % 3 == 0)
                {
                    energy += count;
                }


                distance = Console.ReadLine();
            }
            
           
        }
    }
}
