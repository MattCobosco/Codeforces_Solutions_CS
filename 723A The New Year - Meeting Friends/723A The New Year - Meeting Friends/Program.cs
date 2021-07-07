using System;

namespace _723A_The_New_Year___Meeting_Friends
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The idea is to determine the max, min and mid point coordinates.
             * It's easiest for those 3 friends to meet at the mid coordinate. So the answer to this problem is the sum of max to mid and min to mid distance.
             * Since the coordinates aren't provided in any particular order one needs to check which of the provided coordinates is the mid.
             * Also, the max to mid and min to mid do not need to be equal (mid doesn't need to be exactly in the middle between min and max) one can't provide max-min as an answer despite the fact that shown test case examples suggest otherwise.
             */

            string[] input = Console.ReadLine().Split(); // read input as string array

            int x1 = int.Parse(input[0]); // out x1, x2, x3 ints from array
            int x2 = int.Parse(input[1]);
            int x3 = int.Parse(input[2]);

            int max = Math.Max(Math.Max(x1, x2), x3); // find max coord among x1, x2, x3
            int min = Math.Min(Math.Min(x1, x2), x3); // find min coord

            int mid; // declare mid value as int

            // the value that isn't max or min must be the mid coord
            if (x1 != min && x1 != max)
            {
                mid = x1;
            }
            else if (x2 != min && x2 != max)
            {
                mid = x2;
            }
            else
            {
                mid = x3;
            }

            int output = mid - min + max - mid; // calculate the sum of mid to max and mid to min distances which will be the final answer

            Console.WriteLine(output);
        }
    }
}
