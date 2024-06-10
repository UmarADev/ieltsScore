using System;
using System.Linq;

PrintLine("Welcome to IELTS score Calculator");

Print("Speaking Score: ");
decimal speakingScore = GetUserScore();

Print("Listening Score: ");
decimal listeningScore = GetUserScore();

Print("Writing Score: ");
decimal writingScore = GetUserScore();

Print("Reading Score: ");
decimal readinScore = GetUserScore();

decimal[] score = {
    speakingScore,
    listeningScore,
    writingScore,
    readinScore
};

decimal avarageScore = score.Average();
int baseScore = (int)avarageScore;
decimal remainder = ExtractRemainder(avarageScore);

avarageScore = baseScore + remainder;
string LevelName = IeltsLevelName(avarageScore);
PrintLine($"Your overall: {avarageScore}\n Your category: {LevelName}");

static void Print(string message)
{
    Console.Write($"{message}");
}

static void PrintLine(string message)
{
    Console.Write($"{message}");
}

static string IeltsLevelName(decimal score)
{
    return score switch
    {
        9 or 8.5m => "Expert",
        8 or 7.5m => "Very Good",
        7 or 6.5m => "Good",
        6 or 5.5m => "Competent",
        5 => "Modest",
        _ => "Incompetent"
    };
}

static decimal ExtractRemainder(decimal avarageScore)
{
    decimal rawRemainder = avarageScore - (int)avarageScore;

    return rawRemainder switch
    {
        < 0.25m => 0,
        < 0.75m => 0.5m,
        _ => 1,
    };
}

static decimal GetUserScore()
{
    string userInput = Console.ReadLine();

    try
    {
        return Convert.ToDecimal(userInput);
    }
    catch (FormatException formatException)
    {
        Console.WriteLine("The score you inserted was invalid.");
        return 0;
    }
}