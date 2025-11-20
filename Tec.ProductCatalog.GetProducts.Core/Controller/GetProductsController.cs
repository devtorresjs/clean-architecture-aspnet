
namespace Tec.ProductCatalog.GetProducts.Core.Controller
{
    internal class GetProductsController(
        IGetProductsOutputPort outputPort,
        IGetProductsInputPort inputPort) : IGetProductsController
    {
        public async Task<GetProductsResponseDto> GetProductsAsync(GetProductsParametersDto parameters)
        {
            await inputPort.Handle(parameters);
            return outputPort.Response;
        }
    }
}
