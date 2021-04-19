using System;

namespace _1304A_Two_Rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read t as number of cases

            for (int i = 0; i < t; i++) // loop thorugh t cases
            {
                string[] xyab = Console.ReadLine().Split(); // read input as string

                int x = int.Parse(xyab[0]); // paste input string into 4 ints
                int y = int.Parse(xyab[1]);
                int a = int.Parse(xyab[2]);
                int b = int.Parse(xyab[3]);

                int initialDistance = y - x; // calculate the initial distance between rabbits as the difference in coordinates
                int totalHoopDist = a + b; // calculate the sum of distances of single hoop of each rabbit

                int hoopsNeeded = initialDistance / totalHoopDist; // number of seconds needed for the rabbits to meet

                // if the initial distance between rabbits is divisible by the sum of their hoop distance then it means rabbits will eventually be at the same position. It will happen after hoopsNeeded seconds => print hoopsNeeded as answer
                if (initialDistance % totalHoopDist == 0) Console.WriteLine(hoopsNeeded);
                // else (if the intial distance between rabbits isn't divisible by the sum of their hoop distance tne the rabbits won't meet at the same position => print -1 as the answer
                else Console.WriteLine(-1);
            }
        }
    }
}
