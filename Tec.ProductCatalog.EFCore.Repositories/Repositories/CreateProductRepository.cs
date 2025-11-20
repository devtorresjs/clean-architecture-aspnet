namespace Tec.ProductCatalog.EFCore.Repositories.Repositories
{
    internal class CreateProductRepository(ProductDbContext context) : ICreateProductRepository
    {
        public async Task<int> CreateProductAsync(CreateProductDto product)
        {
            Product Product = product.ToProductEt();

            context.Add(Product);
            await context.SaveChangesAsync();
            return Product.Id;
        }
    }
}
