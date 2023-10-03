// See https://aka.ms/new-console-template for more information
int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);
       

static int[] GenerateNumbers()
{
    int[] numbers = new int[10];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i + 1;
    }
    return numbers;
}

static void PrintNumbers(int[] numbers)
{
    foreach (int num in numbers)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

static void Reverse(int[] numbers)
{
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[numbers.Length - i - 1];
        numbers[numbers.Length - i - 1] = temp;
    }
}