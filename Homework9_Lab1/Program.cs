using Homework9_Lab1;
using File = Homework9_Lab1.File;

static bool ContainsKeyword(Document docObject, string keyword)
{
    if (docObject.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
    {
        return true;
    }
    return false;
}

// Create Email objects
Email email1 = new Email
{
    Sender = "sender@example.com",
    Recipient = "recipient@example.com",
    Title = "Test Email 1"
};
email1.SetEmailText("This is the body of the first test email.");

Email email2 = new Email
{
    Sender = "user@example.com",
    Recipient = "info@example.com",
    Title = "Test Email 2"
};
email2.SetEmailText("This is the body of the second test email containing keyword.");

File file1 = new File
{
    Pathname = "/path/to/file1.txt"
};
file1.SetFileText("Contents of the first file.");

File file2 = new File
{
    Pathname = "/path/to/file2.txt"
};
file2.SetFileText("Contents of the second file with keyword.");


Console.WriteLine(ContainsKeyword(email1, "test")); 
Console.WriteLine(ContainsKeyword(email2, "keyword")); 
Console.WriteLine(ContainsKeyword(file1, "first")); 
Console.WriteLine(ContainsKeyword(file2, "keyword"));