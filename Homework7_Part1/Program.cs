// See https://aka.ms/new-console-template for more information
using Homework7_Part1;

Console.WriteLine("Odometer test: ");
Odometer odometer1 = new();
odometer1.Add(300, 10);
Console.WriteLine(odometer1);

Odometer odometer2 = new(150, 5);
Console.WriteLine(odometer2);

odometer2.Reset();
odometer2.Add(200, 6);
Console.WriteLine(odometer2);