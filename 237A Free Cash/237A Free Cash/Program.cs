using System;
using System.Collections.Generic;

namespace _237A_Free_Cash
{
    class Program
    {
        /*
         * The idea is to first store all hours of client visits in a list, then analyse them to find how many times a most occurring hour appears in the list.
         * To do that, two counters will be needed, a temporary counter that will increase as long as two analysed hours are the same (and which will be reset to 0 if two analyzed hours aren't the same), and an overall counter that will store the highest value found so far.
         */
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // read n from input

            List<string> hoursLog = new List<string>(); // list to store the time of client's visit

            for (int i = 0; i < n; i++) // loop through the hours and add them to the list as strings
            {
                string clientHour = Console.ReadLine();
                hoursLog.Add(clientHour);
            }

            int addCashiers = 0; // counters of additional cashiers needed
            int tempCashiers = 0;

            for (int i = 0; i + 1 < n; i++) // loop through the hours in the list
            {
                string tempClientA = hoursLog[i]; // analyse two consecutive hours of client visit
                string tempClientB = hoursLog[i + 1];

                if (tempClientA == tempClientB) // if those are the same hour then increase the temporary counter of cashiers needed
                {
                    tempCashiers++;

                    if (tempCashiers > addCashiers) // also, if the temp counter is greater than the overall counter, replace the overall value with the temp value
                    {
                        addCashiers = tempCashiers;
                    }
                }
                else // if two analysed hours aren't equal, reset the temp counter to 0
                {
                    tempCashiers = 0;
                }
            }

            Console.WriteLine(1 + addCashiers); // after analysing all client visits, display the result (+ 1 is the single cashier that is enough to serve the customers if they come at separate times)
        }
    }
}
