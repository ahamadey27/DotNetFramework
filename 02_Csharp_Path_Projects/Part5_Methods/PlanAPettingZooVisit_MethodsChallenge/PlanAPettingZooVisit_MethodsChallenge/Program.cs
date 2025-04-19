using System;
//Pseudo-Code
/*
- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups*/

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

//RandomizeAnimals();
var group = AssignGroup();
//Console.WriteLine("School A:");
string[,] groups = AssignGroup();

PlanSchoolVisit("School A:");
Console.WriteLine("");
PlanSchoolVisit("School B:", 3);
Console.WriteLine("");
PlanSchoolVisit("School C:", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    Random random = new Random();
    for (int i =0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);//exclues values less than i in pettingZoo
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;

    }
  
   
}

string[,] AssignGroup(int groups = 6) // ',' assigns a 2D array
{
    //groups represents number of animal groups you want to create. Second parameter reflects how many animals are assigned to each group.
    //Because this is 2D array needs two strings per index
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++) //2nd condition returns the length of a specified dimension of a mulit-dimensional array
        {
            result[i, j] = pettingZoo[start++];
        }

    }
    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}