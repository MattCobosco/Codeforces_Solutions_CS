using System;

namespace _1369_A_FashionabLee
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 4 == 0)
                {

                    Console.WriteLine("YES");
                }
                else 
                    Console.WriteLine("NO");
            }
        }
    }
}
