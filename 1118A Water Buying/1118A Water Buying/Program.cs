using System;

namespace _1118A_Water_Buying
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string[] input = Console.ReadLine().Split();

                long n = long.Parse(input[0]);
                long a = long.Parse(input[1]);
                long b = int.Parse(input[2]);
                long money=0;

                if (a <= b / 2)
                {
                    money = n * a;
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        money = n/2 * b;
                    }
                    else
                    {
                        money = (n - 1)/2 * b + a;
                    }
                }
                Console.WriteLine(money);
            }
        }
    }
}
