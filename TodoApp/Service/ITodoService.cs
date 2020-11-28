using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.Service
{
    public interface ITodoService
    {
        int CreateTodoItem(string Content);
        TodoItem GetTodoItem(int Id);
        bool ExecuteTodoItem(int Id);
        bool DeleteTodoItem(int Id);
        List<TodoItem> GetTotalTodoItem();
        List<TodoItem> GetUnfinishedTodoItem();
    }
}
