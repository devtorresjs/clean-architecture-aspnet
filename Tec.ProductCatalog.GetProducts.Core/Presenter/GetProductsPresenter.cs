namespace Tec.ProductCatalog.GetProducts.Core.Presenter
{
    internal class GetProductsPresenter : IGetProductsOutputPort
    {
        public GetProductsResponseDto Response { get; private set; }

        public Task HandleResultAsync(ProductsResultDto result)
        {
            Response = new GetProductsResponseDto(
                result.Items,
                result.TotalItems,
                result.PageNumber,
                result.PageSize,
                (int)Math.Ceiling((double)result.TotalItems / result.PageSize));

            return Task.CompletedTask;
        }
    }
}
