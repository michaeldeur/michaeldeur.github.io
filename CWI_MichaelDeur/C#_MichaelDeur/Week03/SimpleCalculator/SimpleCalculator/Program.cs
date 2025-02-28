//Michael Deur
//September 8, 2023

using System;
using System.Transactions;
using static System.Console;

class Program
{

    static void Main()
    {
       string dash1 = "", dash2 = ""; //Variables
        string op = "",numInput1 = "", numInput2 = "";
        double num1 = 0, num2 = 0;
        double numTot = 0;

        for (int i = 0; i < 43; i++)
        {
            dash1 = dash1 + "-";
        }
        for (int y = 0; y < 44; y++)
        {
            dash2 += "-";
        }

        WriteLine(dash1);
        WriteLine("    WELCOME TO SIMPLE CALCULATOR\nNeed to enter [number 1] [+ - */] [number 2]");
        WriteLine(dash2);

        Write("Enter first number: ");
        numInput1 = ReadLine();
        num1 = Convert.ToInt32(numInput1);

        Write("Enter operator to use: ");
        op = ReadLine();

        WriteLine("Enter second number: ");
        numInput2 = ReadLine();
        num2 = Convert.ToInt32(numInput2);

        switch(op)
        {
            case +:
                num1 + num2 = numTot;
                break;
            case -:
                num1 - num2 = numTot;
                break;
            case *:
                num1 * num2 = numTot;
                break;
            case /:
                num1 / num2 = numTot;
                break; 
            default:
                break;
        }
        
    }
}