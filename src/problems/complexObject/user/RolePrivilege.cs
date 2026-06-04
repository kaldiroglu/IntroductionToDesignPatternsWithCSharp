namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class RolePrivilege
{
    public long? Id { get; set; }
    public string? EntityId { get; set; }
    public bool Deleted { get; set; }
    public Privilege? Privilege { get; set; }
    public Role? Role { get; set; }
}
