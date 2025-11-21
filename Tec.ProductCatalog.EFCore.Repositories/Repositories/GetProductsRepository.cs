
namespace Tec.ProductCatalog.EFCore.Repositories.Repositories
{
    internal class GetProductsRepository(ProductDbContext context) : IGetProductsRepository
    {
        public async Task<ProductsResultDto> GetProductsAsync(GetProductsParametersDto parameters)
        {
            var Query = context.Products.AsQueryable();

            int total = await Query.CountAsync();


            var Items = await Query
                .OrderByDescending(g => g.Id)
                .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToListAsync();

            return new ProductsResultDto(
               [.. Items.Select(
                    p => new ProductDto(
                    p.Id,
                    p.Name,
                    p.Description,
                    p.Price,
                    p.Stock,
                    p.ImageUrl,
                    p.Status))],
                total,
                parameters.PageNumber,
                parameters.PageSize);
        }
    }
}
