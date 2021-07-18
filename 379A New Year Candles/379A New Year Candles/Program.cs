using System;
using System.Linq;

namespace _379A_New_Year_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray(); // read a and b from input as an int array

            int candlesNew = ab[0]; // out a and b from the array as candlesNew (a) and candlesConvertible (b)
            int candlesRatio = ab[1];

            int candlesUsed = 0; // declare a variable to save the amount of used candles that can be converted into new ones
            int hours = 0; // counter of hours


            while (candlesNew > 0) // as long as there are any new candles left
            {
                hours += candlesNew; // increase hours by the amount of new candles available to be used (1 candle = 1 hour)
                candlesUsed += candlesNew; // change new candles into used ones
                candlesNew = candlesUsed / candlesRatio; // calculate the amount of new candles after converting the used ones to new
                candlesUsed = candlesUsed % candlesRatio; // calculate the amount of used candles remaining after the conversion
            }


            Console.WriteLine(hours); //return the hours counter to the console
        }
    }
}
