
namespace Tec.ProductCatalog.CreateProduct.Core.Controller
{
    internal class CreateProductController(ICreateProductInputPort inputPort) : ICreateProductController
    {
        public async Task<int> CreateProductAsync(CreateProductDto product)=> 
            await inputPort.Handle(product);
    }
}
