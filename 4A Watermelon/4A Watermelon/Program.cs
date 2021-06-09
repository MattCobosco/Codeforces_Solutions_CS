using System;

namespace _4A_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine()); // read n from input

            if (n != 2 && n % 2 == 0) // n needs to be an even number to be divisible into 2 even numbers and can't be 2 because 2 is the only exception (2/2=1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
