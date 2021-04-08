using System;

namespace _977A_Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);    //number given to operate on
            int k = int.Parse(input[1]);    //number of operations

            for (int i=0; i<k; i++)
            {
                if (n % 10 != 0)
                {
                    n--;
                }
                else
                {
                    n = n / 10;
                }
            }

            Console.WriteLine(n);
        }
    }
}
