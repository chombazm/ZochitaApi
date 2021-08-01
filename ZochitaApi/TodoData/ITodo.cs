using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZochitaApi.Models;

namespace ZochitaApi.TodoData
{
    public interface ITodo
    {
        List <Todo> GetTodos();

        Todo GetTodo(Guid id);
        Todo AddTodo(Todo todo);
        void DeleteTodo(Todo todo);
        Todo EditTodo(Todo todo);
    }
}
