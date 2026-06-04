namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class Role
{
    public string? ResourceId { get; set; }
    public bool Deleted { get; set; }
    public string? Name { get; set; }
    public List<UserRole>? UserRoles { get; set; }
    public List<RolePrivilege>? Privileges { get; set; }
}
