int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;


//Display Invoice Number
Console.WriteLine($"Invoice Number: {invoiceNumber}");

//Display the product shares with one thousandth of a share (0.001) precision
Console.WriteLine($"   Shares: {productShares:N3} Product");

//Display the subtotal that you charge the customer formatted as currency
Console.WriteLine($"     Sub Total: {subtotal:C}");

//Display the tax charged on the sale formatted as a percentage
Console.WriteLine($"           Tax: {taxPercentage:P2}");

//Finalize the receipt with the total amount due formatted as currency
Console.WriteLine($"     Total Billed: {total:C}");

//Pads strings to left and right by x amount of spaces...5 would be like 12345
string paymentID = "769C";
string payeeName = "John Bill Ryan";
string paymentAmount = "$5,000.00";
Console.WriteLine("1234567890123456789012345678901234567890");
var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24); //concatentates second variable and adds 24 spaces               
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine(formattedLine);
