//Michael Deur
//October 02, 2023

using System;
using System.Diagnostics;
using static System.Console;

class Program
{
    private static double estimatePaintCost(double width, double length)
    {
        double cost = 0.0;
        const double HEIGHT = 9;
        const double PRICE = 6;

        cost = ((length * HEIGHT * 2) + (width * HEIGHT * 2)) * PRICE;
        return cost;
    }
    static void Main(string[] args)
    {
        double roomLength = 0;
        double roomWidth = 0;
        double Price = 0;

        WriteLine("Enter the length of the room in feet:");
        roomLength = Convert.ToDouble(Console.ReadLine());

        WriteLine("Enter width of room in feet:");
        roomWidth = Convert.ToDouble(Console.ReadLine());

        Price = estimatePaintCost(roomWidth, roomLength);

        WriteLine("Cost of job for {0} x {1} foot room is {2}", roomLength, roomWidth, Price.ToString("C"));
    }
}