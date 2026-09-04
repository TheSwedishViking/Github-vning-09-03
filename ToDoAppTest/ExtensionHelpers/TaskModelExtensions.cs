using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoAppTest.ExtensionHelpers
{
    public static class TaskModelExtensions
    {
        public static string PrintTask(this Models.Task task)
        {
            string taskComplete = task.IsCompleted ? "Completed" : "Not Completed";
            //  Console.WriteLine(TaskModelExtensions.PrintTask(task));
            if (task.IsCompleted)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            return $"Task (Id): {task.Id} | Title:  {task.Title} | Completed?: {task.IsCompleted}";
        }
    }
}
