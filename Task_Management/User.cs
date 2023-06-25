using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management
{
    public class User
    {
        public int Id { get; set; } 
        public String Name { get; set; }
        public String Password { get; set; }
        public int TasksAmount { get; set; }
        public int TasksDone { get; set; }

        public User (int id, string name, string password, int tasksAmount, int tasksDone)
        {
            Id = id;
            Name = name;
            Password = password;
            TasksAmount = tasksAmount;
            TasksDone = tasksDone;
        }
    }
}
