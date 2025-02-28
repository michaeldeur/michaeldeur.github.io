//Michael Deur
//September 13, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string tempInput = "";
        double tempNum = 0;
        double tempTot = 0;
        double avgTemp = 0;
        int inc = 0;




        WriteLine("Enter a daily temperature: ");
        tempInput = ReadLine();
        tempNum = Convert.ToDouble(tempInput);

        if (tempNum > -20 && tempNum < 130)
        {
            tempTot += tempNum;
            inc++;
        } else
        {
            WriteLine("  * Invalid Temperature - Must be between -20 and 130 *");
        }

        while (tempNum != 999)
        {
            WriteLine("Enter a daily temperature or 999 to exit: ");
            tempInput = ReadLine();
            tempNum = Convert.ToDouble(tempInput);

            if (tempNum > -20 && tempNum < 130)
            {
                tempTot += tempNum;
                inc++;
            }
            else if (tempNum == 999)
            {
                break;
            } else
            {
                WriteLine("  * Invalid Temperature - Must be between -20 and 130 *");
            }
        }

        avgTemp = tempTot / inc;
        WriteLine("The average daily temperature is: {0}", avgTemp.ToString("F2"));
    }
}