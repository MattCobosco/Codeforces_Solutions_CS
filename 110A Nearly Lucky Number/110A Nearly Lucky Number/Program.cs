using System;

namespace _110A_Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string n = Console.ReadLine(); // read input as string

            char[] nCharArray = n.ToCharArray(); // convert this string into a char array

            int luckyInInput = 0; // counter of lucky digits in input

            for (int i = 0; i < nCharArray.Length; i++) // loop through all elements of input converted into char array
            {
                if(nCharArray[i] == '4' || nCharArray[i] == '7') // if the element in the array is 4 or 7 increase the lucky digit counter by 1
                {
                    luckyInInput ++;
                }
            }

            string luckyString = luckyInInput.ToString(); // convert the counter of lucky digits in input into a string

            char[] luckyCharArray = luckyString.ToCharArray(); // convert it into an array of chars

            int luckyInLucky = 0; // counter of lucky digits in a number of lucky digits in the input number

            for (int j = 0; j < luckyCharArray.Length; j++) // loop through the elements of the array consisting of the lucky digits counter's digits
            {
                if (luckyCharArray[j] == '4' || luckyCharArray[j] == '7') // if the analyse digit is 4 or 7 increase the luckyInLucky counter by 1
                {
                    luckyInLucky++;
                }
            }

            /* if the number of lucky digits in the input is a lucky number
             * (the number of lucky digits in the counter of input's lucky digits is equal to the counter's of lucky digits in input length)
             * print "YES"
             * else print "NO"
             */
            
            if (luckyString.Length == luckyInLucky) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
