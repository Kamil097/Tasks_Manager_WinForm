using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management
{
    public class Task
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int User_id { get; set; }
        public int IsDone { get; set; }

        public Task(int id, string name, string description, DateTime deadline, int user_id) 
        {
            Id = id;    
            Name = name;
            Description = description;
            Deadline = deadline;
            User_id = user_id;
            IsDone = 0;
        }
    }       
}
