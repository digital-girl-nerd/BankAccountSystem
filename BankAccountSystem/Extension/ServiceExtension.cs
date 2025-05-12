using BankAccountSystem.Infrastructure.RepositoryContext;
using Microsoft.EntityFrameworkCore;

namespace BankAccountSystem.Extension
{
    public static class ServiceExtension
    {
        private const string REDTECH = "REDTECH";

        //configure database
        public static void ConfigureDatabase(this IServiceCollection services)
        {
            //Setup Environment Variables to connect to the database and hide sensitive information
            var host = Environment.GetEnvironmentVariable(REDTECH + "DBHOST");
            var user = Environment.GetEnvironmentVariable(REDTECH + "DBUSER");
            var password = Environment.GetEnvironmentVariable(REDTECH + "DBPASSWORD");

            //Setup Database Connection String

            var connectionString = "Host=" + host + "; Database = BankAccountSystem; Port=5432; Username=" + user + "; Password=" + password + "; " +
                "Pooling = true;MaxPoolSize =5; ConnectionIdleLifetime = 300;";

            services.AddDbContext<BankAccountContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
        }

        //Run migrations
        public static async void RunMigrationAsync(this WebApplication app)
        {
            await using var scope = app.Services.CreateAsyncScope();
            await using var db = scope.ServiceProvider.GetRequiredService<BankAccountContext>();
            await db.Database.MigrateAsync();

        }

    }
}
