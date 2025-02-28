//Michael Deur
// August 25, 2023

using System;
using static System.Console;
class Progrm
{
    static void Main()
    {
        const double timesGetInches = 2.54;
        double inchNum = 0;
        double centNum = 0;

        WriteLine("Enter a number in inches to get it converted to centimeters.");

        inchNum = Convert.ToDouble(ReadLine());
        centNum = inchNum * timesGetInches;
        WriteLine("{0} inches converted into centimeters is {1} centimeters.", inchNum, centNum);
    }
}
