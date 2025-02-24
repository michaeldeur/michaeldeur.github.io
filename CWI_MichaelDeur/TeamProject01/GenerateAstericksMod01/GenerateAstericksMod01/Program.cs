//Team
//October 09, 2023

using System;
using static System.Console;

class Program
{
    private static void StartAstericksProgram(ref char doAgain)
    {
        int inputNumber = 0;

        WriteLine();

        while (doAgain == 'Y')
        {
            //Get astericks number
            Write("Enter the number of astericks to generate: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            //Calculate the number and convert into a string
            GenerateAstericks(inputNumber);

            WriteLine();

            //Ask for it to continue or not
            Write("\nDo you want to generate another set of astericks? Y or N: ");
            doAgain = Convert.ToChar(ReadLine());

            WriteLine();
        }
    }

    static void GenerateAstericks(int numAstericks)
    {
        int start = 1;
        while (start <= numAstericks)
        {
            Write("*");
            ++start;
        }//end GenerateAstericks
    }
    static void Main(string[] args)
    {
        char doAgain = 'Y';
        StartAstericksProgram(ref doAgain);
    }
}