using Microsoft.EntityFrameworkCore;

namespace CRUDApi.models
{
    public class Context : DbContext {

        public DbSet<User> Pessoas {get; set;}

        // Construtor
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}