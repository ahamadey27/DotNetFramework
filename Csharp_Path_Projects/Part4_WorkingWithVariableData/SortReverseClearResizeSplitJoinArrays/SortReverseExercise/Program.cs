string[] pallets = { "B14", "A11", "B12", "A13" };

//Outputs array in alphabetical order
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

//Output array in reverse order
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

//Clearing elemnts of an array (index exists)
Array.Clear(pallets, 0, 2); //cleaing 2 elements starting at index 0
Console.WriteLine($"Clering 2 elements... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

//Resize array by two indices
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

//Using Array.Resize to reduce size of array
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

//Using .ToCharArray() to reverse string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//create new string to output reversed element in array
//string result = new string(valueArray);
string result = String.Join(",", valueArray); //combines chars into new comma seperated value string
Console.WriteLine(result);

//split comma sperated values into a new string array
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

