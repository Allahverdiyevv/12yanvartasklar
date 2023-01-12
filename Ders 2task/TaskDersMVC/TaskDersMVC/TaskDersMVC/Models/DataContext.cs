using Microsoft.EntityFrameworkCore;

namespace TaskDersMVC.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<Fiorello> fiorellos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Prodact> prodacts { get; set; }
    }
}
