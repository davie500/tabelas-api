using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using tech_store_api.Domain.Entities;

namespace tech_store_api.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
