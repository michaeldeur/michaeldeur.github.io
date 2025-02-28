//Michael Deur
//September 27, 2023

using System;
using static System.Console;

class PhoneCall
{
    private static double CalcPhoneCallPrice(int minutes, double rate)
    {
        const double BASE_FEE = 0.25;
        double callFee;
        callFee = BASE_FEE + minutes * rate;
        return callFee;
    }

    static void Main()
    {
        int[] callLengths = { 2, 5};
        double[] rates = { 0.03, 0.12};
        double priceOfCall;

        WriteLine("{0, 10}{1, 10}{2, 10}", "Minutes", "Rate", "Price");

        for (int i = 0; i < callLengths.Length; i++)
        {
            for(int j = 0; j < rates.Length; j++)
            {
                priceOfCall = CalcPhoneCallPrice(callLengths[i], rates[j]);
                WriteLine("{0, 10}{1, 10}{2, 10}", callLengths[i], rates[j], priceOfCall.ToString("C"));
            }
        }
    }
}