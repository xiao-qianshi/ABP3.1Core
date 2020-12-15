using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LYP.BH.Configuration;
using LYP.BH.Web;

namespace LYP.BH.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BHDbContextFactory : IDesignTimeDbContextFactory<BHDbContext>
    {
        public BHDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BHDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BHDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BHConsts.ConnectionStringName));

            return new BHDbContext(builder.Options);
        }
    }
}
