namespace Tec.ProductCatalog.GetProduct.BusinessObjects.Interfaces
{
    public interface IGetProductRepository
    {
        Task<GetProductDto> GetProductByIdAsync(int id);
    }
}
