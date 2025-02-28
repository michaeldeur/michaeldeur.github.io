//Michael Deur
//August 30, 2023

using static System.Console;
class Program
{
    static void Main()
    {
        string readInputNumOne = "";
        string readInputNumTwo = "";
        double numOne = 0;
        double numTwo = 0;

        Write("Compare Two Numbers\n\nEnter the first number: ");

        readInputNumOne = ReadLine();
        numOne = Convert.ToDouble(readInputNumOne);

        Write("Enter the second number: ");

        readInputNumTwo = ReadLine();
        numTwo = Convert.ToDouble(readInputNumTwo);

        if (numOne > numTwo)
        {
            Write("\n{0} is greater than {1}\n\nEnd of Program -- Compare Two Numbers\n", numOne, numTwo);
        } else if (numOne <numTwo)
        {
            Write("\n{0} is less than {1}\n\nEnd of Program -- Compare Two Numbers\n", numOne, numTwo);
        } else
        {
            Write("\n{0} is equal to {1}\n\nEnd of Program -- Compare Two Numbers\n", numOne, numTwo);
        }
    }
}