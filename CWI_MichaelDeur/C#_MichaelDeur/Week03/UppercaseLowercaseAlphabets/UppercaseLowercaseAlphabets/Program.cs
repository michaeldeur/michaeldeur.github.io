//Michael Deur
//September 8, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        String chInput = ""; //Variables
        String output = "";
        char ch;

        WriteLine("Enter a character: "); //Get input
        chInput = ReadLine();
        ch = Convert.ToChar(chInput);

        bool uppercase = (ch >= 'A' && ch <= 'Z'); //Booleans
        bool lowercase = (ch >= 'a' && ch <= 'z');

        if(uppercase) //Check for uppercase, lowercase, or neither
        {
            output = "Uppercase";

        } else if(lowercase)
        {
            output = "Lowercase";

        } else
        {
            output = "Not an alphabetic character";
        }

        WriteLine(output); //Display output 
    }
}