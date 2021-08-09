using System;
using System.Linq;

namespace _584A_Olesya_and_Rodyon
{
    class Program
    { /*
       * The idea is to return t written n times, except special cases which are described below.
       */
        static void Main(string[] args)
        {
            int[] nt = Console.ReadLine().Split().Select(int.Parse).ToArray(); // read input as string of ints
            int n = nt[0]; // length of the number
            int t = nt[1]; // what it should be divisible by

            if (t.ToString().Length>n) // if lenght of t is bigger than n then it's not possible to meet all requirements, so return -1. For n=1 and t=10 => 10 returned 1 time will be 10 so it will be divisible by 10 but longer than 1.
            {
                Console.Write(-1);
            }
            else if (t == 10) // since t can be any int >= 2 and <= 10 the only special case is 10. Returning 10 n times would produce an int of length 2n so instead, the program should return 1 (n-1) times and 1 zero
            {
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write(1);
                }
                Console.Write(0);
            }
            else // in all other cases the answe till be simply t written n times. For t=3 and n=2 the program will return 222.
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(t);
                }
            }
        }
    }
}
