// Models/Todo.cs
public class Todo
{
    public Todo()
    {
        Title = string.Empty;
        Description = string.Empty;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
}
