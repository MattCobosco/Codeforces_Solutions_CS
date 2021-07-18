using System;

namespace _131A_cAPS_lOCK
{
    class Program
      /* 
       * The input is a Caps Lock key case only if all letters except the first one are uppercase, regardless whether the first letter is uppercase of lowercase.
       * Another case is a single letter input - it is always a Caps case. 
       */  
    { 
        static void Caps(string inputString) // Caps function to switch case of the letters in string
        {
            string output = ""; // declare output string
            foreach (char item in inputString) // go through all chars in inputString
            {
                if (char.ToLower(item) != item) // if the char is uppercase
                {
                    output += char.ToLower(item); // change it to lowercase
                }
                else
                {
                    output += char.ToUpper(item); // else change it to uppercase
                }
            }

            Console.WriteLine(output); // return the output to the console
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // read input from console as string

            if (input.Length == 1) // if the input is just a single char
            {
                Caps(input); // use the caps method
            }
            else // if input string consists of more characters
            {
                bool endUpper = false; // declare bool determining whether all letters in a string except the first are uppercase

                for (int i = 1; i < input.Length; i++) // loop through the all letters except the first
                {
                    if (char.IsLower(input[i])) // if any letter is lowercase, set the bool to false, then end the loop (no need to analyse any further, it's not a capslock case)
                    {
                        endUpper = false;
                        break;
                    }
                    else // else set the bool to true
                    {
                        endUpper = true;
                    }
                }

                if (endUpper) // if the letters in input except the first one are all upper => use the caps method to invert the case of the input
                {
                    Caps(input);
                }
                else // else just return the input
                {
                    Console.WriteLine(input);
                }
            }

        }
    }
}
