namespace Tec.ProductCatalog.EFCore.Repositories.DbContexts
{
    internal class ProductCatalogDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
          "Server=(localdb)\\mssqllocaldb;Database=ProductCatalog");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> Products { get; set;  }
    }
}
//Add-Migration AddInitialDB -p Tec.ProductCatalog.EFCore.Repositories -s Tec.ProductCatalog.EFCore.Repositories -c ProductCatalogDbContext
//Update-Database -p Tec.ProductCatalog.EFCore.Repositories -s Tec.ProductCatalog.EFCore.Repositories -context ProductCatalogDbContext