using System;

namespace _1512A_Spy_Detected_
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* the idea is to loop through all numbers twice using a nested loop. Both of the loops will go through all numbers to find the one that occurs only once.
             * The first loop will determine the benchmark number, the second one will compare it to all the numbers in a test case and count its occurences.
             * If the number occurs only once, the loop will break and the position of the spy will be saved
             */
            int t = Convert.ToInt32(Console.ReadLine()); // read number of cases from input as t

            for (int i = 0; i < t; i++) // loop through test cases
            {
                int n = Convert.ToInt32(Console.ReadLine()); // read number of ints in a testcase
                string[] testCase = Console.ReadLine().Split(); // read numbers from test case
                int spyPos = 0; // declaration of spy position
                int benchOccurenceCounter = 0; // declaration of occurence counter for each of the ints in a test case

                for (int j = 0; j < n; j++) // loop through all numbers in a test case
                {
                    int bench = int.Parse(testCase[j]); // currently analysed number of a test case in a benchmark number

                    for (int k = 0; k < n; k++) // nested loop, again going through all numbers in a test case
                    {
                        int currAnalysed = int.Parse(testCase[k]); // cuttently analysed number in a nested loop

                        if (bench == currAnalysed) // of the number's are identical, increase the occurence counter by 1
                        {
                            benchOccurenceCounter++;
                        }

                        spyPos = j + 1; // save the spy position (+1 to compensate for 0-based index numbering in C#) - this is continously saved, no matter if the spy has been identified or not. It goes to the console only if the spy is found.
                    }

                    if (benchOccurenceCounter == 1) // if benchmark number occurs only once then the spy has been found, break the loop (finish the analysis)
                    {
                        break;
                    }
                    else //if it occurs more then once then it's not the spy, reset the benchmark occurence counter
                    {
                        benchOccurenceCounter = 0;
                    }
                }

                Console.WriteLine(spyPos); // after the analysis is finished return the spyPos to console
            }
        }
    }
}
