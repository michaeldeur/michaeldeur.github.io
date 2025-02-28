//Michael Deur
//September 15, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        /* string conDec = "";
         double tempInput = 0;
         double tempOutput = 0;

         Write("Press c to convert temperature from Fahrenheit to Celsius\nor\nPress f to convert temperature from Celsius to Fahrenheit\nEnter your choice (c or f): ");
         conDec = (ReadLine());

         if (conDec == "F" || conDec == "f") {
             Write("\nEnter temperature in Celsius: ");
             tempInput = Convert.ToDouble(ReadLine());
             tempOutput = (tempInput * 1.8) + 32;
             WriteLine("\nTemperature in Fahrenheit: {0}", tempOutput);
         } else if (conDec == "C" || conDec == "c") {
             Write("\nEnter temperature in Fahrenheit: ");
             tempInput = Convert.ToDouble(ReadLine());
             tempOutput = (tempInput - 32) / 1.8;
             WriteLine("\nTemperature in Fahrenheit: {0}", tempOutput);
         }
         else
         {
             WriteLine("\nInvalid Choice !!!");
         }*/

        double dSaleDbl = 0;
        double eSaleDbl = 0;
        double fSaleDbl = 0;
        double saleDbl = 0;
        string initialInput = "";
        double totSale = 0;

        Write("Enter a salesperson initial >> ");
        initialInput = String.ToUpper(ReadLine());
        if (initialInput == "D" || initialInput == "E" || initialInput == "F") {
            Write("Enter amount of sale >> ");
            saleDbl = Convert.ToDouble(ReadLine());

            if (initialInput == "D")
            {
                dSaleDbl += dSaleDbl;
            }
            else if (initialInput == "E")
            {
                eSaleDbl += eSaleDbl;
            }
            else if (initialInput == "F")
            {
                fSaleDbl += fSaleDbl;
            }
            else
            {
                WriteLine("  ** Invalid Salesperson");
            }
        }
        else
        {
            WriteLine("  ** Invalid Salesperson");
        }
        while (initialInput == "Z")
            {
                Write("Enter next salesperson initial >> ");
                initialInput = String.ToUpper(ReadLine());
                if (initialInput == "Z")
                {
                    break;
                }
                else
                {
                    WriteLine("  ** Invalid Salesperson");
                    continue;
                }

                Write("Enter amount of sale >> ");
                saleDbl = Convert.ToDouble(ReadLine());

                if (initialInput == "D")
                {
                    dSaleDbl += dSaleDbl;
                }
                else if (initialInput == "E")
                {
                    eSaleDbl += eSaleDbl;
                }
                else if (initialInput == "F")
                {
                    fSaleDbl += fSaleDbl;
                }
                else
                {
                    WriteLine("  ** Invalid Salesperson");
                    continue;
                }
              
            }

        WriteLine("Danielle sold {0} {0,27}", dSaleDbl.ToString("c"));
        WriteLine("Edward sold {0} {0,27}", dSaleDbl.ToString("c"));
        WriteLine("Francis sold {0} {0,27}", dSaleDbl.ToString("c"));

        totSale = dSaleDbl + eSaleDbl+ fSaleDbl;

        WriteLine("Total sales were {0}", totSale.ToString("c"));

        if (dSaleDbl > eSaleDbl && dSaleDbl > fSaleDbl)
        {
            WriteLine("Danielle sold the most");
        } else if (dSaleDbl < eSaleDbl && fSaleDbl < eSaleDbl)
        {
            WriteLine("Edward sold the most");
        } else if (fSaleDbl > dSaleDbl && fSaleDbl > eSaleDbl)
        {
            WriteLine("Francis sold the most");
        } else if (dSaleDbl == eSaleDbl && eSaleDbl == fSaleDbl) {
            WriteLine("Everyone sold the same amount");
        } else if (eSaleDbl == fSaleDbl && eSaleDbl > dSaleDbl)
        {
            WriteLine("Edward and Francis sold the most");
        } else if (eSaleDbl == dSaleDbl && eSaleDbl > fSaleDbl)
        {
            WriteLine("Edward and Danielle sold the most");
        } else if (dSaleDbl ==  fSaleDbl && fSaleDbl > eSaleDbl)
        {
            WriteLine("Danielle and Francis sold the most");
        }
    }
}