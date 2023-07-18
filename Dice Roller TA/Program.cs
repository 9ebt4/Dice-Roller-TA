
while (true)
{
    int dice = 0;
    while (true)
    {
        Console.WriteLine("HOW MASSIVE DO YOU WANT YOUR DICE! (enter a number)");
        int input = -1;
        while(!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input: Only enter numbers.");
        }
        if(input<0 || input > int.MaxValue)
        {
            Console.WriteLine($"Only enter numbers between 1 and {int.MaxValue}");
        }
        else
        {
            dice = input;
            break;
        }
    }
    while (true)
    {
        Console.WriteLine("ROLL THE DICE!!!! (roll!!!!)");
        string input = Console.ReadLine().ToLower().Trim();
        if ("roll!!!!".Contains(input))
        {
            break;
        }
        else
        {
            Console.WriteLine("I SAID ROLL THE DICE!!!!");
        }
    }
    int diceOne = RollTheDice(dice);
    int diceTwo = RollTheDice(dice);
    Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}!");
    if(dice == 6)
    {
        if(diceOne == 1 && diceTwo == 1)
        {
            Console.WriteLine("SNAKE EYES!!!");
        }
        if ((diceOne == 1 && diceTwo == 2) || (diceOne == 2 && diceTwo == 1))
        {
            Console.WriteLine("SNAKE EYES!!!");
        }
        if (diceOne == 6 && diceTwo == 6)
        {
            Console.WriteLine("BOX CARS!!!");
        }
        if ((diceOne + diceTwo == 7)|| (diceOne + diceTwo == 11))
        {
            Console.WriteLine("WINNER WINNER CHICKEN DINNER!!!");
        }
        if ((diceOne + diceTwo == 2) || (diceOne + diceTwo == 3) || (diceOne + diceTwo == 11))
        {
            Console.WriteLine("CRAPS!!!");
        }
    }
    
    Console.WriteLine("Would you like to play again? (y/n)");
    if (!Continue())
    {
        Console.WriteLine("Thanks for playing.");
        break;
    }
    else
    {
        Console.Clear();
    }
    
}

static int RollTheDice(int size)
{
    Random dice = new Random();
    return dice.Next(1, size);
    
}

static bool Continue()
{
    while (true)
    {
        string input = Console.ReadLine().ToLower().Trim();
        if ("yes".Contains(input))
        {
            return true;
        }
        else if("no".Contains(input))
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input: Only use y/n");
        }
    }
}