using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZochitaApi.Models;
using ZochitaApi.TodoData;

namespace ZochitaApi.Controllers
{
    public class TodosController : Controller
    {
        private ITodo _todo;
        public TodosController(ITodo todo)
        {
            _todo = todo;

        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTodo()
        {
            return Ok(_todo.GetTodos());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetTodo(Guid id)
        {
            var todo = _todo.GetTodo(id);
            if (todo != null)
            {
                return Ok(todo);
            }
            return NotFound($"The todo with id {id} is not FOund");
        }


        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetTodo(Todo todo)
        {
            _todo.AddTodo(todo);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + "/" + todo.Id, todo);
        }
    }
}
