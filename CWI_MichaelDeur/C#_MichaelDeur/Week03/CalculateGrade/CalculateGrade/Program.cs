//Michael Deur
//September 8, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string phyInput = "", chemInput = "", bioInput = "", mathInput = "", compInput = ""; //Variables
        double phy = 0, chem = 0, bio = 0, math = 0, comp = 0;
        double per = 0;
        string outputGrade = "";

        Write("Enter total points for Physics : "); //Get input
        phyInput = ReadLine();
        phy = Convert.ToInt32(phyInput);

        Write("Enter total points for Chemistry : ");
        chemInput = ReadLine();
        chem = Convert.ToInt32(chemInput);

        Write("Enter total points for Biology : ");
        bioInput = ReadLine();
        bio = Convert.ToInt32(bioInput);

        Write("Enter total points for Math : ");
        mathInput = ReadLine();
        math = Convert.ToInt32(mathInput);

        Write("Enter total points for Computing : ");
        compInput = ReadLine();
        comp = Convert.ToInt32(compInput);

        per = (phy + chem + bio + math + comp) / 5.0; //Calculate percent

        bool gradeA = (per >= 90); //Booleans
        bool gradeB = (per >= 80);
        bool gradeC = (per >= 70);
        bool gradeD = (per >= 60);

        if (gradeA) //Check grade
        {
            outputGrade = "Grade A";

        } else if (gradeB)
        {
            outputGrade = "Grade B";

        } else if (gradeC)
        {
            outputGrade = "Grade C";

        } else if (gradeD)
        {
            outputGrade = "Grade D";

        } else
        {
            outputGrade = "Grade F";
        }

        WriteLine("Overall percentage for all classes is {0}%\n\n{1}", per, outputGrade); //Display output
    }
}
