//Michael Deur
//August 28, 2023

using static System.Console;


class Program2
{
    enum monthName
    {
        January, Febuary, March, April, May, June, July, August, September, October, November, December
    }
    static void Main()
    {
        string monthNumInput = "";
        int monthNumOutput = 0;
        monthName month;
        

        Write("Enter a month number >> ");

        monthNumInput = ReadLine();
        monthNumOutput = int.Parse(monthNumInput);

        monthNumOutput -= 1;

        month = (monthName)monthNumOutput;

        WriteLine("{0} is month {1}", month, monthNumOutput + 1);
    }
}