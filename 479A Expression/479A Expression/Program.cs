using System;
using System.Linq;

namespace _479A_Eapression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine()); // read a,b,c from input
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
                        
            int[] computations = new int[] // array with all possible results
            {
                a + b * c,
                (a + b) * c,
                a * b + c,
                a * (b + c),
                a + b + c,
                a * b * c
            };

            Console.WriteLine(computations.Max()); // print the max value among the results
        }
    }
}
