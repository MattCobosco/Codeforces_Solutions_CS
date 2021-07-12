using System;

namespace _492A_Vanya_and_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int rowCounter = 0; // counter of rows built with cubes
            int cubesUsed = 0; // counter of cubes used
            int cubesInRow = 0; // number of cubes in each row
            for (int i = 1; ; i++)
            {
                cubesInRow += i; // number of cubes in row is bigger by i with every loop
                cubesUsed += cubesInRow; // number of cubes in row is added to the total counter of used cubes


                if (cubesUsed > n) // if there are no cubes left, break the loop
                    break;
                else // else increase counter of rows built by 1
                    rowCounter++;
            }

            Console.WriteLine(rowCounter); // return the counter of built rows after the loop is finished
        }
    }
}
