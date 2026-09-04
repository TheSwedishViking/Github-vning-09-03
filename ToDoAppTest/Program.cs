namespace ToDoAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrTasks = 1;
            bool nextTask = true;

            List<Models.Task> tasks = new List<Models.Task>();
            Console.WriteLine("Hello dear user!");



            while (nextTask == true)
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine(task.Id + " " + task.Title);
                }

                Console.WriteLine("What tasks are there to do? [Task list " + nrTasks + "]");
                Console.WriteLine("No more tasks? Write:    X");


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
                        Id = nrTasks
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