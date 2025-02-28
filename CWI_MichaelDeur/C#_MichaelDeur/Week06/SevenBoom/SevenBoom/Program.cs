//Team
//September 26, 2023

using System;
using System.Diagnostics.Metrics;
using static System.Console;

class Program
{
    static void Main()
    {
        //Variables
        int[] numbers = new int[8]; //Collects user's list of numbers
        int[] retainNumbers = new int[8]; //Copies numbers[]
        int counter1 = 0; //Finds how many times the program ran
        int counter2 = 0; //Finds where there is a number 7 in the array
        bool sevenBoom = false; //Equal to true if an array value eqauls 7

        //Get input
        for (int i = 0; i < numbers.Length; i++) //Allows for 8 integers total, but if 999 is entered it breaks out of the loop. Also counter1 is counting how many iterations the user is using
        {
            Write("Please enter a number or 999 to quit: "); 
            numbers[i] = Convert.ToInt32(Console.ReadLine()); //Gets input

            if (numbers[i] == 999) //Breaks out of loop if numbers[i] equals 999
            {
                break;
            }
            counter1++; //Counts loop iteration
        }
        WriteLine("\n-- {0} numbers were stored in the array --", counter1); //Displays how many integers/loop iterations were used

        for(int i = 0;i < counter1;i++) { //Writes out the loops integers
            Write("    {0}", numbers[i]);

        }

        for(int i = 0; i < counter1; i++) //Finds if 7 is in the array
        {
            retainNumbers[i] = numbers[i]; //Backs up numbers[] array
            numbers[i] = numbers[i] % 10; //finds the remainder when divided by 10 (0-9)
            counter2 = i; //Counts which iteration the loop is in and both arrays are in
            if (numbers[i] == 7) //Checks if 7
            {
                sevenBoom = true; //Changes bool from false to true
                break; //Leaves loop
            }
        }
        
        WriteLine("\n\n-- Looking for 7 in the Array --"); //Displays that it is looking for 7
        if (sevenBoom == true) //Checks if contains a 7
        {
            WriteLine("BOOM! {0} contains the number 7", retainNumbers[counter2]); //Displays that it does contain a 7 and the number that contains the 7 found by the backup array and the counter which contains the number which the array broke at.
        } else
        {
            WriteLine("7 not found"); //Displays that a 7 does not exist
        }
    }
}