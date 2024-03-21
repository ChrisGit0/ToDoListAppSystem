using System;
using System.Collections.Generic;

public class ToDoItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public ToDoItem(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }
}

public class ToDoListApp
{
    private List<ToDoItem> toDoList;

    public ToDoListApp()
    {
        toDoList = new List<ToDoItem>();
    }

    public void AddToDoItem(string title, string description, DateTime dueDate)
    {
        ToDoItem newItem = new ToDoItem(title, description, dueDate);
        toDoList.Add(newItem);
    }

    public void MarkItemAsCompleted(int index)
    {
        if (index >= 0 && index < toDoList.Count)
        {
            toDoList[index].IsCompleted = true;
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    public void DisplayToDoList()
    {
        Console.WriteLine("ToDo List:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"[{i}] - Title: {toDoList[i].Title}, Description: {toDoList[i].Description}, Due Date: {toDoList[i].DueDate}, Completed: {toDoList[i].IsCompleted}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ToDoListApp toDoApp = new ToDoListApp();
        
        // Adding items to the ToDo List
        toDoApp.AddToDoItem("Finish report", "Complete the quarterly report for the meeting", DateTime.Now.AddDays(7));
        toDoApp.AddToDoItem("Buy groceries", "Get milk, bread, and eggs", DateTime.Now.AddDays(2));

        // Displaying the ToDo List
        toDoApp.DisplayToDoList();

        // Marking an item as completed
        toDoApp.MarkItemAsCompleted(0);

        // Displaying the ToDo List again after marking an item as completed
        toDoApp.DisplayToDoList();
    }
}