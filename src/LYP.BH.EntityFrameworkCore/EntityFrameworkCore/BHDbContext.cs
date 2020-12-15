using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LYP.BH.Authorization.Roles;
using LYP.BH.Authorization.Users;
using LYP.BH.MultiTenancy;

namespace LYP.BH.EntityFrameworkCore
{
    public class BHDbContext : AbpZeroDbContext<Tenant, Role, User, BHDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BHDbContext(DbContextOptions<BHDbContext> options)
            : base(options)
        {
        }
    }
}
