namespace Tec.ProductCatalog.GetProducts.BusinessObjects.Dtos
{
    public class ProductsResultDto(IReadOnlyList<ProductDto> items, int totalItems, int pageNumber, int pageSize)
    {
        public IReadOnlyList<ProductDto> Items = items;
        public int TotalItems => totalItems;
        public int PageNumber => pageNumber;
        public int PageSize => pageSize;

    }
}
