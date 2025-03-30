using System;
using System.Collections.Generic;  // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        DisplayTasks(tasks);
                        break;
                    case 2:
                        AddTask(tasks);
                        break;
                    case 3:
                        MarkTaskComplete(tasks);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        Console.WriteLine(); // Add space after invalid option
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                Console.WriteLine(); // Add space after invalid number input
            }
        }
    }

    static void DisplayTasks(List<string> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            Console.WriteLine(); // Add space before displaying tasks
            Console.WriteLine($"Displaying {tasks.Count} tasks:"); // Debugging statement
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        Console.WriteLine(); // Add space after displaying tasks
    }

    static void AddTask(List<string> tasks)
    {
        Console.Write("Enter the task: ");
        string? task = Console.ReadLine();
        if (!string.IsNullOrEmpty(task))
        {
            tasks.Add(task);
            Console.WriteLine("Task added.");
            Console.WriteLine($"Current tasks count: {tasks.Count}"); // Debugging statement
        }
        else
        {
            Console.WriteLine("Task cannot be empty.");
        }
        Console.WriteLine(); // Add space after adding task
    }

    static void MarkTaskComplete(List<string> tasks)
    {
        Console.Write("Enter the task number to mark complete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1] += " [Complete]";
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
        Console.WriteLine(); // Add space after marking task complete
    }
}
