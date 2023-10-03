// See https://aka.ms/new-console-template for more information

// Generate a random number between 0 and 100.
Random random = new Random();
int numberToGuess = random.Next(0, 101);

int userGuess = 0;
int numberOfGuesses = 0;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I have selected a number between 0 and 100. Try to guess it!");

while (userGuess != numberToGuess)
{
    // Get the user's guess.
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();

    // Validate the user's input.
    if (!int.TryParse(input, out userGuess))
    {
        Console.WriteLine("Invalid input, please enter an integer!");
        continue;
    }

    // Check if the guess is correct, too high, or too low, and provide feedback.
    if (userGuess > numberToGuess)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else if (userGuess < numberToGuess)
    {
        Console.WriteLine("Too low! Try again.");
    }

    // Increment the guess count.
    numberOfGuesses++;
}

// The user guessed correctly, end the game and provide feedback.
Console.WriteLine($"Congratulations! You guessed the correct number in {numberOfGuesses} guesses!");
        