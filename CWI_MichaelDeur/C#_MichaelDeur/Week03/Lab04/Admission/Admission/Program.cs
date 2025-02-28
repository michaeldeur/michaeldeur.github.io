//Michael Deur
//September 10, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string gpaInput = ""; //Variables
        string gradeInput = "";
        double gpaNum = 0;
        double gradeNum = 0;
        string output = "";

        Write("Please enter your GPA: "); //Gets user input
        gpaInput = ReadLine();
        gpaNum = Convert.ToDouble(gpaInput);

        Write("Please enter your test score: ");
        gradeInput = ReadLine();
        gradeNum = Convert.ToDouble(gradeInput);

        if(gpaNum >= 3.0) //Calculates input
        {
            if(gradeNum >= 60)
            {
                output = "You are accepted";
            } else
            {
                output = "You are rejected";
            }

        } else
        {
            if(gradeNum >= 80)
            {
                output = "You are accepted";
            } else
            {
                output = "You are rejected";
            }

        }

        WriteLine(output); //Displays output
    }
}