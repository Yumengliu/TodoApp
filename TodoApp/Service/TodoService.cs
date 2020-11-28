using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;
using TodoApp.Repository;

namespace TodoApp.Service
{
    public class TodoService : ITodoService
    {
        private readonly TodoItemRepository _todoItemRepository;

        public TodoService(TodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public int CreateTodoItem(string Content)
        {
            TodoItem todoItem = new TodoItem { Content = Content, Finish = false };
            _todoItemRepository.Items.Add(todoItem);
            _todoItemRepository.SaveChanges();
            return todoItem.Id;
        }

        public bool DeleteTodoItem(int Id)
        {
            TodoItem todoItem = GetTodoItem(Id);
            if (todoItem == null)
            {
                return false;
            }
            _todoItemRepository.Items.Remove(todoItem);
            _todoItemRepository.SaveChanges();
            return true;
        }

        public bool ExecuteTodoItem(int Id)
        {
            TodoItem todoItem = GetTodoItem(Id);
            if (todoItem == null)
            {
                return false;
            }
            todoItem.Finish = true;
            _todoItemRepository.SaveChanges();
            return true;
        }

        public TodoItem GetTodoItem(int Id)
        {
            return _todoItemRepository.Items.Find(Id);
        }

        public List<TodoItem> GetTotalTodoItem()
        {
            return _todoItemRepository.Items.ToList();
        }

        public List<TodoItem> GetUnfinishedTodoItem()
        {
            return _todoItemRepository.Items.Where(t => t.Finish == false).ToList();
        }
    }
}
