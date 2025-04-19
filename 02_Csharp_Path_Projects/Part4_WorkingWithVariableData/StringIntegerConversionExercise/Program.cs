using System.ComponentModel;
//Converts array to wo variables that concactenate the string and decimal values respectively
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal totalNum = 0m;
decimal numSum = 0m;

foreach (string value in values)
{

    if (decimal.TryParse(value, out totalNum))
    {
        numSum += totalNum;
    }

    else
    {
        message += value;
    }

}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {numSum}");

