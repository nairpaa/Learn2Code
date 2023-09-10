using System;
using System.Collections.Generic;
public class TodoItem
{
    public string Title { get; set; }
    public string Description { get; set; }
}

public class Program
{
    private static List<TodoItem> todoList = new List<TodoItem>();

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add a new to-do item");
            Console.WriteLine("2. List all to-do titles");
            Console.WriteLine("3. View a to-do item's details");
            Console.WriteLine("4. Delete a to-do item");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTodo();
                    break;
                case "2":
                    ListTodos();
                    break;
                case "3":
                    ViewTodo();
                    break;
                case "4":
                    DeleteTodo();
                    break;
                case "5":
                    return; // Keluar dari aplikasi
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddTodo()
    {
        Console.WriteLine("Enter the title of the to-do item:");
        var title = Console.ReadLine();

        Console.WriteLine("Enter the description of the to-do item:");
        var description = Console.ReadLine();

        var item = new TodoItem { Title = title, Description = description };
        todoList.Add(item);
    }

    private static void ListTodos()
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i].Title}");
        }
    }

    private static void ViewTodo()
    {
        Console.WriteLine("Enter the number of the to-do item to view:");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            Console.WriteLine($"Title: {todoList[index - 1].Title}");
            Console.WriteLine($"Description: {todoList[index - 1].Description}");
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }

    private static void DeleteTodo()
    {
        Console.WriteLine("Enter the number of the to-do item to delete:");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList.RemoveAt(index - 1);
            Console.WriteLine("To-do item deleted.");
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
}
