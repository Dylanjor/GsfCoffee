using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GsfCoffee.EntityFrameworkCore
{
    public static class GsfCoffeeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GsfCoffeeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GsfCoffeeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
