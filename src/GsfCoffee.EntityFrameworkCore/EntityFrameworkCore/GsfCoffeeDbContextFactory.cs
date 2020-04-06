using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GsfCoffee.Configuration;
using GsfCoffee.Web;

namespace GsfCoffee.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GsfCoffeeDbContextFactory : IDesignTimeDbContextFactory<GsfCoffeeDbContext>
    {
        public GsfCoffeeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GsfCoffeeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GsfCoffeeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GsfCoffeeConsts.ConnectionStringName));

            return new GsfCoffeeDbContext(builder.Options);
        }
    }
}
