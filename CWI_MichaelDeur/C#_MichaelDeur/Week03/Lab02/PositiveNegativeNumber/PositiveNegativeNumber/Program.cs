//Michael Deur
//September 6,2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string numInput = "";
        int numInt = 0;
        Write("Enter a number");
        numInput = ReadLine();
        numInt = Convert.ToInt32(numInput);

        if (numInt <= 0)
        {
            WriteLine("{0} is a positive number", numInt);
        } else
        {
            WriteLine("{0} is a negative number", numInt);
        }
    }
}