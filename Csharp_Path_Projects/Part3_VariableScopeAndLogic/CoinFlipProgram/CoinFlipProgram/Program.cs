using System.IO;
using System;

Console.WriteLine("Guess heads or tails.");
string coinGuess = Console.ReadLine();

Random random = new Random();
int flipResult = random.Next(2); //generates random coin toss between 0 and 1
string outcome = (flipResult == 0) ? "heads" : "tails";
if (coinGuess == outcome)
{
    Console.WriteLine($"You guessed {outcome}. The coin is {outcome}. You win");
}
else
{
    Console.WriteLine($"You guessed {coinGuess}. The coin was {outcome}. You lose.");
}
