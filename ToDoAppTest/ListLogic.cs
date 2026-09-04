namespace ToDoAppTest
{
    public class ListLogic
    {

        public static List<Models.Task> ListUserInput(List<Models.Task> tasks)
        {
            bool nextTask = true;
            int nrTasks = 0;


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
                    nrTasks++;
                    Models.Task task = new Models.Task
                    {
                        Title = title,
                        IsCompleted = false,
                        Id = nrTasks
                    };
                    tasks.Add(task);
                    task.Beep();
                    Console.Clear();
                }

            }
            return tasks;
        }

        public static List<Models.Task> UpdateList(List<Models.Task> tasks)
        {
            bool felinmatning = true;
            int idNumberTask = 0;
            while (felinmatning)
            {
                Console.WriteLine("Markera färdiga tasks!  Skriv Id nummer >> ");
                if (int.TryParse(Console.ReadLine(), out idNumberTask))
                {
                    felinmatning = false;
                }
                else
                {
                    Console.WriteLine("Felinmatning");
                }
            }




            foreach (var task in tasks)
            {
                if (task.Id == idNumberTask)
                {
                    task.IsCompleted = !task.IsCompleted;
                    Console.WriteLine($"Task {task.Id}: {task.Title} - Completed: {task.IsCompleted}");

                }
            }


            return tasks;
        }

        public static List<Models.Task> RemoveTask(List<Models.Task> tasks)
        {
            bool felinmatning = true;
            int idNumberTask = 0;
            while (felinmatning)
            {
                Console.WriteLine("Markera ett task du vill ta bort!  Skriv Id nummer >> ");
                if (int.TryParse(Console.ReadLine(), out idNumberTask))
                {
                    felinmatning = false;
                }
                else
                {
                    Console.WriteLine("Ångrar operationen, felinmatning");
                }
            }


            var thisTask = tasks.FirstOrDefault(t => t.Id == idNumberTask);
            if (thisTask != null)
            {
                Console.WriteLine($"Removed     !  - Task {thisTask.Id}: {thisTask.Title} - Completed: {thisTask.IsCompleted}");
                tasks.Remove(thisTask);
            }
            else
            {
                Console.WriteLine("Todon existerar inte, lämnar");
            }



            Console.WriteLine("tryck valfri tangent");
            Console.ReadKey(true);
            return tasks;
        }

    }
}
