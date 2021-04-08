using System;

namespace Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            long m = long.Parse(tokens[0]);
            long n = long.Parse(tokens[1]);
            long a = long.Parse(tokens[2]);
            long mx = 0;
            long nx = 0;

           if (m <= a)
            {
                mx = 1;
            }
           if (m > a && m % a > 0)
            {
                mx = m / a + 1;
            }
            if (m > a && m % a == 0)
            {
                mx = m / a;
            }
            if (n <= a)
            {
                nx = 1;
            }
           if (n > a && n % a > 0)
            {
                nx = n / a + 1;
            }
            if (n > a && n % a == 0)
            {
                nx = n / a;
            }
            Console.WriteLine(mx * nx);
        }
    }
}
