using Homework9_Part1;

Person person1 = new Person("John Doe");
Vehicle vehicle1 = new Vehicle(Manufacturer.Honda, 6, person1);
Truck truck1 = new Truck(Manufacturer.Ford, 8, new Person("Jane Doe"), 2.5, 5000);

Console.WriteLine(vehicle1);
Console.WriteLine(truck1);

// Test Equals method
Person person2 = new Person("John Doe");
Vehicle vehicle2 = new Vehicle(Manufacturer.Honda, 6, person2);
Console.WriteLine($"vehicle1 equals vehicle2? {vehicle1.Equals(vehicle2)}");

// Test setters
truck1.LoadCapacityTons = 3.0;
truck1.TowingCapacityPounds = 5500;
Console.WriteLine(truck1);