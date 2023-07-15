

using Microsoft.EntityFrameworkCore;

namespace WebApplication3
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<jocuri> Jocuri { get; set; }
    }
}
