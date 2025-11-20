namespace Tec.ProductCatalog.EFCore.Repositories.Repositories
{
    internal class GetProductRepository(GetProductDbContext context) : IGetProductRepository
    {
        public async Task<GetProductDto> GetProductByIdAsync(int id)
        {
            var Query = context.Products
                .Where(x => x.Id == id)
                .Select(p => new GetProductDto(
                    p.Id,
                    p.Name,
                    p.Description,
                    p.Price,
                    p.Stock,
                    p.ImageUrl,
                    p.Status,
                    p.CreatedAt));

            return await Query.FirstOrDefaultAsync();
        }
    }
}
