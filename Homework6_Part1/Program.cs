
Counter counter = new();
int choice;
do
{
    Console.WriteLine("\n--- Counter Menu ---");
    Console.WriteLine("1. Increment Counter");
    Console.WriteLine("2. Decrement Counter");
    Console.WriteLine("3. Reset Counter");
    Console.WriteLine("4. Display Counter");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");

    int.TryParse(Console.ReadLine(), out choice);

    switch (choice)
    {
        case 1:
            counter.Increment();
            break;
        case 2:
            counter.Decrement();
            break;
        case 3:
            counter.Reset();
            break;
        case 4:
            counter.DisplayCount();
            break;
        case 5:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice! Please choose a valid option.");
            break;
    }

} while (choice != 5);

public class Counter
{
    private int count;

    public Counter()
    {
        count = 0;
    }

    public void Reset()
    {
        count = 0;
    }

    public void Increment()
    {
        count++;
    }

    public void Decrement()
    {
        if (count > 0)
        {
            count--;
        }
    }

    public int GetCount()
    {
        return count;
    }

    public override string ToString()
    {
        return $"Counter: {count}";
    }

    public bool Equals(Counter other)
    {
        return this.count == other.count;
    }

    public void DisplayCount()
    {
        Console.WriteLine("Current count is: " + count);
    }
}

