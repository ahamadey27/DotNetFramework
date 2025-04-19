//How to modify a string to print a certain part of it based on location dercived from chars in the string
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
Console.WriteLine("01234567890123456789012345678901234567890");
Console.WriteLine(message);
//prints only what's inside of paranthesis 
openingPosition += 1; //moves started point one past the paranthesis
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//Prints the first and last 'h's of the message string
message = "hello there";
int first_h = message.IndexOf("h"); 
int last_h = message.LastIndexOf("h");
Console.WriteLine($"For the message: {message} the first 'h' is at a postion of {first_h} and last 'h' is at a postion of {last_h}");

//Retrieve the last occurance of a sub string
message = "(What if) I am (only interested) in the last (set of parentheses)?";
int newOpeningPostion = message.LastIndexOf('(');
newOpeningPostion+= 1;  
int newClosingPosition = message.LastIndexOf(')');
int newLength = newClosingPosition - newOpeningPostion;
Console.WriteLine(message.Substring(newOpeningPostion, newLength));

//Working with IndexOfAny() menthod, which reports index of first occurance of a character in an array
string newMessage = "Hello, World";
char[] charsToFind = { 'a', 'e', 'i' };
int index = newMessage.IndexOfAny(charsToFind);
Console.WriteLine($"Found: '{newMessage[index]}' in '{newMessage}' at index of: {index}");

//Remove character from a specific location from a string
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5);
Console.WriteLine(updatedData);

//Replace() method to replace all occurances of a charecter
string replaceMessage = "This--is--a--te-st";
replaceMessage = replaceMessage.Replace("--", " ");
replaceMessage = replaceMessage.Replace("-", "");
Console.WriteLine(replaceMessage);