//Michael Deur
//October 02, 2023

using System;
using static System.Console;

class AdmissionModularized
{
    private static string isAccepted(double gpaNum, Double gradeNum)
    {
        string output = "";

        if (gpaNum >= 3.0) //Calculates input
        {
            if (gradeNum >= 60)
            {
                output = "Accept";
            }
            else
            {
                output = "Reject";
            }

        }
        else
        {
            if (gradeNum >= 80)
            {
                output = "Accept";
            }
            else
            {
                output = "Reject";
            }

        }

        return output;
    }


    static void Main()
    {
        string decisionMade = "";
        double gpa = 0.0;
        double score = 0.0;
        WriteLine("Enter grade point average");
        gpa = Convert .ToDouble(Console.ReadLine());

        WriteLine("Enter test score");
        score = Convert .ToDouble(Console.ReadLine());

        decisionMade = isAccepted(gpa, score);

        WriteLine(decisionMade);
    }
}
