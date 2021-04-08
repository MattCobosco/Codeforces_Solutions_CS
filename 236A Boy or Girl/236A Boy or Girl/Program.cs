using System;
using System.Linq;

namespace _236A_Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var count = str.Distinct().Count();
            
            if (count % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }    
        }
    }
}
