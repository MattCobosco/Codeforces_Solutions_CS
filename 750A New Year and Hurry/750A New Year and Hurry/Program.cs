using System;

namespace _750A_New_Year_and_Hurry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();

            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            int time = 240 - k;
            int counter = 0;
            int i = 1;
            while (time >= 5 * i)
            {
                time -= 5 * i;
                i++;
                counter++;
            }
            if (counter > n)
                Console.WriteLine(n);
            else
                Console.WriteLine(counter);
        }
    }
}
