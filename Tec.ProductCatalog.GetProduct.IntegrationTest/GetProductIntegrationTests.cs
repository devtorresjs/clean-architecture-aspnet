namespace Tec.ProductCatalog.GetProduct.IntegrationTest
{    
    public class GetProductIntegrationTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(999, false)]
        public async Task GetProduct_ReturnsOrder(int Id, bool shouldExist)
        {
            IServiceCollection Services = new ServiceCollection();
            Services.AddGetProductServices();

            Services.AddProductCatalogRepositories(options =>
            {
                options.ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=ProductCatalog";
            });

            IServiceProvider Provider = Services.BuildServiceProvider();

            IGetProductController Controller = Provider.GetService<IGetProductController>();

            var Product = await Controller.GetProductAsync(Id);

            if(shouldExist)
                Assert.NotNull(Product);
            else
                Assert.Null(Product);

        }
    }
}
