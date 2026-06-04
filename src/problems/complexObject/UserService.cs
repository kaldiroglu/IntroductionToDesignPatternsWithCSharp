using dev.kaldiroglu.dp.intro.problems.complexObject.user;

namespace dev.kaldiroglu.dp.intro.problems.complexObject;

/// <summary>
/// Faithful port of the Java UserService. It coordinates several factories to build a
/// User graph from a request. Because the factories are deliberately left as stubs
/// (they return null), this is the "complex object construction" smell the course uses
/// to motivate the Builder / Factory patterns — the null-forgiving operators below
/// mirror the Java code's assumption that the factories would return real objects.
/// </summary>
public class UserService
{
    public User CreateUser(NewUserRequest newUserRequest, string username, string userEntityId)
    {
        UserFactory userFactory = new UserFactory();
        List<UserRole> userRoleList = new List<UserRole>();
        List<UserCategory> userCategories = new List<UserCategory>();
        List<Configuration> configurations = new List<Configuration>();
        User user = userFactory.CreateUserFromRequest(newUserRequest, username, userEntityId,
                newUserRequest.RemoteAddr, newUserRequest.GetHeader("User-Agent"))!;

        RoleFactory roleFactory = new RoleFactory();
        if (newUserRequest.RoleREntityIds != null
                && newUserRequest.RoleREntityIds.Count > 0)
        {
            foreach (var roleEntityId in newUserRequest.RoleREntityIds)
            {
                UserRole userRole = roleFactory.CreateUserRoleFromRequest(roleEntityId, username, userEntityId,
                        newUserRequest.RemoteAddr, newUserRequest.GetHeader("User-Agent"))!;
                userRole.User = user;
                userRoleList.Add(userRole);
            }
            user.Roles = userRoleList;
        }

        UserCategoryFactory userCategoryFactory = new UserCategoryFactory();
        if (newUserRequest.CategoryEntityIds != null
                && newUserRequest.CategoryEntityIds.Count > 0)
        {
            foreach (var disciplineResourceId in newUserRequest.CategoryEntityIds)
            {
                UserCategory userCategory = userCategoryFactory.CreateCatagoryFromRequest(disciplineResourceId, username, userEntityId,
                        newUserRequest.RemoteAddr, newUserRequest.GetHeader("User-Agent"))!;
                userCategory.User = user;
                userCategories.Add(userCategory);
            }
            user.Categories = userCategories;
        }

        ConfigurationFactory configurationFactory = new ConfigurationFactory();
        if (newUserRequest.ConfigurationEntityIds != null
                && newUserRequest.ConfigurationEntityIds.Count > 0)
        {
            foreach (var configurationEntityId in newUserRequest.ConfigurationEntityIds)
            {
                Configuration configuration = configurationFactory.CreateConfigurationFromRequest(configurationEntityId, username, userEntityId,
                        newUserRequest.RemoteAddr, newUserRequest.GetHeader("User-Agent"))!;
                configuration.User = user;
                configurations.Add(configuration);
            }
            user.Configurations = configurations;
        }

        return user;
    }
}
