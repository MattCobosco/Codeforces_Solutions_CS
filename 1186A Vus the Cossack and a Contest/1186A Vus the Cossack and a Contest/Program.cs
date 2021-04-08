using System;

namespace _1186A_Vus_the_Cossack_and_a_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);    // participants
            int m = int.Parse(input[1]);    // pens
            int k = int.Parse(input[2]);    //notebooks

            if (n > m || n > k)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
