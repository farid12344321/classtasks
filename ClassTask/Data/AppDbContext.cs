using Classtask.Models;
using Microsoft.EntityFrameworkCore;

namespace Classtask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
    }
}
