// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using System.Threading;
using static System.Console;
class FihowManyEnterededDebugSihowManyEntered04
{
    private static void FillArray(out int one, int []two)
    {
        one = 0;
        do
        {
            Write("Please enter a number  or 999 to quit: ");
            two[one] = Convert.ToInt32(ReadLine());
            if (two[one] == 999)
            {
                break;
            }
            else
            {
                one++;
            }
        } while (one < 10);
    }

    private static void AddNumArray(out int one, int []two, int three)
    {
        one = 0;
        for (int i = 0; i < three; i++)
        {
            one += two[i]; 
        }
    }
    private static void PrintArray(int one, int[] two)
    {
        for(int i = 0;i < one; i++)
        {
            Write("\t{0}", two[i]);
        }
    }
    static void Main()
    {
        //const int QUIT = 999;
        int[] numArray = new int[10];
        FillArray(out int count, numArray);
        AddNumArray(out int total, numArray, count);
        PrintArray(count, numArray);

        WriteLine("\n You entered {0} numbers", count);
        WriteLine("The total of those {0} numbers is {1}", count, total);
    }
}

