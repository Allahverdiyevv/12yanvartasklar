using Microsoft.EntityFrameworkCore;

namespace Yummy.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Slider> Slider {get;set;}
    }
}
