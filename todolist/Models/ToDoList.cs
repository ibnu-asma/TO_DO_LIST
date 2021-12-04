using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todolist.Models
{
    public class ToDoList
    {
        [Key]
        public int Id { set; get; }
        [DisplayName("your Task")]
        public string YourTask { set; get; }
        [DisplayName("Is Done")]
        public int IsDone { get; set; }
       
    }
}
