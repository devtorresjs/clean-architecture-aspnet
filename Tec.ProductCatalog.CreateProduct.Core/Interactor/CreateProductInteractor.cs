namespace Tec.ProductCatalog.CreateProduct.Core.Interactor
{
    internal class CreateProductInteractor(
        ICreateProductRepository repository,
        IDomainSpecificationsValidator<CreateProductDto> validator) : ICreateProductInputPort
    {
        public async Task<int> Handle(CreateProductDto product)
        {
            await DomainValidationGuard.AgainstInvalidSpecification(validator, product);
            return await repository.CreateProductAsync(product);
        }
    }
}
