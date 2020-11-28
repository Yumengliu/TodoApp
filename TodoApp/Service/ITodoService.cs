using System;
using TodoApp.Models;

namespace TodoApp.Service
{
    public interface ITodoService
    {
        int CreateTodoItem(string Content);
        TodoItem GetTodoItem(int Id);
        void ExecuteTodoItem(int Id);
        void DeleteTodoItem(int Id);
    }
}
