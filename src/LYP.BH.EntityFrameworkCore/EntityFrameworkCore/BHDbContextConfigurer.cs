using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LYP.BH.EntityFrameworkCore
{
    public static class BHDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BHDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BHDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
