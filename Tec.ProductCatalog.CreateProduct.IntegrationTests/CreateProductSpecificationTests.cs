namespace Tec.ProductCatalog.CreateProduct.IntegrationTests
{
    public class CreateProductSpecificationTests(ITestOutputHelper output)
    {
        [Fact]
        public async Task CreateProduct_ThrowException_InMemoryDB()
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

            CreateProductDto Product = new CreateProductDto(
               "",
               "Pago de matrícula para estudiantes. 2025",
               250.60,
               5,
               "https://example.com/images/matricula.jpg",
               "Activedfgdfghdfghfdgdfgfdgfdgvbgfgbfbfdgfgfhggfhguugydyt"
               );

            var Ex = await Assert.ThrowsAsync<DomainValidationException>(() =>
            Controller.CreateProductAsync(Product));

            Assert.NotNull(Ex.Errors);
            Assert.NotEmpty(Ex.Errors);

            Assert.Contains(Ex.Errors, e => e.PropertyName == "Name");

            Assert.True(Ex.Errors.Any(e => e.PropertyName == "Status"),
          "Debe proporcionar un máximo de 20 caracteres para el estatus.");

            foreach (var Error in Ex.Errors)
            {
                output.WriteLine($"ERROR: {Error.PropertyName} - {Error.ErrorMessage}");
            }
        }
    }
}
