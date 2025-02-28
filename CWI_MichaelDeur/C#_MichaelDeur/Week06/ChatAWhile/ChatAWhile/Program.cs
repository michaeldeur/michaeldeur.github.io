//Team
//September 25, 2023


using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int arrayPlace = 0;
        double callRate = 0.0;
        double costTot = 0.0;
        int[] areaCodeInput = {262, 414, 608, 715, 815, 920};
        bool isCodeTrue = false;
        double[] perMinute = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
        int areaCodeOuput = 0;
        int areaCode = 0;
        int minutes = 0;

        Console.WriteLine("what area code are you calling?");
        areaCode = Convert.ToInt32(ReadLine());

        WriteLine("Enter the length of your call in minutes");
        minutes = Convert.ToInt32(ReadLine());

        for(int i = 0; i < areaCodeInput.Length; i++)
        {
            if(areaCode == areaCodeInput[i])
            {
                isCodeTrue = true;
                areaCodeOuput = areaCodeInput[i];
                arrayPlace = i;
            }
        }
        if(isCodeTrue == true)
        {
            callRate = perMinute[arrayPlace];
            costTot = callRate * minutes;

            WriteLine("The cost of your call to {0} will be {1}", areaCodeOuput, costTot.ToString("C"));
            WriteLine("The rate applied to the call was: {0}", callRate);
        }
        else
        {
            WriteLine("Error: {0} is not a valid area code", areaCode);
        }
    }
}