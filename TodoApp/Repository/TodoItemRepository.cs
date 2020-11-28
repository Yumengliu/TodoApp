using System;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Repository
{
    public class TodoItemRepository : DbContext
    {
        public TodoItemRepository(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoItem> Items { get; set; }
    }
}
