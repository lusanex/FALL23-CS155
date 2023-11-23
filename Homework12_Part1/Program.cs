using Homework12_Part1;


List<Person> people = new List<Person>
{
    new Person("Alice", 12, 5.5),
    new Person("Bob", 10, 5.8),
    new Person("Charlie", 4, 5.9),
    new Person("David", 10, 5.7),
    new Person("Eva", 11, 5.4),
    new Person("Fiona", 29, 5.6),
    new Person("George", 31, 6.0),
    new Person("Hannah", 27, 5.5),
    new Person("Ian", 35, 6.1),
    new Person("Julia", 28, 5.3)
};
var kidsMenuEligible = people.Where(p => p.Age <= 12).ToList();
Console.WriteLine("People eligible for the kids menu:");
foreach (var person in kidsMenuEligible)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}");
}
double averageHeight = people.Average(p => p.Height);
var tallerThanAverage = people.Where(p => p.Height > averageHeight).ToList();
Console.WriteLine($"\nAverage height: {averageHeight}");
Console.WriteLine("People taller than the average height:");
foreach (var person in tallerThanAverage)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}");
}

