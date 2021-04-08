using System;

namespace _151_A_Soft_Drinking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);    //n of friends
            int k = int.Parse(input[1]);    //n of bottles
            int l = int.Parse(input[2]);    //mililiters in a bottle
            int c = int.Parse(input[3]);    //n of limes
            int d = int.Parse(input[4]);    //n of slices/lime
            int p = int.Parse(input[5]);    //grams of salt
            int nl = int.Parse(input[6]);   //mililiters/toast
            int np = int.Parse(input[7]);   //grams of salt/toast

            int ml_drink_total = k * l;     //total mililiters of drink they have
            int slices = c * d;             //total n of slices


            int toasts_drink = ml_drink_total / (n * nl);   //n of toasts possble to make from only drink
            int toasts_limes = slices / n;                  //n of toasts ...limes 
            int toasts_salt = p / (n * np);                 //n of toasts ... salt 

            Console.WriteLine(Math.Min(toasts_drink, Math.Min(toasts_limes, toasts_salt)));  //finding the min value of those => the answer to the problem
        }
    }
}
