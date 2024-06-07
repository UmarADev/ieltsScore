using System;

Console.WriteLine("Welcome to the IELTS calculator!");
Console.Write("Please enter your IELTS speaking result: ");
string speakingInput = Console.ReadLine();
double speaking = Convert.ToDouble(speakingInput);

Console.Write("Please enter your IELTS listening result: ");
string listeningInput = Console.ReadLine();
double listening = Convert.ToDouble(listeningInput);

Console.Write("Please enter your IELTS writing result: ");
string writingingInput = Console.ReadLine();
double writing = Convert.ToDouble(writingingInput);

Console.Write("Please enter your IELTS reading result: ");
string readingInput = Console.ReadLine();
double reading = Convert.ToDouble(speakingInput);

double overAll = ShowIeltsResult(speaking, listening, writing, reading);

Console.Write($"{overAll}-");
switch(overAll)
{
    case 9: 
        Console.WriteLine("ExpertUser");
        break;
    case 8: 
        Console.WriteLine("Very Good");
        break;
    case 8.5: 
        Console.WriteLine("Very Good");
        break;
    case 7.5: 
        Console.WriteLine("Good");
        break;
    case 7: 
        Console.WriteLine("Good");
        break;
    case 6.5: 
        Console.WriteLine("Competent");
        break;
    case 6: 
        Console.WriteLine("Competent");
        break;
    case 5.5: 
        Console.WriteLine("Modest");
        break;
    case 5: 
        Console.WriteLine("Modest");
        break;
    default:
        Console.WriteLine("Below or above that range is Invalid");
        break;
}

static double ShowIeltsResult (double speaking, double listening, double writing, double reading)
{
    double score = speaking + listening + writing + reading;
    double overall = score / 4.0;
    return Math.Round(overall);
}