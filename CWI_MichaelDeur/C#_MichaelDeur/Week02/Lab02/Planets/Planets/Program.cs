//Michael Deur
//August 28, 2023

using static System.Console;

enum planet
{
    Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
}
class Program
{
    static void Main()
    {
        string inputNum = "";
        int outputNum = 0;
        planet planetNum;
        
        Write("Enter a number to see the planet at that position >> ");

        inputNum = ReadLine();
        outputNum = Convert.ToInt32(inputNum);

        WriteLine("You entered {0}", outputNum);

        outputNum--;
        planetNum = (planet)outputNum;
        outputNum++;

        WriteLine("{0} is {1} planet(s) from the sun", planetNum, outputNum);
    }
}