using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(
                    DbContextOptions<RazorPagesMovieContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}