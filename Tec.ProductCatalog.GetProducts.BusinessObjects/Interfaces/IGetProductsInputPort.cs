namespace Tec.ProductCatalog.GetProducts.BusinessObjects.Interfaces
{
    public interface IGetProductsInputPort
    {
        Task Handle(GetProductsParametersDto parameters);
    }
}
