using System;

namespace _344_A_Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read number of magnets
            int[] magnets = new int[n]; // delaring a 1D array to put magnets inside
            int counter = 1; // set counter = 1 => there's at least 1 group of magnets
            
            for (int i=0; i<n; i++) // loop to fill the magnets array with magnets reading the input line by line
            {
                magnets[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j=0; j + 1 < n; j++) // looping through the magnets array n-1 times
            {
                int magnetOne = magnets[j]; // looking at pairs of magnets with j and j+1 index
                int magnetTwo = magnets[j + 1];

                // if magnets aren't the same increase group counter
                // hence counter = 1 => if all magnets are the same, there are no changes so there's only one group
                if (magnetOne != magnetTwo)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter); // print counter
        }
    }
}
