using System;

class NumberGuessingGame
{
    static bool IsValidGuess(string input)
    {
        if (int.TryParse(input, out int number) && number >= 1 && number <= 100)
        {
            return true;
        }
        
        return false;
    }

    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101); 
        bool isGuessedCorrectly = false;
        int guessCount = 0;

        Console.Write("Guess a number between 1 and 100: ");
        string userGuess = Console.ReadLine();

        while (!isGuessedCorrectly)
        {
            if (!IsValidGuess(userGuess))
            {
                Console.Write("Invalid input. Please enter a number between 1 and 100: ");
                userGuess = Console.ReadLine();
                continue;
            }
            else
            {
                guessCount++;
                int guessedNumber = int.Parse(userGuess);

                if (guessedNumber < targetNumber)
                {
                    Console.Write("Too low. Guess again: ");
                }
                else if (guessedNumber > targetNumber)
                {
                    Console.Write("Too high. Guess again: ");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                    isGuessedCorrectly = true;
                }
                
                if (!isGuessedCorrectly)
                {
                    userGuess = Console.ReadLine();
                }
            }
        }
    }
}
