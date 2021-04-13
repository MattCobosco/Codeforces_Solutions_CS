using System;

namespace _486A_Calculating_Function
{
    class Program // math approach
    {
        static void Main()
        {
            long n = Convert.ToInt64(Console.ReadLine()); // convert input number to long

            long sum; // sum to display the result

            /*
             * if n is an even number the whole formula is divisible into n/2 parts, each part consisting of two ints which can be shown as -x + x+1
             * each of these parts is equal to 1 so their sum is 1*n/2=n/2
             */

            if (n % 2 == 0) sum = n / 2;
             
            /*
             * if n is an odd number it can be divided into a sum of n-1 pairs presented as -x + x+1 and one extra number, which will be the -n
             * the sum of n-1 pairs can be calculated as in above
             * to get the final result, n should be subtracted 
             */

            else
            {
                sum = (n - 1) / 2 - n;
            }
            Console.WriteLine(sum);  // print sum          
        }
    }
}
// algo approach (timeout on Codeforces if the input number is big, works for small ints though)
/*
    static void Main()
        {
            long n = Convert.Tolong32(Console.ReadLine());

            long sum = 0;

            for (long i=1; Math.Abs(i)<=n; i++)  => start with i=1; stop exec if the absolute value of i <= given number; increase i by 1
            {
                i = Math.Abs(i);  => always convert i to positive number at the beginning

                if (i % 2 == 0) => if i is an even number just add it to the sum
                {
                    sum += i;
                }
                else sum -= i; => if i is an odd number subtract it from the sum
            }
            Console.WriteLine(sum);      
        }
*/
