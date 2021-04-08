using System;

namespace _791A_Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] BearWeight = Console.ReadLine().Split();

            int limak_w = int.Parse(BearWeight[0]);
            int bob_w = int.Parse(BearWeight[1]);

            int years_needed = 0;
            while (limak_w <= bob_w)
            {
                limak_w = 3 * limak_w;
                bob_w = 2 * bob_w;
                years_needed++;
            }
            Console.WriteLine(years_needed);
        }
    }
}
