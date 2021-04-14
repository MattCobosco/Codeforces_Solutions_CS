using System;

namespace _1154A_Restoring_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); // split input

            int one = int.Parse(input[0]); // assign the 4 elements of split input to ints named one, two, three, four
            int two = int.Parse(input[1]);
            int three = int.Parse(input[2]);
            int four = int.Parse(input[3]);

            // since all of the input numbers are positive the a+b+c will be the greatest of the 4 numbers from input

            int abc = (Math.Max(Math.Max(one, two), Math.Max(three, four))); // selecting the greatest number

            int[] output  = new int[3]; // creating an output 1D array with a size of 3 

            // a, b, c (and one useless 0) can be calculated subtracting ab, ac, cb from abc (we dont know which one is which, hence the names outputOne etc.) 
            int outputOne = abc - one;
            int outputTwo = abc - two;
            int outputThree = abc - three;
            int outputFour = abc - four;

            // check which of the 4 input numbers is abc and put the remaining 3 numbers into output array
            if (abc == one)
            {
                output[0] = outputTwo;
                output[1] = outputThree;
                output[2] = outputFour;
            }
            else if (abc == two)
            {
                output[0] = outputOne;
                output[1] = outputThree;
                output[2] = outputFour;
            }
            else if (abc == three)
            {
                output[0] = outputOne;
                output[1] = outputTwo;
                output[2] = outputFour;
            }
            else
            {
                output[0] = outputOne;
                output[1] = outputTwo;
                output[2] = outputThree;
            }

            //print the output array converted into a string with spaces between them 
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
