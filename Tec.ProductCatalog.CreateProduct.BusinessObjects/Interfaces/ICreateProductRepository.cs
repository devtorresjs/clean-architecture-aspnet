namespace Tec.ProductCatalog.CreateProduct.BusinessObjects.Interfaces
{
    public interface ICreateProductRepository
    {
        Task<int> CreateProductAsync(CreateProductDto product);
    }
}
