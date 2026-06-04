namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

/// <summary>
/// The aggregate root the factories assemble. A classic JavaBean-style entity,
/// ported to C# auto-properties (Java exposed getters/setters over private fields).
/// </summary>
public class User
{
    public long? Id { get; set; }
    public string? EntityId { get; set; }
    public bool Deleted { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public bool Status { get; set; }
    public bool Approved { get; set; }
    public string? ListName { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Organization { get; set; }
    public List<UserRole>? Roles { get; set; }
    public List<UserCategory>? Categories { get; set; }
    public List<Configuration>? Configurations { get; set; }
    public bool Internal { get; set; }
}
