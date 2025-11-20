namespace Tec.ProductCatalog.GetProducts.Entities.Dtos
{
    public class GetProductsParametersDto(int pageNumber, int pageSize)
    {
        public int PageNumber => pageNumber;
        public int PageSize => pageSize;
    }
}
