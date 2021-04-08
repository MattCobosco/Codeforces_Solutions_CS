using System;

namespace _50A_Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int m = int.Parse(tokens[0]);
            int n = int.Parse(tokens[1]);

            int sqr = m * n;

            Console.WriteLine(sqr / 2);
        }
    }
}
