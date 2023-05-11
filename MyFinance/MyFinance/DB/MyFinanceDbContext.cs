using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using MyFinance.Models;

namespace MyFinance.DB
{
    public class MyFinanceDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Spending> Spendings { get; set; }

        public MyFinanceDbContext()
        {

        }

        public MyFinanceDbContext(DbContextOptions<MyFinanceDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-R9DA3P1V\\SQLEXPRESS;Initial Catalog=CHI_HW78;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyFinanceDbContext).Assembly);
        }
    }
}
