﻿namespace Cadastre.Data
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using SchoolMoneyCalculator.Data;
    using SchoolMoneyCalculator.Data.Models;

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
