class ArmstrongNumberChecker
{
    static int CalculateArmstrongSum(int number)
    {
        int sum = 0;
        int numberOfDigits = 0;
        
        // Calculating the number of digits
        int remainingNumber = number;
        while (remainingNumber > 0)
        {
            numberOfDigits++;
            remainingNumber /= 10;
        }
        
        // Calculating Armstrong sum
        remainingNumber = number;
        while (remainingNumber > 0)
        {
            int lastDigit = remainingNumber % 10;
            sum += (int)Math.Pow(lastDigit, numberOfDigits);
            remainingNumber /= 10;
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Please enter a number to check if it's an Armstrong number: ");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput == CalculateArmstrongSum(userInput))
        {
            Console.WriteLine($"\n{userInput} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"\n{userInput} is not an Armstrong number.");
        }
    }
}
