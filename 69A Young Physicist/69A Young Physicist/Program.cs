using System;

namespace _69A_Young_Physicist
{
    class Program
    {
        static void Main(string[] args) // to solve this problem one needs to sum the respective coordinates of the given vectors. If all of them are 0 then the foces are balanced and the object doesn't move.
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read n from input
            int sumX = 0; // sums of each coordinate
            int sumY = 0;
            int sumZ = 0;
            for (int i = 0; i < n; i++) // loop through vectors
            {
                string[] vector = Console.ReadLine().Split(); // split each vector into x,y,z coordinates

                int x = int.Parse(vector[0]);
                int y = int.Parse(vector[1]);
                int z = int.Parse(vector[2]);

                sumX += x; // add each vector coordinate to their respective sum
                sumY += y;
                sumZ += z;
            }

            if (sumX == 0 && sumY == 0 && sumZ == 0) // if all sums are equal to 0 then the object is stationary
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO"); // if any sum isn't 0 then the object is moving
        }
    }
}
