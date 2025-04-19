//Reverses the order of each word in the string below

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramWords = pangram.Split(" ");
string[] newPangramWords = new string[pangramWords.Length];

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] letters = pangramWords[i].ToCharArray();
    Array.Reverse(letters);
    newPangramWords[i] = new string(letters);
}

string result = String.Join(" ", newPangramWords);
Console.WriteLine(result);
