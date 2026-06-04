namespace dev.kaldiroglu.dp.intro.problems.complexObject.user;

public class RoleFactory
{
    public UserRole? CreateUserRoleFromRequest(string roleEntityId, string? username, string? userEntityId,
                                               string? remoteAddr, string? userAgent)
    {
        UserRole? userRole = null;
        // ...
        return userRole;
    }
}
