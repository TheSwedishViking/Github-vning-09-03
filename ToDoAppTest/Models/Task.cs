using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoAppTest.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public void Beep()
        {
            Console.Beep();
        }
    }
}
