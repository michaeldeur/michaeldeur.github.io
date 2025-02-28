//Michael Deur
//September 8, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string sideInput1 = "", sideInput2 = "", sideInput3 = ""; //Variables
        string output = "";
        int side1 = 0, side2 = 0, side3 = 3;

        WriteLine("Enter a value for side 1: "); //Input from user and conversion to int32
        sideInput1 = ReadLine();
        side1 = Convert.ToInt32(sideInput1);

        WriteLine("Enter a value for side 2: ");
        sideInput2 = ReadLine();
        side2 = Convert.ToInt32(sideInput2);

        WriteLine("Enter a value for side 3: ");
        sideInput3 = ReadLine();
        side3 = Convert.ToInt32(sideInput3);

        bool equilateral = (side1 == side2 && side2 == side3); //Boolean
        bool isosceles = (side1 == side2 || side1 == side3 || side2 == side3);

        if (equilateral == true) //Check if triangle is equilateral, isosceles, and scalene
        {
            output = "Equilateral triangle: All sides are equal";

        } else if (isosceles == true)
        {
            output = "Isosceles triangle: Two sides are equal";
        } else
        {
            output = "Scalene triangle: No sides are equal";
        }

        WriteLine(output); // Outputs answer
    }
}
