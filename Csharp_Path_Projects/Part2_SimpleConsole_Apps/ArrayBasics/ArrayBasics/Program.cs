string[] fradulentOrderIDs = ["string 1", "string2", "string3"];

//fradulentOrderIDs[0] = "A123";
//fradulentOrderIDs[1] = "B456";
//fradulentOrderIDs[2] = "C789";


Console.WriteLine($"First: {fradulentOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentOrderIDs[2]}");

fradulentOrderIDs[0] = "new array";
Console.WriteLine($"Resigned first: {fradulentOrderIDs[0]}");
Console.WriteLine($"There are {fradulentOrderIDs.Length} fraudulent orders to process.");
