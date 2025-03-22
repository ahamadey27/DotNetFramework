// Declare a nullable string variable to hold the initial user input
string? userInputInitial;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
userInputInitial = Console.ReadLine();

// Trim any leading or trailing whitespace from the user input
string userInputTrim = userInputInitial.Trim();

// Convert the trimmed user input to lowercase for case-insensitive comparison
string userInput = userInputTrim.ToLower();

// Loop until the user enters a valid role name
while (userInput != "administrator" && userInput != "manager" && userInput != "user")
{
    // Inform the user that their input is not valid and prompt them to enter again
    Console.WriteLine($"The role name that you entered, {userInputInitial} is not valid. Enter your role name (Administrator, Manager, or User)");

    // Read the new user input from the console
    userInput = Console.ReadLine();
}

Console.WriteLine($"Your input value {userInput} has been accepted.");