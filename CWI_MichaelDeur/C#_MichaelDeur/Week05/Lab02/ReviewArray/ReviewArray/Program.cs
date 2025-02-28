//Michael Deur
//September 22, 2023

using System;
using System.Reflection.Metadata;
using static System.Console;

class Program
{
    static void Main()
    {
        int inc = 0;
        int[] myArray = new int[5];

        WriteLine("While loop to enter integars in an array");

        while (inc < myArray.Length)
        {
            Write("Enter an integer: ");
            myArray[inc] = Convert.ToInt32(ReadLine());
            inc++;
        }

        WriteLine("\nUse a for loop to display stored in numbers array\n");

        for(int i = 0; i < myArray.Length; i++)
        {
            WriteLine(myArray[i]);
        }
        /*using System;

using static System.Console;

namespace Lecture_TipsList_Chapter6

{

    internal class Program

    {

        static void Main(string[] args)

        {

            const int WEEK = 7;

            double[] tips = new double[WEEK];

            string[] weekday = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            double sumTip = 0, avgTip, offAvgTip;

 

            int cup = 0; //control variable

 

            while (cup < tips.Length) //test the control variable

            {

                Write("Enter you tip for {0}: ", weekday[cup]);

                tips[cup] = Convert.ToDouble(ReadLine());

                sumTip = sumTip + tips[cup];

                ++cup;

                //cup = cup + 1;  //change the control variable

            }//end while

 

            avgTip = sumTip / WEEK;

 

            WriteLine("The average tip for the week is: {0}", avgTip.ToString("C"));

 

            for (int bucket = 0; bucket < WEEK; ++bucket)

            {

                offAvgTip = tips[bucket] - avgTip;

                WriteLine("{0}'s tip, {1}, is {2} from the average tip", weekday[bucket], tips[bucket].ToString("C"), offAvgTip.ToString("C"));

            }//end for loop

 

 

        }

    }

}*/
    }
}