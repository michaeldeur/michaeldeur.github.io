//Michael Deur
//September 6, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string hrInput = "";
        int hrInt = 0;

        Write("Enter the number of hours you can work: ");
        hrInput = ReadLine();
        hrInt = Convert.ToInt32(hrInput);
        if (hrInt >= 40)
        {
            WriteLine("{0} hours is either equal to or over 40 hours which means you have a full-time schedule", hrInt);
        }
        else
        {
            WriteLine("{0} hours is less than 40 hours which means you have a part-time schedule", hrInt);
        }
    }
}