using System;

namespace _263A_Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {   /* 
             * The idea is to split the matrix into rows and elements of the row.
             * In order to do so the 2 for loops are used, first to split the matrix into rows and second to split every row into individual elements.
             * If the analysed element is 1 then the program assigns i+1 and j+1 to variables row and column respectively (+1 to compensate for 0-based counting in C#)
             * Then to calculate the distance from the center one can use the sum of 
             * absolute values of the r3,c3 (center cordinates) minus the cordinates of the "1" element.
             */
            int row = 0; 
            int column=0;
            for (int i=0; i < 5; i++) // split matrix into rows
            {
                string [] inputRow = Console.ReadLine().Split();

                for (int j = 0; j < 5; j++) //split each row into elements and analyse them one by one
                {
                    int inputColumn = int.Parse(inputRow[j]);
                    // if the checked element is 1 then calculate its coordinates and stop the loop 
                    if (inputColumn == 1)
                    {
                        row = i + 1;
                        column = j + 1;
                        break;
                    }
                }
            } // calculate the coordinates and print their sum
            Console.WriteLine(Math.Abs(3 - row) + Math.Abs(3 - column));
        }
    }
}
