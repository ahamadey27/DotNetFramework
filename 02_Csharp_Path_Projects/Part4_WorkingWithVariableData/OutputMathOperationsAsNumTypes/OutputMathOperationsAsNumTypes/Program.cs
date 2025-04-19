int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

//result1 divides decimal by int and outputs int
int result1 = (int)Math.Round(value1 /  value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//result2 divdes decimal by float and outputs a float
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//result3 divides flat by int and outputs a float
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");