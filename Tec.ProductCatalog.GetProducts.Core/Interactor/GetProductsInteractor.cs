namespace Tec.ProductCatalog.GetProducts.Core.Interactor
{
    public class GetProductsInteractor(
        IGetProductsRepository repository,
        IGetProductsOutputPort outputPort) : IGetProductsInputPort
    {

        public async Task Handle(GetProductsParametersDto parameters)
        {
            var Result = await repository.GetProductsAsync(parameters);
            await outputPort.HandleResultAsync(Result);
        }
    }
}
