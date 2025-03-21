//Classic FizzBuzz.
//i  divisable by 3 outputs "Fizz"
//i  divisable by 5 outputs "Buzz"
//i  divisable by 3 and 5 outputs "FizzBuzz"


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else
    {
        Console.WriteLine(i);
    }
}