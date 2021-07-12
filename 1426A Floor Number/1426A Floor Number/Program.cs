using System;

namespace _1426A_Floor_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); // read number of test cases from input

            for (int i = 0; i < t; i++) // loop through test cases
            {
                string[] testCase = Console.ReadLine().Split(); // read test case as a string array

                int n = int.Parse(testCase[0]); // out n
                int x = int.Parse(testCase[1]); // out x

                int floor; // declare int to assign the floor number to it

                if (n <= 2) // if the apt number is smaller or equal to 2 then it's on the first floor
                    floor = 1;
                else if (n > 2 && n <= x + 2) // if it's between 3 and x+2 then it's on a second floor
                    floor = 2;
                else 
                {
                    for (int j=1; ; j++) // if the apt isn't on floors 1 or 2 then the program needs to calculate the floor using a formula starting with floor 3
                    {
                        int floorMin = j * x + 3; // calculate min apt number on a given floor 
                        int floorMax = (j + 1) * x + 2; // calculate max apt number on a given floor
                        if (floorMin <= n && floorMax >= n) // if Petya's apt is between numbers on a given floor
                        {   
                            floor = j + 2; // save this floor number (+2 to compensate for 2 floors missed by the formula)
                            break; // break the loop
                        }
                    }
                }

                Console.WriteLine(floor); // return the floor number
            }
        }
    }
}
