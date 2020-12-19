using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesofcodeandLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, int> HeroHhealhPoint = new Dictionary<string, int>();
            Dictionary<string, int> HeroManaPoint = new Dictionary<string, int>();
            int hpmax = 100;
            int mpmax = 200;
            for (int i = 0; i < num; i++)
            {
                string[] hero = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = hero[0];
                int hp = int.Parse(hero[1]);
                int mp = int.Parse(hero[2]);
                HeroHhealhPoint.Add(name,0);
                HeroManaPoint.Add(name,0);

                HeroHhealhPoint[name] = hp > hpmax ? hpmax : hp;
                HeroManaPoint[name] = mp > mpmax ? mpmax : mp;

            }
            string[] comand = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (comand[0] != "End")
            {
                string cmd = comand[0];
                
                string name = (comand[1]);
                int nums = int.Parse(comand[2]);

                if (comand[0] == "CastSpell")
                {
                    string magic = comand[3];
                    if (HeroManaPoint.ContainsKey(name))        
                    {
                        if (HeroManaPoint[name] >= nums)
                        {
                            
                            int leftpoints = Math.Abs(HeroManaPoint[name] - nums);
                            Console.WriteLine($"{name} has successfully cast {magic} and now has {leftpoints} MP!");
                            HeroManaPoint[name] -= nums;
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {magic}!");
                        }

                    }
                    

                }
                else if (comand[0] == "TakeDamage")
                {
                    string atacker = comand[3];
                    if (HeroManaPoint.ContainsKey(name))
                    {
                        int hpleft = Math.Abs(HeroHhealhPoint[name] - nums);
                        HeroHhealhPoint[name] -= nums;
                        if (HeroHhealhPoint[name] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {nums} HP by {atacker} and now has {hpleft} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {atacker}!");
                            HeroHhealhPoint.Remove(name);
                            HeroManaPoint.Remove(name);
                        }
                    }
                }
                else if (comand[0] == "Recharge")
                {
                    if (HeroManaPoint.ContainsKey(name))
                    {
                        if (HeroManaPoint[name] + nums > mpmax)
                        {
                            int healed = mpmax - HeroManaPoint[name];
                            Console.WriteLine($"{name} recharged for {healed} MP!");
                            HeroManaPoint[name] = mpmax;
                        }
                        else
                        {
                            HeroManaPoint[name] += nums;
                            Console.WriteLine($"{name} recharged for {nums} MP!");
                        }
                    }
                }
                else if (comand[0] == "Heal")
                {
                    if (HeroManaPoint.ContainsKey(name))
                    {
                        if (HeroHhealhPoint[name] + nums > hpmax)
                        {
                            int healed = hpmax - HeroHhealhPoint[name];
                            Console.WriteLine($"{name} healed for {healed} HP!");
                            HeroHhealhPoint[name] = hpmax;
                        }
                        else
                        {
                            HeroHhealhPoint[name] += nums;
                            Console.WriteLine($"{name} healed for {nums} HP!");
                        }
                    }
                }
                comand = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in HeroHhealhPoint.OrderByDescending(x=>x.Value).ThenBy(c=>c.Key))
            {
                
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value}");
                if (HeroManaPoint.ContainsKey(item.Key))
                {
                    Console.WriteLine($"  MP: {HeroManaPoint[item.Key]}");
                }
            }
            
        }
    }
}
