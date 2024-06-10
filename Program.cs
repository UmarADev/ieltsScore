using System;

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

