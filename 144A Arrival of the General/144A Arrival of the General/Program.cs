using System;
using System.Linq;

namespace _144A_Arrival_of_the_General
{
    class Program
    {
        static void Main(string[] args)
            /*The idea is to loop through the line of soldiers twice to find the shortest and tallest soldier's indexes. However the directions of loops will be different;
             * the loop to find the tallest soldier will start at index 0, the loop to find the shortest soldier will start at index n-1 (lenght of the line compensated for 0-based index numbering).
             * The reason to find it with loops instead of using System.Linq feature is to find the occurence nearest to the end/start of the line to ensure the shortest solution */
        {
            short n = Convert.ToInt16(Console.ReadLine()); // get number of soldiers from input

            int[] soldiersArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // convert the line of soldiers into 1d int array

            int maxHeight = soldiersArr.Max(); // find min height
            int minHeight = soldiersArr.Min(); // find max height

            int maxHeightIndex = 0; // delare indexes of min and max height which will be established using the loops
            int minHeightIndex = 0;

            for (int i = 0; i < n; i++) // loop through the array starting from the beginning to find first occurence of max height, when it's been found, save its index as maxHeightIndex
            {
                if (soldiersArr[i] == maxHeight)
                {
                    maxHeightIndex = i;
                    break;
                }
            }

            for (int i = n - 1; i > 0; i--) // loop through the array starting from the end to find the first occurence of min height, when it's been found, save its index as minHeightIndex
            {
                if (soldiersArr[i] == minHeight)
                {
                    minHeightIndex = i;
                    break;
                }
            }

            if (maxHeightIndex > minHeightIndex) //if maxHeight comes after the minHeight in the array then they need one less swap compared to when they max and min don't have to swap with eachother
            {
                Console.WriteLine(n - 1 - minHeightIndex + maxHeightIndex - 1); // n-1 to compensate for 0-based index numbering
            }
            else
            {
                Console.Write(n - 1 - minHeightIndex + maxHeightIndex);
            }
        }
    }
}
