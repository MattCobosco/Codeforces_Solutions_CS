using System;

namespace _996A_Hit_the_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int bills = 0;

            while (n>0)
            {
                if (n % 100 == 0)
                {
                    n -= 100;
                    bills++;
                }
                else if (n % 20 == 0)
                {
                    n -= 20;
                    bills++;
                }
                else if (n % 10 == 0)
                {
                    n -= 10;
                    bills++;
                }
                else if (n % 5 == 0)
                {
                    n -= 5;
                    bills++;
                }
                else if (n % 1 == 0)
                {
                    n -= 1;
                    bills++;
                }
            }
            Console.WriteLine(bills);
        }
    }
}
