namespace ToDoAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
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




        }
    }
}
