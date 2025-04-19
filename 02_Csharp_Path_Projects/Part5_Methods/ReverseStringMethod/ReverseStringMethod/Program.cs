//Cycling though a string in reverse to return a reversed word or phrase

string input = "chicken is my favorite kinda jam";
Console.WriteLine(input);
Console.WriteLine(ReverseWord(word: input));
Console.WriteLine(ReverseSentence(input: input));


//Reverses entire string
string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length -1; i >= 0; i--) //start from end of word with -1 and i-- since we're cycling through the string backwords
    {
        result += word[i];
    }
    return result;
}

//reverses each letter of the sentance string
string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" "); //create array of strings between each empty space
    foreach(string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim(); //removes extra space at end with .Trim()

}