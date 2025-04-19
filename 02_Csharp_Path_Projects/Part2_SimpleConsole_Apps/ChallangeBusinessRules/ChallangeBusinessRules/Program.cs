Random random = new Random();

int daysUntilExperation = random.Next(12); //random number between 0 and 11
int discountPercentage = 0;

if (daysUntilExperation <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}    
else if (daysUntilExperation <= 5)
{
    Console.WriteLine($"Your subscription will end in {daysUntilExperation} days.\nRenew now and save 10%");
}
else if (daysUntilExperation == 1)
{
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
}
else
{
    Console.WriteLine("Subscrition has expired!");
}

