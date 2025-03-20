// Array of fraudulent order IDs
string[] fraudulantOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Iterate through each order ID in the array
foreach (string orderIDs in fraudulantOrderIDs)
{
    // Check if the order ID starts with the letter 'B'
    if (orderIDs.StartsWith("B"))
    {
        // Print the order ID to the console
        Console.WriteLine(orderIDs);
    }
}