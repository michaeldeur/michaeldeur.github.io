//Michael Deur
//September 6, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string numInput = "";
        double numInt = 0;
        Write("Enter a number: ");
        numInput = ReadLine();
        numInt = Convert.ToDouble(numInput);

        if (numInt > 0)
        {  
            WriteLine("{0} is a postitive number", numInt);
        } else if (numInt == 0)
        {
            WriteLine("{0} is neither a positive or negative number", numInt);
        } else
        {
            WriteLine("{0} is a negative number", numInt);
        }
    }
}