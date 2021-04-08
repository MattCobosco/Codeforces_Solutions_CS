using System;
using System.Collections.Generic;

namespace _469A_I_Wanna_Be_the_Guy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] xLevels = Console.ReadLine().Split();
            string[] yLevels = Console.ReadLine().Split();
            string Levels = string.Join(xLevels, yLevels);

            int level_max = 1;
            for (int i=0; i < Levels.Length; i++)
            {
                if (Levels[i] == level_max)
                {
                    level_max++;
                }
            }

            if (level_max == n)
            {
                Console.WriteLine("I become the guy." + level_max + Levels.Length);
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!" + level_max + Levels.Length);
            }
        }
    }
}
