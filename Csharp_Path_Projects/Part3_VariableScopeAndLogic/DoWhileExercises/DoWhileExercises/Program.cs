Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 21); //random numbers between 1 and 10 (11 is excluded)
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);

//int current = random.Next(1, 11);
//while(current >= 5)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}

//Console.WriteLine($"Last number is {current}");