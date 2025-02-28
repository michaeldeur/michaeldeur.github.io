//Michael Deur
//August 28, 2023

using static System.Console;
{
    string test1 = "";
    string test2 = "";
    string test3 = "";
    string test4 = "";
    string test5 = "";
    string test6 = "";
    string test7 = "";
    string test8 = "";
    double testScore1 = 0;
    double testScore2 = 0;
    double testScore3 = 0;
    double testScore4 = 0;
    double testScore5 = 0;
    double testScore6 = 0;
    double testScore7 = 0;
    double testScore8 = 0;
    double totalScore = 0;
    double averageScore = 0;

    Write("Enter test score 1 >> ");

    test1 = ReadLine();
    testScore1 = double.Parse(test1);

    Write("Enter test score 2 >> ");

    test2 = ReadLine();
    testScore2 = double.Parse(test2);

    Write("Enter test score 3 >> ");

    test3 = ReadLine();
    testScore3 = double.Parse(test3);

    Write("Enter test score 4 >> ");

    test4 = ReadLine();
    testScore4 = double.Parse(test4);

    Write("Enter test score 5 >> ");

    test5 = ReadLine();
    testScore5 = double.Parse(test5);

    Write("Enter test score 6 >> ");

    test6 = ReadLine();
    testScore6 = double.Parse(test6);

    Write("Enter test score 7 >> ");

    test7 = ReadLine();
    testScore7 = double.Parse(test7);

    Write("Enter test score 8 >> ");

    test8 = ReadLine();
    testScore8 = double.Parse(test8);

    totalScore = testScore1 + testScore2 + testScore3 + testScore4 + testScore5 + testScore6 + testScore7 + testScore8;
    averageScore = totalScore / 8;



    WriteLine("The average test score is {0}", averageScore.ToString("F2"));
}