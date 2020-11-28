using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Finish { get; set; }

        public TodoItem()
        {
        }
    }
}
