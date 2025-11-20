namespace Tec.ProductCatalog.GetProducts.Entities.Dtos
{
    public class GetProductsResponseDto(IReadOnlyList<ProductDto> items, int totalItems, int pageNumber, int pageSize, int totalPages)
    {
        public IReadOnlyList<ProductDto> Items => items;
        public int TotalItems => totalItems;
        public int PageNumber => pageNumber;
        public int PageSize => pageSize;
        public int TotalPages => totalPages;
    }

}
