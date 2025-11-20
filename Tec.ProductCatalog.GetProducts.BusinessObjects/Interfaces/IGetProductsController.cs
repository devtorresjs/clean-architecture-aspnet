namespace Tec.ProductCatalog.GetProducts.BusinessObjects.Interfaces
{
    public interface IGetProductsController
    {
        Task<GetProductsResponseDto> GetProductsAsync(GetProductsParametersDto parameters);
    }
}
