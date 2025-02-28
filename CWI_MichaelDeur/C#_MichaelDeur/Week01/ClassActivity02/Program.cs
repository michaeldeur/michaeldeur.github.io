// Michael Deur
// August 25, 2023

using static System.Console;

class MoveEstimator
{
    static void Main()
    {
        double estHours = 0;
        double estMiles = 0;
        double estCost = 0;
        string estDec = "0";
        const double hourly = 150;
        const double ratePerMile = 2;
        const double baseNum = 200;

        WriteLine("Please enter the estimated number of hours.");
        estHours = Convert.ToDouble(ReadLine());

        WriteLine("How many miles were involved in the move?");
        estMiles = Convert.ToDouble(ReadLine());

        estCost = baseNum + estHours * hourly + estMiles * ratePerMile;
        estDec = estCost.ToString("C");
        WriteLine("For a move taking {0} hours and going {1} miles the estimate is {2} ", estHours, estMiles, estDec);
    }
}