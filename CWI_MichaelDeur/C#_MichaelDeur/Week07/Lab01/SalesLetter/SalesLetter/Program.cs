//Michael Deur
//October 2, 2023

using System;
using static System.Console;

class Program
{
    private static void DisplayContactInfo()
    {
        WriteLine("C# Company\r\nPhone: 555-1234     Cell: 555-0912\r\nEmail: csharpcompany@csharp.com\r\nOn the Web at www.csharpcompanyforyou.com");
    }

    static void Main(string[] args)
    {
        WriteLine("From");

        DisplayContactInfo();

        WriteLine("-------------------------");
        WriteLine("Dear Client\r\nWe want to provide you good service.\r\nFeel free to contact us at any time.\r\nLooking forward to a long relationship.");
        WriteLine("-------------------------");

        DisplayContactInfo();

    }
}