// See https://aka.ms/new-console-template for more information
using Homework10_Part1;

AlienPack pack = new AlienPack(3);
pack.AddAlien(new SnakeAlien(100, "Snakey"), 0);
pack.AddAlien(new OgreAlien(100, "Ogry"), 1);
pack.AddAlien(new MarshmallowManAlien(100, "Marshy"), 2);

int totalDamage = pack.CalculateDamage();
Console.WriteLine($"Total damage: {totalDamage}");