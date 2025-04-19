//Program that sums the total amount of items with applied discounts using three methods

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${total}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * discounts[itemIndex];
}
// Check if the total meets the minimum
bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

 // Format the double so only 2 decimal places are displayed
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5); // takes a substring of the string starting at index 0 and going up to 5 characters.
}
   