// String Demo
// Using Data Strings page 76 - 80
// 

using System;
using static System.Console;

class DemoStrings
{
    static void Main()
    {
        string first = "MicrosoftC#";
        string second = "Angularjs";
        string third = "jQuery";
        string firstLFirst = "";
        string secondLFirst = "";
        string thirdLFirst = "";
        string firstLLast = "";
        string secondLLast = "";
        string thirdLLast = "";

        firstLFirst = first.Substring(0, 1);
        secondLFirst = second.Substring(0, 1);
        thirdLFirst = third.Substring(0, 1);

        firstLLast = first.Substring(first.Length - 1);
        secondLLast = second.Substring(second.Length - 1);
        thirdLLast = third.Substring(third.Length - 1);

        first = first.Substring(1, first.Length - 2);
        second = second.Substring(1, second.Length - 2);
        third = third.Substring(1, third.Length - 2);

        WriteLine("{0}{1}{2}\n{3}{4}{5}\n{6}{7}{8}", firstLLast, first, firstLFirst, secondLLast,  second, secondLFirst, thirdLLast, third, thirdLFirst);

        /* string enterWord, newWord;
         int wordLength;

         Write("Enter a three character word to see it in reverse order: ");
         enterWord = ReadLine();

         wordLength = enterWord.Length;
         WriteLine("\nThe length is: {0} ", wordLength);

         //variableName.Substring( ?, ?)
         //What is the starting position?
         //How many characters do I want?
         WriteLine("\nHere is each character in the word: ");
         WriteLine("The letter is: {0}", enterWord.Substring(0, 1));
         WriteLine("The letter is: {0}", enterWord.Substring(1, 1));
         WriteLine("The letter is: {0}", enterWord.Substring(2, 1));


         // Using an equation to answer --> What is the starting position?
         // equation must evaluate to an integer
         WriteLine("\nGet a position with an equation: ");
         WriteLine("The letter is: {0}", enterWord.Substring(wordLength - 3, 1));
         WriteLine("The letter is: {0}", enterWord.Substring(wordLength - 2, 1));
         WriteLine("The letter is: {0}", enterWord.Substring(wordLength - 1, 1));

         newWord = enterWord.Substring(wordLength - 1, 1) + enterWord.Substring(wordLength - 2, 1) + enterWord.Substring(wordLength - 3, 1);

         WriteLine("\nThe original word was {0}. In reverse order, the word is {1}", enterWord, newWord);*/

    }
}