Dictionary<string, string> phoneBook = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("Phone Lookup Program");
    Console.WriteLine("1. Add Phone Number");
    Console.WriteLine("2. Find Phone Number");
    Console.WriteLine("3. Delete Phone Number");
    Console.WriteLine("4. Exit");

    Console.Write("Enter your choice (1-4): ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            phoneBook[firstName] = phoneNumber;
            Console.WriteLine("Phone number added.");
            break;
        case "2":
            Console.Write("Enter first name to find phone number: ");
            firstName = Console.ReadLine();
            if (phoneBook.ContainsKey(firstName))
            {
                Console.WriteLine($"Phone number for {firstName}: {phoneBook[firstName]}");
            }
            else
            {
                Console.WriteLine($"No phone number found for {firstName}");
            }
            break;
        case "3":
            Console.Write("Enter first name to delete phone number: ");
            firstName = Console.ReadLine();
            if (phoneBook.ContainsKey(firstName))
            {
                phoneBook.Remove(firstName);
                Console.WriteLine($"Phone number for {firstName} deleted.");
            }
            else
            {
                Console.WriteLine($"No phone number found for {firstName}");
            }
            break;
        case "4":
            Console.WriteLine("Exiting the program.");
            return;
        default:
            Console.WriteLine("Invalid choice. Please enter a valid option (1-4).");
            break;
    }
}
   