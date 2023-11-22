// See https://aka.ms/new-console-template for more information
using Homework7_Lab1;

Pizza myPizza = new Pizza("medium", 2, 3, 1);
Console.WriteLine(myPizza);

// Testing setters
myPizza.Size = "large";
myPizza.CheeseToppings = 3;
myPizza.PepperoniToppings = 2;
myPizza.HamToppings = 1;
Console.WriteLine(myPizza);