namespace Tec.ProductCatalog.EFCore.Repositories.DbContexts
{
    internal class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
            ChangeTracker.QueryTrackingBehavior =
            QueryTrackingBehavior.NoTracking;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                       typeof(Product).Assembly);
        }
        public DbSet<Product> Products { get; set; }
    }
}
