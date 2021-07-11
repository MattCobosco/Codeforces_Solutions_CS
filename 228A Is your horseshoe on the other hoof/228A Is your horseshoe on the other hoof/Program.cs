using System;
using System.Linq;

namespace _228A_Is_your_horseshoe_on_the_other_hoof
{
    class Program
    {
        static void Main(string[] args) 

            /* The idea is to count distinct values in the input and then subtract it from 4 (all horseshoes)*/
        {
            string[] colors = Console.ReadLine().Split(); // split input into string array

            int distinctCount = colors.Distinct().Count(); // count distinct values in the array

            Console.WriteLine(4 - distinctCount); // calculate and return result
        }
    }
}
