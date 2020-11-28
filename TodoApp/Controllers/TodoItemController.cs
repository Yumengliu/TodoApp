using System;
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
            return Ok(_service.CreateTodoItem(content));
        }

        [HttpGet("/api/v1/item/{Id}")]
        public ActionResult<TodoItem> GetTodoItem(int Id)
        {
            return Ok(_service.GetTodoItem(Id));
        }

        [HttpPut("/api/v1/item/{Id}")]
        public ActionResult Execute(int Id)
        {
            _service.ExecuteTodoItem(Id);
            return Ok();
        }

        [HttpDelete("/api/v1/item/{Id}")]
        public ActionResult DeleteTodoItem(int Id)
        {
            _service.DeleteTodoItem(Id);
            return Ok();
        }
    }
}
