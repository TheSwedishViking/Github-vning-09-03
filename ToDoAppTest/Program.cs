namespace ToDoAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string idNumberPerTask;
            List<Models.Task> tasks = new List<Models.Task>();
            Console.WriteLine("Hello dear user!");

            tasks = ListLogic.ListUserInput(tasks);



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

            bool kundvalBool = true;
            while (kundvalBool)
            {
                Console.Clear();

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

                Console.WriteLine();


                Console.WriteLine("Vill du ta bort ett task?  -  T   ");
                Console.WriteLine("Uppdattera status ?  -     M ");
                Console.WriteLine("Lägga till fler ToDo's?  -     L ");
                Console.WriteLine("Avsluta programmet?  -  A ");
                string kundVal = Console.ReadLine().ToLower();
                if (kundVal == "t")
                {
                    tasks = ListLogic.RemoveTask(tasks);

                }
                if (kundVal == "m")
                {
                    tasks = ListLogic.UpdateList(tasks);

                }
                if (kundVal == "l")
                {
                    tasks = ListLogic.ListUserInput(tasks);
                }
                if (kundVal == "a")
                {
                    tasks = ListLogic.ListUserInput(tasks);


                    kundvalBool = false;

                }
                else
                {
                    Console.WriteLine("felaktig inmatining");
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
}