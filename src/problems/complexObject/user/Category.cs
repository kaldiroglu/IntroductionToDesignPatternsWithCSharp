namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class Category
{
    public long? Id { get; set; }
    public string? EntityId { get; set; }
    public bool Deleted { get; set; }
    public string? Name { get; set; }
    public List<UserCategory>? UserCategories { get; set; }
}
