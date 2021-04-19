using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListWebApp.Models
{
    public class Todo
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
