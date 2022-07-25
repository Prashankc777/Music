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

    }
}
