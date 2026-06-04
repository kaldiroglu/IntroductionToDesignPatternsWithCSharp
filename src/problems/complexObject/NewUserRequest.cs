namespace dev.kaldiroglu.dp.intro.problems.complexObject;

/// <summary>
/// The incoming request DTO that <see cref="UserService"/> turns into a User graph.
/// Ported from the Java JavaBean to C# auto-properties.
/// </summary>
public class NewUserRequest
{
    public string? Username { get; set; }
    public bool Status { get; set; }
    public string? Email { get; set; }
    public bool Approved { get; set; }
    public string? ListName { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Organization { get; set; }
    public List<string>? RoleREntityIds { get; set; }
    public List<string>? CategoryEntityIds { get; set; }
    public List<string>? ConfigurationEntityIds { get; set; }
    public bool Internal { get; set; }

    public string? RemoteAddr { get; set; }

    // The Java original kept a `header` field but exposed an unusual accessor pair:
    // getHeader(String) ignores the field and returns its argument; setHeader(String, String)
    // is a stub. Preserved here for fidelity.
    public string GetHeader(string header) => header;

    public void SetHeader(string header, string value)
    {
        // ...
    }
}
