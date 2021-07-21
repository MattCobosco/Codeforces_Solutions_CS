using System;
using System.Linq;

namespace _1342A_Road_To_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of test cases from input as int 

            for (int i = 0; i < t; i++) // loop through test cases
            {
                long[] xy = Console.ReadLine().Split(' ').Select(long.Parse).ToArray(); // read x,y as long array from the first line of the test case
                long[] ab = Console.ReadLine().Split(' ').Select(long.Parse).ToArray(); // read a,b as long array from the second line of the test case

                long x = xy[0]; // out x, y, a, b
                long y = xy[1];
                long a = ab[0];
                long b = ab[1];

                /* x,y - longegers to be zero'd
                 * a - price of moving one of x or y up or down by 1
                 * b - price of moving both x,y up or down by 1
                 */
                long cost = 0; // declare and set cost to 0

                long max = Math.Max(x, y); // find the max and min of the x,y
                long min = Math.Min(x, y);

                long decreaseBothCounter = min; // the number of times both numbers must be decreased by 1 so that one of them is 0 is equal to the smaller of them
                long decreaseOneCounter = max - min; // since after decreasing both by 1, x or y is 0, the remaining one must be decreased by 1 (max - min) - times
                

                if (2 * a < b) // if 2 * a is smaller than b then it's cheaper to pay a twice to reduce x and y one by one instead of both at the same time which costs b
                {
                    cost = decreaseBothCounter * 2 * a + decreaseOneCounter * a;
                }
                else // if b is cheaper than 2 * a then it's cheaper to pay b for reducing both x and y as long as both are positive numbers
                {
                    cost = decreaseBothCounter * b + decreaseOneCounter * a;
                }

                Console.WriteLine(cost); // return cost to the console

            }
        }
    }
}
