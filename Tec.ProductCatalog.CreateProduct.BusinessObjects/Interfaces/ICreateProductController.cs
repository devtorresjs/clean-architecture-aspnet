namespace Tec.ProductCatalog.CreateProduct.BusinessObjects.Interfaces
{
    public interface ICreateProductController
    {
        Task<int> CreateProductAsync(CreateProductDto product);
    }
}
