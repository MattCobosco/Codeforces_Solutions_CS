using System;

namespace _1360A_Minimal_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of cases from input

            for (int i = 0; i < t; i++) // loop through cases
            {
                string[] caseInput = Console.ReadLine().Split(); // read case as string

                int a = int.Parse(caseInput[0]); // out a and b from caseInput string
                int b = int.Parse(caseInput[1]);

                int min = Math.Min(a, b); // find min side lenght
                int max = Math.Max(a, b); // find max side lenght

                if (2 * min >= max) // if 2 min sides are >= 1 bigger side than it's more efficient to join the rectangles by the longer side and then form a square which side length is equal to 2*min^2
                    Console.WriteLine(Math.Pow(min * 2, 2));
                else // 2 min sides are < 1 bigger side, it's more efficient to join the rectangles by the shorter side and then form a square which side is equal to max^2
                    Console.WriteLine(Math.Pow(max, 2));
            } 
        }
    }
}
