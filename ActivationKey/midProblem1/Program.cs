using System;

namespace midProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceKgFlour = double.Parse(Console.ReadLine());

            double packEgg = priceKgFlour * 0.75;
            double packMilk = priceKgFlour * 1.25;
            double milkperCousunak = packMilk / 4;
            double priceperCosunak = packEgg + milkperCousunak + priceKgFlour;

            int cosunaksCount = 0;
            int countEggs = 0;
            int coloredEggs = 0;
            while (budget >= priceperCosunak)
            {
                budget -= packEgg + priceKgFlour + milkperCousunak;
                cosunaksCount++;
                countEggs++;
                coloredEggs += 3;
                if (cosunaksCount % 3 == 0)
                {
                    coloredEggs -= cosunaksCount - 2;
                }
                
            }
            
            Console.WriteLine($"You made {cosunaksCount} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
