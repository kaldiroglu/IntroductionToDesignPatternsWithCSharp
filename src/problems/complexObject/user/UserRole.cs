namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class UserRole
{
    public long? Id { get; set; }
    public string? EntityId { get; set; }
    public bool Deleted { get; set; }
    public Role? Role { get; set; }
    public User? User { get; set; }
}
