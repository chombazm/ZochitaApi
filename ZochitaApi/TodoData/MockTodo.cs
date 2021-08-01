using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZochitaApi.Models;

namespace ZochitaApi.TodoData
{
    

    public class MockTodo : ITodo
    {
        private List<Todo> todos = new List<Todo>()
        {
            new Todo()
            {
                Id = Guid.NewGuid(),
                Name = "Research about Dart",
                DateAdded = DateTime.Today,
                Completed = false
            },
            new Todo()
            {
                Id = Guid.NewGuid(),
                Name = "Buy Build Fast and Break things!",
                DateAdded = DateTime.Today,
                Completed = false
            },
            new Todo()
            {
                Id = Guid.NewGuid(),
                Name = "Take Course in Flutter",
                DateAdded = DateTime.Today,
                Completed = false
            }
        };


        public Todo AddTodo(Todo todo)
        {
            todo.Id = Guid.NewGuid();
            

            todos.Add(todo);
            return todo;
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo EditTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(Guid id)
        {
            return todos.SingleOrDefault(x => x.Id == id);
        }

        public List<Todo> GetTodos()
        {
            return todos;
        }
    }
}
