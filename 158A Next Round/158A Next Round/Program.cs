using System;

namespace _158A_Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();
            string[] scores = Console.ReadLine().Split();

            int n = int.Parse(nk[0]); 
            int k = int.Parse(nk[1]);
            int counter = 0;

            int bench = int.Parse(scores[k-1]);

            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(scores[i]);
                if (temp >= bench && temp > 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
