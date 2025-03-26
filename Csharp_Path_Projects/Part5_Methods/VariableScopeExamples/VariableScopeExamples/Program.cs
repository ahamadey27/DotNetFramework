//the method parameter student takes precedence over the global student array.
string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };
DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });
void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}


//Example of Scpope
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);
void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

//Pass arguments by value types
int a = 3;
int b = 4;
int c = 0;
Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");
void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

//Pass arguments by refernce types
int[] array = { 1, 2, 3, 4, 5 };
PrintArray(array);
Clear(array);
PrintArray(array);
void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}