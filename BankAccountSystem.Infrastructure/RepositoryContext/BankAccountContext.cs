using BankAccountSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace BankAccountSystem.Infrastructure.RepositoryContext
{
    public class BankAccountContext:DbContext
    {
        public BankAccountContext(DbContextOptions<BankAccountContext> context):base(context)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
               base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Account>()
                    .Property(a => a.AccountName)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<Domain.Account>()
                .Property(a => a.AccountType)
                .HasConversion<string>()
                .IsRequired();
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
