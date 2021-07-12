using System;

namespace _1374A_Required_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] inputCase = Console.ReadLine().Split();

                int x = int.Parse(inputCase[0]);
                int y = int.Parse(inputCase[1]);
                int n = int.Parse(inputCase[2]);

                int cnt = n / x;

                int ans = x * cnt + y;

                if (ans > n)
                {
                    ans -= x;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
