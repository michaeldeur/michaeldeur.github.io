//Michael Deur
//August 28, 2023

using System;
using System.Transactions;
using static System.Console;

class Program
{
    static void Main()
    {
        string chickenOne = "";
        string chickenTwo = "";
        string chickenThree = "";
        string chickenFour = "";
        int chickenOneEggs = 0;
        int chickenTwoEggs = 0;
        int chickenThreeEggs = 0;
        int chickenFourEggs = 0;
        int totalEggs = 0;
        int dozen = 0;
        int leftover = 0;

        WriteLine("Enter the number of eggs from the first chicken >> ");

        chickenOne = ReadLine();
        chickenOneEggs = int.Parse(chickenOne);

        WriteLine("Enter the number of eggs from the second chicken >> ");

        chickenTwo = ReadLine();
        chickenTwoEggs = int.Parse(chickenTwo);

        WriteLine("Enter the number of eggs from the third chicken >> ");

        chickenThree = ReadLine();
        chickenThreeEggs = int.Parse(chickenThree);

        WriteLine("Enter the number of eggs from the fourth chicken >> ");

        chickenFour = ReadLine();
        chickenFourEggs = int.Parse(chickenFour);

        totalEggs = chickenOneEggs + chickenTwoEggs + chickenThreeEggs + chickenFourEggs;
        dozen = totalEggs / 12;
        leftover = totalEggs % 12;

        WriteLine("{0} eggs is {1} dozen and {2}", totalEggs, dozen, leftover);
        /*string enterPrice = "";
        double itemPrice;

        WriteLine("Enter the price of an item: ");

        enterPrice = ReadLine();

        itemPrice = Convert.ToDouble(enterPrice);*/
    }
}