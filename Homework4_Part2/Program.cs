// See https://aka.ms/new-console-template for more information
/**
 * File Name: Program.cs
 *
 *  The user will input either an “h” for heads or a “t” for tails for the eight tosses. 
 *  The program will then print out the total number and percentages of heads and tails. 
 *  Use the increment operator to increment the number of tosses as each toss is input. 
 *
 * Overall Plan:
 * 1) Input user
 * 2) switch user input 
 * 3) increment according answer
 * 4) calculate total number
 * 5) calculate percentage
 * 6) print total number and percentage
 */

string[] tossNames = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth" };
int headsCount = 0, tailsCount = 0;

Console.WriteLine("For each coin toss enter either ‘h’ for heads or ‘t’ for tails.\n");

for (int i = 0; i < 8; i++)
{
    Console.Write($"{tossNames[i]} toss: ");
    char input = Console.ReadKey().KeyChar;
    Console.WriteLine(); // Move to the next line after user input

    if (input == 'h' || input == 'H')
    {
        headsCount++;
    }
    else if (input == 't' || input == 'T')
    {
        tailsCount++;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter ‘h’ for heads or ‘t’ for tails.");
        i--; // Decrement the counter to repeat the iteration for invalid input
    }
}

double headsPercent = (headsCount / 8.0) * 100;
double tailsPercent = (tailsCount / 8.0) * 100;

Console.WriteLine($"\nNumber of heads: {headsCount}");
Console.WriteLine($"Number of tails: {tailsCount}");
Console.WriteLine($"Percent heads: {headsPercent:F2}");
Console.WriteLine($"Percent tails: {tailsPercent:F2}");

Console.ReadKey(); // Keep the console window open
