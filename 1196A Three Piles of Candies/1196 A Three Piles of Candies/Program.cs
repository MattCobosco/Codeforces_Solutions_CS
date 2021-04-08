using System;

namespace _1196_A_Three_Piles_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string[] input = Console.ReadLine().Split();

                long a = long.Parse(input[0]);
                long b = long.Parse(input[1]);
                long c = long.Parse(input[2]);

                Console.WriteLine((a + b + c) / 2);
            }
        }
    }
}
