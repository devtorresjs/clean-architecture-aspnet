namespace Tec.ProductCatalog.EFCore.Repositories.Adapters
{
    public static class CreateProductAdapter
    {
        public static Product ToProductEt(this CreateProductDto product) =>
            new Product
            {
                Name = product.Name,
                Description = product.Description,
                Status = product.Status,
                Stock = product.Stock,
                Price = Convert.ToDecimal(product.Price),
                CreatedAt = DateTime.UtcNow,
                ImageUrl = product.ImageUrl,
            };
    }
}
