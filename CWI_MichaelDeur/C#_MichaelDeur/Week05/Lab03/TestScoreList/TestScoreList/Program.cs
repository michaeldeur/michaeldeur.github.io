//Michael Deur
//September 22, 2023

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        double sumScore = 0, avgScore = 0, difScore = 0;
        double[] score = new double[8];

        for (int i = 0; i < score.Length; i++)
        {
            Write("Please enter score for test number {0} >> ", (i+1));
            score[i] = Convert.ToDouble(ReadLine());

            sumScore += score[i];
        }

        avgScore= sumScore / 8;

        WriteLine("Scores for the tests are:");

        for (int i = 0;i < score.Length; i++)
        {
            difScore = score[i]- avgScore;
            WriteLine("Test # 1: {0,6} From average: {1}", score[i], difScore.ToString("F3"));

        }

        WriteLine("Total is {0}", sumScore.ToString("F3"));
        WriteLine("Average is {0}", avgScore.ToString("F3"));
    }
}