namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class Privilege
{
    public long? Id { get; set; }
    public string? EntityId { get; set; }
    public bool Deleted { get; set; }
    public string? Name { get; set; }
    public List<RolePrivilege>? RolePrivileges { get; set; }
}
