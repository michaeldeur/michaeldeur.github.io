//Team
//October 09, 2023

using System;
using static System.Console;

class Program
{
    private static void GetStringRepeatNum(out string myString, out int repeatTimes)
    {
        //Get string to repeat
        Write("Enter the string to repeat: ");
        myString = ReadLine();

        WriteLine();

        //Get repeat times
        Write("\nEnter how many times to repeat the string: ");
        repeatTimes = Convert.ToInt32(ReadLine());
    }

    private static void PrintString(string str, int repeatTimes)
    {
        for (int i = 0; i < repeatTimes; i++)
        {
            WriteLine(str);
        }
    }
    static void Main(string[] args)
    {
        GetStringRepeatNum(out string enterString, out int repeatNum);
        PrintString(enterString, repeatNum);
    }//end Main
}