using Microsoft.EntityFrameworkCore;
namespace Dashboard_exercises_API.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Board> Board { get; set; }
    }
}
