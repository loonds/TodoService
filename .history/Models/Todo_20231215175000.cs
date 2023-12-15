// Models/Todo.cs
public class Todo
{
    public int Id { get; set; }

    // Initialize properties in the constructor or declare them as nullable
    public string Title { get; set; } = string.Empty; // Initialize with an empty string
    public string Description { get; set; } = string.Empty; // Initialize with an empty string
    public bool Completed { get; set; }
}
