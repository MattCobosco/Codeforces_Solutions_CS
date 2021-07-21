using System;
using System.Collections.Generic;
using System.Text;

namespace _118A_String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower(); // uppercase conosants need to be changed to lower. This also changes the case of vowels but those will be deleted.

            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' }; // list with vowels to be deleted from input string

            StringBuilder output = new StringBuilder(); // StringBuilder Class is used to modify input

            for (int i = 0; i < input.Length; i++) // loop through characters in string
            {
                if (vowels.Contains(input[i])) // if the character is vovel, then delete it from the string
                {
                    output.Append("");
                }
                else
                {
                    output.Append("." + input[i]); //else the character must be a conosant so add a '.' in front of it
                }
            }

            Console.WriteLine(output);
        }
    }
}
