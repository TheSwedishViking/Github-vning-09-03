namespace ToDoAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            List<Models.Task> tasks = new List<Models.Task>();
            Console.WriteLine("Hello, Oscar!");
            Console.WriteLine("Today is great!");


            Console.WriteLine("Tasks to do");
            string title = Console.ReadLine();

            Models.Task task = new Models.Task
            {
                Title = title,
                IsCompleted = false,
                Id = id
            };
            tasks.Add(task);
            task.Beep();

            foreach(var t in tasks)
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
