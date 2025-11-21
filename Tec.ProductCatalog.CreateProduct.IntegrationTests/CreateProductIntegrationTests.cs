namespace Tec.ProductCatalog.CreateProduct.IntegrationTests
{
    public class CreateProductIntegrationTests
    {
        [Fact]
        public async Task CreateProduct_ReturnsOrderId_InMemoryDB()
        {
            IServiceCollection Services = new ServiceCollection();
            Services.AddCreateProductServices();

            Services.AddProductCatalogRepositories(
                options =>
                {
                    options.UseInMemoryDatabase("CreateProductDb");
                }
            );

            IServiceProvider Provider = Services.BuildServiceProvider();

            ICreateProductController Controller =
                Provider.GetRequiredService<ICreateProductController>();

            ProductDbContext Context = Provider.GetRequiredService<ProductDbContext>();

            CreateProductDto Product = new CreateProductDto(
                "Matrícula Semestral 2025",
                "Pago de matrícula para estudiantes. 2025",
                250.60,
                5,
                "https://example.com/images/matricula.jpg",
                "Active"
                );

            int ProductId = await Controller.CreateProductAsync(Product);

            var CreateProduct = Context.Products.Find(ProductId);


            Assert.True(ProductId > 0);
            Assert.NotNull(CreateProduct);
            Assert.Equal(Product.Name, CreateProduct.Name);
            Assert.Equal(Product.Description, CreateProduct.Description);
            Assert.Equal(Product.Stock, CreateProduct.Stock);
            Assert.Equal(Product.Status, CreateProduct.Status);
            Assert.Equal(Product.ImageUrl, CreateProduct.ImageUrl);
           
        }
    }
}
