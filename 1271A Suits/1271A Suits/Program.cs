using System;

namespace _1271A_Suits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());    // ties
            int b = Convert.ToInt32(Console.ReadLine());    // scarves
            int c = Convert.ToInt32(Console.ReadLine());    // vests
            int d = Convert.ToInt32(Console.ReadLine());    // jackets
            int e = Convert.ToInt32(Console.ReadLine());    // cost of 1st type of suit
            int f = Convert.ToInt32(Console.ReadLine());    // cost of 2nd type of suit

            int count_suit_1 = 0;
            int count_suit_2 = 0;

            for (int i = 0; i < d; i++)
            {
                if (e >= f)
                {
                    while (a > 0)
                    {
                        a--;
                        count_suit_1++;
                    }
                    while (a == 0 && b > 0 && c > 0)
                    {
                        b--;
                        c--;
                        count_suit_2++;
                    }
                }

                if (f > e)
                {
                    while (b > 0 && c > 0)
                    {
                        b--;
                        c--;
                        count_suit_2++;
                    }
                    while (b == 0 && c == 0 && a > 0)
                    {
                        a--;
                        count_suit_1++;
                    }
                }
            }
            Console.WriteLine("{0}, {1}, {2}, {3}", count_suit_1, e, count_suit_2, f);
        }
    }
}
