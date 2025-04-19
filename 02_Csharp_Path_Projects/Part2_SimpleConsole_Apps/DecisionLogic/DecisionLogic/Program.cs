Random dice = new Random(); //Create a new instance of the System.Random class and store a reference to the object in a variable

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}.");

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)) //check rolling double condition
{
    if ((roll1 == roll3) && (roll2 == roll3)) //Nested if / else statement
    {
        Console.WriteLine("You rolled triple three points");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled double. 2 bonus points.");
        total += 2;
    }
    
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine("Sorry you lose");
}

