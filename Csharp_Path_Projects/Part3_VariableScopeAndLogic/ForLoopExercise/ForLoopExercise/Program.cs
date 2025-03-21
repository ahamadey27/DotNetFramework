// for (int i = 0; i < 10; i++) //iteration stops at 9
// {
//     Console.WriteLine(i);
//     if (i == 7)
//     {
//         break;
//     }
// }

//cycle through and output all elements of the length of an array 
//replace "John" element with "Ryan" condition
string[] name = { "Alex", "Bill", "John", "Sam" };
for (int i = 0; i < name.Length; i++)
{
    if (name[i] == "John")
    {
        name[i] = "Ryan";
    }
}

foreach (var names in name)
{
    Console.WriteLine(names);
}