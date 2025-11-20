namespace Tec.ProductCatalog.CreateProduct.BusinessObjects.Interfaces
{
    public interface ICreateProductInputPort
    {
        Task<int> Handle(CreateProductDto product);
    }
}
