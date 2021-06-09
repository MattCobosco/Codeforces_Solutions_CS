using System;

namespace _1328A_Divisibility_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read t (number of cases) from input

            for (int i=0; i < t; i++) // loop through cases
            {
                string[] ab = Console.ReadLine().Split(); // read a and b from input as a string
                int a = int.Parse(ab[0]); // parse the string into a and b
                int b = int.Parse(ab[1]);

                if (a % b == 0) // if a is immediately divisible by b then print 0
                    Console.WriteLine(0);
                else // if it isn't then print the result of the following equation
                    Console.WriteLine(b - a % b);
            }
        }   
    }
}

/*  2nd solution => time limit exceeded
 *  int counter = 0;
 *
 *  while (a % b != 0)
 *  {   a++;
 *      counter++;
 *  }
 *
 *  Console.WriteLine(counter);
 */