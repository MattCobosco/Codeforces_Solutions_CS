using System;

namespace _732A_Buy_a_Shovel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); // convert input to string array
            int k = int.Parse(input[0]); // out k - price of 1 shovel
            int r = int.Parse(input[1]); // out r - coin different from 10

            /* The idea is to calculate the price of n shovels (n=1,2,3...) until the last digit of the price is 0 or r. 10s, 100s and 1000s in the total price can be paid with infinite 10-coins so if the last digit is 0 or r, Polycarp can buy the given amount of shovels without change */

            int lastDigit = k % 10; // get the last digit of original price 
            int counter = 1; // set counter of shovels Polycarp can buy to 1
            int temp = k; // declare temp price of all shovels that will increase by k (price of 1 shovel) with every loop iteration


            while (lastDigit != 0 && lastDigit != r) // while last digit of k/temp isn't r (his exactly one coin of r burles) or 0 (infinite 10 coins) 
            {
                temp += k; // increase the temp by k to establish the price of n shovels
                lastDigit = temp % 10; // calculate the last digit of the price
                counter++; // increase the counter of shovels by 1
            }

            Console.WriteLine(counter); // return counter
        }
    }
}
