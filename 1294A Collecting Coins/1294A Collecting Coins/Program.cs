using System;

namespace _1294A_Collecting_Coins
{
    class Program
    {
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(); // parsing input into 4 ints - a,b,c,n

                int a = int.Parse(input[0]); // Alice's coins
                int b = int.Parse(input[1]); // Barbara's coins
                int c = int.Parse(input[2]); // Cerene's coins
                int n = int.Parse(input[3]); // Polycarp's coin

                // first condition: the total sum of coins they have must be divisible by 3
                // second condition: polycarp must have anough money to cover the differences in sister's wealth
         
                int coinsTotal = a + b + c + n; // calculate total sum of coins
                
                // check which sister has the most coins
                int max = Math.Max(Math.Max(a, b), c);

                // calculate the total difference between the three sisters
                int totalDifference = max - a + max - b + max - c;

                // if both conditions are met then print YES, else print NO
                if (coinsTotal % 3 == 0 && n >= totalDifference) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
