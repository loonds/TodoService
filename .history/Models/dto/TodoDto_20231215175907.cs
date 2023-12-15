// Models/dto/TodoDto.cs
public class TodoDto
{
    public TodoDto()
    {
        Title = string.Empty;
        Description = string.Empty;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
}
