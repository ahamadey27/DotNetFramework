// Create a new instance of the Random class (used to generate random numbers)
Random random = new Random();

// Ask the player if they want to start the game
Console.WriteLine("Would you like to play? (Y/N)");

// Call the ShouldPlay method and use its return value in the if condition
if (ShouldPlay())
{
    // If the user wants to play, start the game loop
    PlayGame();
}

// Method that asks the user if they want to play and returns true or false
bool ShouldPlay()
{
    string response = Console.ReadLine(); // Get input from the user
    return response.ToLower().Equals("y"); // Return true if the response is "y", false otherwise
}

// Main game loop
void PlayGame()
{
    var play = true;

    // Keep playing while the player wants to
    while (play)
    {
        var target = GetTarget();   // Call GetTarget() and store its int return value
        var roll = RollDice();     // Call RollDice() and store its int return value

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");

        // Call WinOrLose with roll and target, and print the result (returned string)
        Console.WriteLine(WinOrLose(roll, target));

        Console.WriteLine("\nPlay again? (Y/N)");

        // Call ShouldPlay again to check if the player wants another round
        play = ShouldPlay();
    }
}

// Returns a random target number between 1 and 5 (inclusive)
int GetTarget()
{
    return random.Next(1, 6); // .Next(min, maxExclusive) generates numbers from min to max-1
}

// Returns a random dice roll between 1 and 6 (inclusive)
int RollDice()
{
    return random.Next(1, 7);
}

// Determines and returns a string based on whether the roll beats the target
string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}
