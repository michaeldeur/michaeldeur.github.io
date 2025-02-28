//Michael Deur
//September 6, 2023
using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string inputChar = "";
        char testChar = '\0';


        Write("Hit any key on the keyboard and learn what type of character it is: ");
        inputChar = ReadLine();
        testChar = char.Parse(inputChar);

        if ((testChar >= '0') && (testChar <= '9'))
        {
            WriteLine("     {0} is a number", testChar);
        } else if ((testChar >= 'A') && (testChar <= 'Z') || (testChar >= 'a') && (testChar <= 'z'))
        {
            WriteLine("     {0} is an alphabetical character", testChar);
        } else
        {
            WriteLine("     {0} is a Special character", testChar);
        }

    }
}