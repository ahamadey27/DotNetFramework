string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a differnt number");
        }
    }

    else
    {
        Console.WriteLine("You entered an invlaid number. Try again");
    }
}while (validNumber == false);

Console.WriteLine("You have choses wisely.");
//readResult = Console.ReadLine();
