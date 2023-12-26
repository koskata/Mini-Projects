namespace Cadastre.Data
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using CashApp.Data;
    using CashApp.Data.Models;

    public class CalculatorContext : DbContext
    {
        public CalculatorContext()
        {

        }

        public CalculatorContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Calculator> Calculators { get; set; }

        public DbSet<Balance> Balances { get; set; }

        public DbSet<Payment> Payments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
