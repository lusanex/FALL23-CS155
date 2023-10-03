// See https://aka.ms/new-console-template for more information

int[] originalArray = new int[10];

for (int i = 0; i < originalArray.Length; i++)
{
    originalArray[i] = i * i; // Storing squares of the indices as elements.
}

int[] copiedArray = new int[originalArray.Length];

for (int i = 0; i < originalArray.Length; i++)
{
    copiedArray[i] = originalArray[i];
}


Console.WriteLine("Original array:");
foreach (int item in originalArray)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.WriteLine("Copied array:");
foreach (int item in copiedArray)
{
    Console.Write(item + " ");
}
Console.WriteLine();
