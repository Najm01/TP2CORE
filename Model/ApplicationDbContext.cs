using Microsoft.EntityFrameworkCore;
namespace TP2CORE.Model
{
    public class ApplicationDbContext : DbContext
    {
        public
        ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        public DbSet<Categorie> categorie { get; set; }
        public DbSet<sousCategorie> souscategories { get; set; }
    }
}