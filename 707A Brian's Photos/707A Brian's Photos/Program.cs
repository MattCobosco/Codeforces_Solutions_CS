using System;

namespace _707A_Brian_s_Photos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(); // read input as string

            // parse input string into n and m
            int n = int.Parse(nm[0]); 
            int m = int.Parse(nm[1]);
            int bwCounter = 0; // counter for black and white pixels
            int colorCounter = 0; // counter for color pixels

            for (int i = 0; i < n; i++) // for loop to analyse input lines, line by line, converting it into a string
            {
                string[] tempString = Console.ReadLine().Split();

                for (int j=0; j < m; j++) // for loop to analyse pixels in each input line, pixel by pixel
                {
                    char tempChar = char.Parse(tempString[j]); // parsing the temp line into chars - pixels

                    //checking if the pixel belongs to B&W pixels - if it's is Black/White/Grey
                    bool b = tempChar.Equals('B'); //bool b - true if pixel is black
                    bool w = tempChar.Equals('W'); //bool w - true if pixel is white
                    bool g = tempChar.Equals('G'); //bool g = true is pixel is grey

                    if (b || w || g) // if the pixel is black/white/grey then increase the counter of b&w pixels by 1
                        bwCounter++;
                    else
                        colorCounter++; // if the analyzed pixel isn't b/w/g then it must be a color pixel
                }
            }
            if (colorCounter != 0) // if there are any color pixels print #Color
                Console.WriteLine("#Color");
            else // if there aren't any color pixels then print #Black&White
                Console.WriteLine("#Black&White");
        }
    }
}
