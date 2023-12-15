// Services/Helpers/TodoServiceHelper.cs
namespace TodoApi.Services.Helpers
{
    public static class TodoServiceHelper
    {
        // Helper method to generate unique ids
        public static int GenerateUniqueId()
        {
            // Replace with your actual logic to generate unique ids
            return new System.Random().Next(1, int.MaxValue);
        }

        // Helper method to map Todo to TodoDto
        public static TodoDto MapToDto(Todo todo)
        {
            // Replace with your actual mapping logic
            return new TodoDto
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                Completed = todo.Completed,
            };
        }
    }
}
