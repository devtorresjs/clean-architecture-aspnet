
namespace Tec.ProductCatalog.GetProduct.Core.Controller
{
    internal class GetProductController(IGetProductInputPort inputPort) : IGetProductController
    {
        public async Task<GetProductDto> GetProductAsync(int id)
       => await inputPort.GetOrderAsync(id);
    }
}
