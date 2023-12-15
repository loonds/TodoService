// Services/Implementations/TodoService.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Models.Dto;
using TodoApi.Services.Helpers; // Ensure this using directive is present

namespace TodoApi.Services.Implementations
{
    public class TodoService : ITodoService
    {
        private readonly List<Todo> _todos; // Replace this with your actual repository or data access logic

        public TodoService()
        {
            // Initialize a sample in-memory repository (replace this with your actual initialization logic)
            _todos = new List<Todo>
            {
                new Todo { Id = 1, Title = "Sample Todo 1", Description = "Description 1", Completed = false },
                new Todo { Id = 2, Title = "Sample Todo 2", Description = "Description 2", Completed = true },
            };
        }

        public async Task<IEnumerable<TodoDto>> GetTodos()
        {
            // Replace with your actual logic to fetch all todos asynchronously
            // Example: return await _repository.GetAllTodosAsync();
            return _todos.Select(todo => TodoServiceHelper.MapToDto(todo));
        }

        public async Task<TodoDto> GetTodoById(int id)
        {
            // Replace with your actual logic to fetch a todo by id asynchronously
            // Example: return await _repository.GetTodoByIdAsync(id);
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            return todo != null ? TodoServiceHelper.MapToDto(todo) : null;
        }

        public async Task<TodoDto> CreateTodo(TodoDto todoDto)
        {
            // Replace with your actual logic to create a new todo asynchronously
            // Example: return await _repository.CreateTodoAsync(todoDto);
            var newTodo = new Todo
            {
                Id = TodoServiceHelper.GenerateUniqueId(),
                Title = todoDto.Title,
                Description = todoDto.Description,
                Completed = todoDto.Completed,
            };

            _todos.Add(newTodo);

            return TodoServiceHelper.MapToDto(newTodo);
        }

        public async Task<TodoDto> UpdateTodo(int id, TodoDto todoDto)
        {
            // Replace with your actual logic to update a todo asynchronously
            // Example: return await _repository.UpdateTodoAsync(id, todoDto);
            var existingTodo = _todos.FirstOrDefault(t => t.Id == id);

            if (existingTodo != null)
            {
                existingTodo.Title = todoDto.Title;
                existingTodo.Description = todoDto.Description;
                existingTodo.Completed = todoDto.Completed;

                return TodoServiceHelper.MapToDto(existingTodo);
            }

            return null; // Todo with the given id not found
        }

        public async Task<bool> DeleteTodo(int id)
        {
            // Replace with your actual logic to delete a todo asynchronously
            // Example: return await _repository.DeleteTodoAsync(id);
            var todoToRemove = _todos.FirstOrDefault(t => t.Id == id);

            if (todoToRemove != null)
            {
                _todos.Remove(todoToRemove);
                return true;
            }

            return false; // Todo with the given id not found
        }

        public async Task SomeCpuBoundOperation()
        {
            // Implement the CPU-bound operation
            // Example: await Task.Run(() => { /* Your CPU-bound work here */ });
        }
    }
}
