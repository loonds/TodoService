// Services/Interfaces/ITodoService.cs
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ITodoService
{
    /// <summary>
    /// Get all todos.
    /// </summary>
    Task<IEnumerable<TodoDto>> GetTodos();

    /// <summary>
    /// Get a todo by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the todo.</param>
    Task<TodoDto> GetTodoById(int id);

    /// <summary>
    /// Create a new todo.
    /// </summary>
    /// <param name="todoDto">The DTO representing the new todo.</param>
    Task<TodoDto> CreateTodo(TodoDto todoDto);

    /// <summary>
    /// Update an existing todo.
    /// </summary>
    /// <param name="id">The unique identifier of the todo to update.</param>
    /// <param name="todoDto">The updated information for the todo.</param>
    Task<TodoDto> UpdateTodo(int id, TodoDto todoDto);

    /// <summary>
    /// Delete a todo by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the todo to delete.</param>
    Task<bool> DeleteTodo(int id);
}
