// TodosController.cs

[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public TodosController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Todo>> GetTodos()
    {
        var todos = _dbContext.Todos.ToList();
        return Ok(todos);
    }

    // Other actions...

}
