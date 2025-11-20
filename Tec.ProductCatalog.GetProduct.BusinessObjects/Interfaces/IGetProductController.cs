namespace Tec.ProductCatalog.GetProduct.BusinessObjects.Interfaces
{
    public interface IGetProductController
    {
        Task<GetProductDto> GetProductAsync(int id);
    }
}
