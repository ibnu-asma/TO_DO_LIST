using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todolist.Models
{
    public class ToDoList
    {
        [Key]
        public int Id { set; get; }
        public string YourTask { set; get; }
       public bool IsDone { set; get; } 
    }
}
