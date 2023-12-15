// Services/Interfaces/ITodoService.cs
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ITodoService
{
    Task<IEnumerable<TodoDto>> GetTodos();
    Task<TodoDto> GetTodoById(int id);
    Task<TodoDto> CreateTodo(TodoDto todoDto);
    Task<TodoDto> UpdateTodo(int id, TodoDto todoDto);
    Task<bool> DeleteTodo(int id);
}

