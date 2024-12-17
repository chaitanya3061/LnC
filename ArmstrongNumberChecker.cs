using System;

class ArmstrongNumberChecker
{
    static int CalculateArmstrongSum(int number)
    {
        // Initializing Sum and Number of Digits
        int sum = 0;
        int numberOfDigits = 0; 
        
        // Calculating Number of individual digits
        int temp = number;
        while (temp > 0)
        {
            numberOfDigits++;
            temp /= 10; 
        }
        
        //Finding Armstrong Number
        temp = number;
        while (temp > 0)
        {
            int lastDigit = temp % 10; 
            sum += (int)Math.Pow(lastDigit, numberOfDigits); 
            temp /= 10; 
        }

        return sum; 
    }

    static void Main()
    {

        Console.Write("Please enter a number to check if it's an Armstrong number:- ");
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
