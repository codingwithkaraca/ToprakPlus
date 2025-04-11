using ToprakPlus.DataAccess.Concrete.EntityFramework;
using ToprakPlus.Entities;

namespace ToprakPlus.Web.Extensions;

public static class StartupExtension
{
    public static void AddIdentityWithExtension(this IServiceCollection services)
    {
        services.AddIdentity<User, UserRole>(options =>
        {
            options.User.RequireUniqueEmail = true;
            options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz0123456789-._";
        
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireDigit = true;
        })
        .AddEntityFrameworkStores<ToprakPlusAppContext>();
    }
}