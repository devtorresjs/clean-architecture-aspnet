namespace Tec.ProductCatalog.GetProducts.BusinessObjects.Interfaces
{
    public interface IGetProductsRepository
    {
        Task<ProductsResultDto> GetProductsAsync(GetProductsParametersDto parameters);
    }
}


