using Homework11_Part1;
static Dictionary<string, NameData> ReadNameFile(string fileName)
{
    Dictionary<string, NameData> nameDictionary = new Dictionary<string, NameData>();
    string[] lines = File.ReadAllLines(fileName);

    for (int i = 0; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(' ');
        if (parts.Length == 2)
        {
            string name = parts[0];
            int count = int.Parse(parts[1]);
            NameData data = new NameData { Rank = i + 1, Count = count };
            nameDictionary[name] = data;
        }
    }

    return nameDictionary;
}

string projectFolder = Directory.GetCurrentDirectory();
Console.WriteLine(projectFolder);
Dictionary<string, NameData> boyNamesDictionary = ReadNameFile(Path.Combine(projectFolder, "boynames.txt"));
Dictionary<string, NameData> girlNamesDictionary = ReadNameFile(Path.Combine(projectFolder, "girlnames.txt"));

while (true)
{
    Console.Write("Enter a name (or 'exit' to quit): ");
    string inputName = Console.ReadLine();

    if (inputName.ToLower() == "exit")
    {
        Console.WriteLine("Exiting the program.");
        break;
    }

    if (boyNamesDictionary.ContainsKey(inputName))
    {
        NameData data = boyNamesDictionary[inputName];
        Console.WriteLine($"{inputName} is ranked {data.Rank} in popularity among boys with {data.Count} namings.");
    }
    else if (girlNamesDictionary.ContainsKey(inputName))
    {
        NameData data = girlNamesDictionary[inputName];
        Console.WriteLine($"{inputName} is ranked {data.Rank} in popularity among girls with {data.Count} namings.");
    }
    else
    {
        Console.WriteLine($"{inputName} is not ranked among the top 1000 boy or girl names.");
    }
}
    

