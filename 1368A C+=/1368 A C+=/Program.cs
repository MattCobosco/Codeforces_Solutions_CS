using System;

namespace _1368_A_C__
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] ab = Console.ReadLine().Split();

                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                int n = int.Parse(ab[2]);
                int moves = 0;

                
                while (n >= a && n >= b)
                {
                    if (a > b)
                    {
                        b += a;
                        moves++;
                    }
                    else
                    {
                        a += b;
                        moves++;
                    }
                }

                Console.WriteLine(moves);
            }
        }
    }
}
