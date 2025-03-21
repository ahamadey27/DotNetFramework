/*In this challenge, we boil down that interaction to its essence. 
A hero and a monster start with the same health score.During the hero's turn, 
they generate a random value that is subtracted from the monster's health. 
If the monster's health is greater than zero, they take their turn and attack the hero. 
As long as both the hero and the monster have health greater than zero, the battle resumes.*/

// Create a new instance of the Random class to generate random numbers
Random dice = new Random();

// Initialize hero and monster health to 10
int heroHealth = 10;
int monsterHealth = 10;

do
{
    // Hero's turn: generate a random value between 1 and 10 and subtract it from the monster's health
    int roll = dice.Next(1, 11);
    monsterHealth -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

    // If the monster's health is less than or equal to 0, skip the monster's turn
    if (monsterHealth <= 0) continue;

    // Monster's turn: generate a random value between 1 and 10 and subtract it from the hero's health
    roll = dice.Next(1, 11);
    heroHealth -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0); // Continue the battle as long as both have health greater than 0

// Determine and display the winner based on who has more health remaining
Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!");