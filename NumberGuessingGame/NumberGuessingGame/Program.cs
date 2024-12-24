
class Program
{
    static void Main()
    {
        int randomNumber = generateRandomNumber();
        int guessCount = 0;
        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            string userGuess = getUserGuess();
            if (isValidGuess(userGuess))
            {
                int guess = Convert.ToInt32(userGuess);
                guessCount++;

                guessedCorrectly = checkGuess(guess, randomNumber, guessCount);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        }
    }

    static int generateRandomNumber()
    {
        Random rand = new Random();
        return rand.Next(1, 101);
    }

    static string getUserGuess()
    {
        Console.Write("Guess a number between 1 and 100: ");
        string input= Console.ReadLine();
        return input;
    }

    static bool isValidGuess(string guess)
    {
        if (int.TryParse(guess, out int number))
        {
            return number >= 1 && number <= 100;
        }
        return false;
    }

    static bool checkGuess(int guess, int randomNumber, int guessCount)
    {
        if (guess < randomNumber)
        {
            Console.WriteLine("Too low. Guess again.");
            return false;
        }
        else if (guess > randomNumber)
        {
            Console.WriteLine("Too high. Guess again.");
            return false;
        }
        else
        {
            Console.WriteLine($"You guessed it in {guessCount} guesses!");
            return true;
        }
    }
}
