//Team Project
//October 09, 2023

using System;
using static System.Console;

class LargestNumber { 
    private static void PrintArray(int[] array){
        Write("Array Values:");
        for (int i = 0; i < array.Length; i++)
        {
            Write("  {0}",array[i]);
        }
        WriteLine();
    }
    private static void SortArray(int[] array) {
        Array.Sort(array);
    }
    private static void PrintLargestValue(int[] array)
    {
        Write("{0}  ", array[array.Length-1]);
    }

    static void Main()
    {
        int[] firstArray = {4, 2, 7, 1};
        int[] secondArray = {20, 70, 40, 90};
        int[] thirdArray = {1, 2, 0};

        PrintArray(firstArray);
        PrintArray(secondArray);
        PrintArray(thirdArray);

        WriteLine();

        SortArray(firstArray);
        SortArray(secondArray);
        SortArray(thirdArray);

        WriteLine("The largest in each array are: ");

        PrintLargestValue(firstArray);
        PrintLargestValue(secondArray);
        PrintLargestValue(thirdArray);  
    }
}