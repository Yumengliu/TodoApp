using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Service;

namespace TodoApp.Controllers
{
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoService _service;
        public TodoItemController(ITodoService service)
        {
            _service = service;
        }

        [HttpPost("/api/v1/item")]
        public ActionResult<int> CreateTodoItem(string content)
        {
            int ret = _service.CreateTodoItem(content);
            if (ret < 0)
            {
                return BadRequest();
            }
            return Ok(ret);
        }

        [HttpGet("/api/v1/item/{Id}")]
        public ActionResult<TodoItem> GetTodoItem(int Id)
        {
            TodoItem todoItem = _service.GetTodoItem(Id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return Ok(todoItem);
        }

        [HttpPut("/api/v1/item/{Id}")]
        public ActionResult Execute(int Id)
        {
            return _service.ExecuteTodoItem(Id) ? Ok() : NotFound();
        }

        [HttpDelete("/api/v1/item/{Id}")]
        public ActionResult DeleteTodoItem(int Id)
        {
            return _service.DeleteTodoItem(Id) ? Ok() : NotFound();
            
        }

        [HttpGet("/api/v1/item")]
        public ActionResult<List<TodoItem>> GetTotalTodoItem()
        {
            return Ok(_service.GetTotalTodoItem());
        }

        [HttpGet("/api/v1/item/unfinished")]
        public ActionResult<List<TodoItem>> GetUnfinishedTodoItem()
        {
            return Ok(_service.GetUnfinishedTodoItem());
        }

    }
}
