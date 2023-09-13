// See https://aka.ms/new-console-template for more information
/**
 * File Name: Program.cs
 *
 * Problem Statement: Write a program that determines the change to be dispensed 
 * from a vending machine. An item in the machine can cost between 25 cents and 
 * 1 dollar, in 5-cent increments (25, 30, 35,…,95, 100), and the machine accepts 
 * only a single dollar bill to pay for the item.
 *
 * Overall Plan:
 * 1) Print an initial welcoming message to the screen.
 * 2) Prompt the user to enter the price of the item.
 * 3) Ensure the entered price is between 25 and 100 cents and in 5-cent increments.
 * 4) Calculate the change to be returned.
 * 5) Break down the change into quarters, dimes, and nickels.
 * 6) Display the number of quarters, dimes, and nickels to the user.
 */

Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments):");
int price = int.Parse(Console.ReadLine());

if (price < 25 || price > 100 || price % 5 != 0)
{
    Console.WriteLine("Invalid input. Please enter a value between 25 and 100 in 5-cent increments.");
    return;
}

int change = 100 - price; // since the machine accepts only a single dollar bill

int quarters = change / 25;
change %= 25;

int dimes = change / 10;
change %= 10;

int nickels = change / 5;

Console.WriteLine($"You bought an item for {price} cents and gave me a dollar, so your change is");
Console.WriteLine($"{quarters} quarters,");
Console.WriteLine($"{dimes} dimes, and");
Console.WriteLine($"{nickels} nickels.");

Console.ReadLine(); // To keep the console window open
