// Services/Implementations/TodoService.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    // ... (repeat for other async methods)

    // Helper method to map Todo to TodoDto
    private TodoDto MapToDto(Todo todo)
    {
        return TodoServiceHelper.MapToDto(todo);
    }
}
