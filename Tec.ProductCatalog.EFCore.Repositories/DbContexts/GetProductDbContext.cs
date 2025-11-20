namespace Tec.ProductCatalog.EFCore.Repositories.DbContexts
{
    internal class GetProductDbContext:DbContext
    {
        public GetProductDbContext(DbContextOptions<GetProductDbContext> options):base(options)
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
