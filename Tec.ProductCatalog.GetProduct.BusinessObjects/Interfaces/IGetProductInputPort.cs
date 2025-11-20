namespace Tec.ProductCatalog.GetProduct.BusinessObjects.Interfaces
{
    public interface IGetProductInputPort
    {
        Task<GetProductDto> GetOrderAsync(int id);
    }
}
