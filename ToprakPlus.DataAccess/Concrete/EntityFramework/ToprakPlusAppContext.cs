using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToprakPlus.Entities;

namespace ToprakPlus.DataAccess.Concrete.EntityFramework;

public class ToprakPlusAppContext : IdentityDbContext<User, UserRole, string>
{
    public ToprakPlusAppContext(DbContextOptions<ToprakPlusAppContext> options) : base(options) { }
    
}