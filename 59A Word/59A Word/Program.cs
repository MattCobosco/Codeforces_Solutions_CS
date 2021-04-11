using System;

namespace _59A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // read the line and save as string
            char[] inputSplit = input.ToCharArray(); // convert the conver the string into a char array
            bool tempUpper; // bool stating whether the analysed letter is uppercase or not
            int upper = 0; // counter of the uppercase letters
            int lower = 0; // counter of the lowercase letters

            for (int i = 0; i < input.Length; i++) // for loop to analyse the letters one by one
            {
                char tempLetter = inputSplit[i]; //

                tempUpper = char.IsUpper(tempLetter); // checking if the analysed char is uppercase


                if (tempUpper) // if it's uppercase then increase uppercase letter counter by 1
                    upper++;
                else
                    lower++; // if it isn't then increase lowercase letter counter by 1
            }

            if (upper > lower) // if there's more uppercase letters than lowercase letters print the input string converted to uppercase letters
                Console.WriteLine(input.ToUpper());
            else // if there isn't print the input string converted to lowercase letters
                Console.WriteLine(input.ToLower());
        }
    }
}
