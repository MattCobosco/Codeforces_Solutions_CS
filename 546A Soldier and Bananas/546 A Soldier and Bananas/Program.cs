using System;

namespace _546_A_Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int k = int.Parse(tokens[0]);   //cost of the first banana
            int n = int.Parse(tokens[1]);   //inital number of dollars the soldier has
            int w = int.Parse(tokens[2]);   //the amount of banas he wants to have
            //-n? - the amount of dollars he has to borrow

            int i = 0;
            int c = k;

            while (i < w)
            {
                n = n - k;
                k = k + c;
                i++;
            }
            if (n < 0)
            {
                Console.WriteLine(-n);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
