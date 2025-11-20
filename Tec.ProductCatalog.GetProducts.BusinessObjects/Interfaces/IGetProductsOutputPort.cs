namespace Tec.ProductCatalog.GetProducts.BusinessObjects.Interfaces
{
    public interface IGetProductsOutputPort
    {
        GetProductsResponseDto Response { get; }
        Task HandleResultAsync(ProductsResultDto productsResult);
    }
}
