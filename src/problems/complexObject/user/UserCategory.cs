namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class UserCategory
{
    public long? Id { get; set; }
    public string? EntityId { get; set; }
    public bool Deleted { get; set; }
    public Category? Category { get; set; }
    public User? User { get; set; }
}
