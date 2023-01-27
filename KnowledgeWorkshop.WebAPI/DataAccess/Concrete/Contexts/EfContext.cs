using KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Mappings;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Contexts
{
    public class EfContext : DbContext
    {
        public EfContext() { }
        public EfContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build().GetConnectionString("MsSqlConnectionString"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}