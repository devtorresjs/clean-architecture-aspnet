namespace Tec.ProductCatalog.GetProduct.Core.Interactor
{
    internal class GetProductInteractor(IGetProductRepository repository) : IGetProductInputPort
    {
        public async Task<GetProductDto> GetOrderAsync(int id)
        {
            return await repository.GetProductByIdAsync(id);
        }
    }
}
