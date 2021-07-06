using System;

namespace _702A_Maximum_Increase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read array lenght from the first line

            string[] input = Console.ReadLine().Split(); // read second line as input string

            /*  The idea is to loop through the input numbers analysing i-th and i+1-th numbers to check if the latter is bigger than the former. As long as it's true the counter of bigger numbers will be increased by 1.
                As long as that counter is rising, it will be saved as maxCounter. As soon as the i+1-th number is smaller or equal to the i-th number, the counter of bigger numbers will be reset to 1, and the last value of the maxCounter will be saved for further reference. 
                Then the program will search for a next increasing subarray and compare it's length to the longest */


            int bigCounter = 1; // set counter of numbers bigger than predecessor to 1 (always at least the first number will be an increasing array)
            int maxCounter = bigCounter; // set max of the bigCounter to 1 too
            for (int i = 0; i < n - 1; i++) // loop through the numbers from input
            {
                int x = int.Parse(input[i]); // x is i-th number from input string
                int y = int.Parse(input[i + 1]); // y is i+1-th number from input string

                if (x < y) // if the i+1-th number is bigger than the i-th number than it's a part of increasing string, therefore increase the bigCounter by 1
                {
                    bigCounter++;
                    
                    if (bigCounter > maxCounter) // save the bigCounter as maxCounter as long as it's bigger than the previously identified maxCounter
                    {
                        maxCounter=bigCounter;
                    }
                }
                else // if it's smaller then reset the bigCounter to 1
                {
                    bigCounter = 1;
                }

            }

            Console.WriteLine(maxCounter); // return maxCounter after looping through the whole input array
        }
    }
}
