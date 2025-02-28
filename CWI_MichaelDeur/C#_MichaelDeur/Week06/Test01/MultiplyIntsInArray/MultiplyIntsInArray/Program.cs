//Michael Deur
//September 26, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int[ , ] integers = new int[4,2];

        WriteLine("Start of Program - Integer Multipied by Array Length\n");
        
        for(int i = 0; i < 4 ; i++)
        {
            Write("Enter an integer: ");
            integers[i,0] = Convert.ToInt32(Console.ReadLine());

            integers[i,1] = integers[i,0] * integers.Length;
        }

        WriteLine("\nThe result of each integer in the array multiplied by the length of the array is: ");

        for (int i = 0; i < 4; i++)
        {
            WriteLine("{0} * {1} = {2}", integers[i,0], integers.Length, integers[i,1]);
        }
    }
}