using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoAppTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<Models.Task> Tasks { get; set; }
    }
}
