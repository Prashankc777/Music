using Microsoft.EntityFrameworkCore;
using Music_APi.Models;

namespace Music_APi.Data
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Initial data halnu pare esari halne rahecha
            modelBuilder.Entity<Song>().HasData(new Song()
            {
               Id = 1,
               Duration = "20",
               Language = "Nepali",
               Title = "English"
            });
        }
    }
}
