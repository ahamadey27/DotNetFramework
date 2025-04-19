string first = "Hello";
string second = "hammer";
string third = "third";
decimal costOne = 12.4m;
int costTwo = 45;
decimal measurement = 123456.78912m;
decimal percentage = .564653m;

string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine($"{first} {first}");

Console.WriteLine($"{costOne:C}");

Console.WriteLine($"{measurement:N3}");

Console.WriteLine($"{percentage:P3}");
string newString = String.Format("You saved {0:P} at the price of {1:C}.", percentage, (measurement - costOne));
Console.WriteLine(newString);