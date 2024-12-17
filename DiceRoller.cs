using System;

class DiceRoller
{
    static int RollDice(int sides)
    {
        Random random = new Random();
        int result = random.Next(1, sides + 1);
        return result;
    }

    static void Main()
    {
        int diceSides = 6;
        bool keepRolling = true;
        
        while (keepRolling)
        {
            Console.Write("Ready to roll? Enter Q to Quit:-");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "q")
            {
                int rolledNumber = RollDice(diceSides);
                Console.WriteLine($"You have rolled a {rolledNumber}");
            }
            else
            {
                keepRolling = false;
            }
        }
    }
}
