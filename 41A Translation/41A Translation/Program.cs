using System;

namespace _41A_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            // dividing first and second word into letters from input
            char[] s = Console.ReadLine().ToCharArray(); 
            char[] t = Console.ReadLine().ToCharArray();

            // declaring the indexes of the letters that will be compared (first letter of the first word and last letter of the last word
            int i = 0;
            int j = t.Length - 1; // compensation for 0 - based numbering in C#]

            // declaring the counter of the matching letters and setting it to 0
           int matchCounter = 0;

            // while loop to check all letters in both words (j>=0 because j is equal to 0 in the last loop cycle)
            while (i < s.Length && j >= 0)
            {   
                char sTempLetter = s[i]; // analysed letter from the first word is letter with i index (goes from 0 to s.Length)
                char tTempLetter = t[j]; // analysed letter from the second word is letter with j index (goes from (t.Length-1) to 0) 
                if (sTempLetter.Equals(tTempLetter))
                    matchCounter++;

                i++; // go to next letter of the first word
                j--; // go to the previous letter of the second word
            }
            if (matchCounter == s.Length) // if the number of matching letters is equal to the number of letters in the word then print YES
                Console.WriteLine("YES");
            else //if it isn't print no
                Console.WriteLine("NO");
        }
    }
}
