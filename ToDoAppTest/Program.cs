namespace ToDoAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrTasks = 0;
            bool nextTask = true;
            int id = 1;
            List<Models.Task> tasks = new List<Models.Task>();
            Console.WriteLine("Hello dear user!");


            Console.WriteLine("What are the tasks you want to do?");

            while (nextTask == true)
            {
                Console.WriteLine("What other tasks are there to do? [Task list " + nrTasks + "]");
                Console.WriteLine("No more tasks? Write:   X");
                Title = title,
                IsCompleted = false,
                Id = id
            };
            tasks.Add(task);
            task.Beep();


                string title = Console.ReadLine();
                if (title == "X" || title == "x")
                {
                    nextTask = false;
                }
                else
                {
                    Models.Task task = new Models.Task
                    {
                        Title = title,
                        IsCompleted = false,
                        Id = id
                    };
                    tasks.Add(task);
                    Console.Clear();
                    nrTasks++;
                }

            }


            foreach (var t in tasks)
            {
                if (t.IsCompleted)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }

                Console.WriteLine($"Task {t.Id}: {t.Title} - Completed: {t.IsCompleted}");
            }
            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}
