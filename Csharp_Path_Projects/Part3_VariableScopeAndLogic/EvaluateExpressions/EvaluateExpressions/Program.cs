// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// string pangram = "Foxes and chickens are great!";
// Console.WriteLine(pangram.Contains("foxes") || pangram.Contains("Foxes"));

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50; //if sale amount is greater than 1000 apply 100 discount
Console.WriteLine($"Discount: {discount}");

int saleAmount2 = 900;
Console.WriteLine($"Discount: {(saleAmount2 > 1000 ? 100 : 50)}"); //inline conditional statement

