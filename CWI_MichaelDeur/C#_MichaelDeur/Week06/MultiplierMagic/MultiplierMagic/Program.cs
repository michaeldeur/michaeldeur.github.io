//Michael Deur
//September 25, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        string continueLoop = "y";
        int firstNumber = 0;
        int secondNumber = 0;
        int times = 1;

        while (continueLoop == "y" || continueLoop == "Y") {
            times = 1;

            Write("Enter the number you want to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Write("How many times: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[secondNumber];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = firstNumber;
                numbers[i] = numbers[i] * times;
                times++;
                Write("  {0}  ", numbers[i]);
            }
            Write("\nDo you want to enter another number to multiply? Enter Y or N --> ");
            continueLoop = ReadLine();
        }
    }
}