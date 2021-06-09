using System;

namespace _1283A_Minutes_Before_the_New_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of cases from the 1st line of input
            for (int i = 0; i < t; i++) // looping through all cases
            {
                string[] hm = Console.ReadLine().Split(); // read the hour from the case as string and split it
                int h = int.Parse(hm[0]); // read hours from input as integer h
                int m = int.Parse(hm[1]); // read minutes from input as integer m

                int hRemaining = 23 - h; // calculate the number of hours remaining to midnight
                int mRemaining = 60 - m; // calculate the number of minutes remaining to the full hour
                Console.WriteLine(hRemaining * 60 + mRemaining); // calculate the number of remaining minutes as a sum of remaining hours mulitplied by 60 and remaining minutes and print it 
            }
        }
    }
}
