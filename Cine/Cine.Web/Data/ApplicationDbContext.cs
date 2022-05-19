using Cine.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Cine.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet <Cinema> cinemas{ get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cinema>().HasIndex(t => t.Name).IsUnique();
        }
    }
}
