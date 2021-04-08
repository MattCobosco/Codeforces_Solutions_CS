using System;

namespace _200B_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] drinks = Console.ReadLine().Split();
            double DrinkTotal = 0;

            for (int i=0; i<n; i++)
            {
                double drink = double.Parse(drinks[i]);
                DrinkTotal += drink;
            }
            Console.WriteLine(DrinkTotal / n);
        }
    }
}
