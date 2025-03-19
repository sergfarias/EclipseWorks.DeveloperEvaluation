using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;

namespace Ambev.DeveloperEvaluation.ORM
{
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var builder = new DbContextOptionsBuilder<Context>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                builder.UseSqlServer(
                           connectionString,
                           b => b.MigrationsAssembly("Ambev.DeveloperEvaluation.WebApi")
                 );

                return new Context(builder.Options);
        }
    }
}
