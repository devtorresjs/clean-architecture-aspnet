
namespace Tec.ProductCatalog.CreateProduct.Entities.Specifications
{
    internal class CreateProductDtoSpecification: DomainSpecificationBase<CreateProductDto>
    {
        public CreateProductDtoSpecification()
        {
            Property(p => p.Name)
                .IsRequired(Messages.NameRequiredErrorMessage)
                .HasMinLength(3, Messages.NameMinimumLengthErrorMessage)
                .HasMaxLength(150, Messages.NameMaximumLengthErrorMessage);

            Property(p => p.Description)
                .HasMaxLength (500, Messages.DescriptionMaximumLengthErrorMessage);

            Property(p=>p.Price)
                .IsRequired (Messages.PriceRequiredErrorMessage);

            Property(p => p.ImageUrl)
                .HasMaxLength(300, Messages.ImageUrlMaximumLengthErrorMessage);

            Property(p => p.Status)
              .HasMinLength(3, Messages.StatusMinimumLengthErrorMessage)
              .HasMaxLength(20, Messages.ImageUrlMaximumLengthErrorMessage);

            Property(p => p.Stock)
                .IsRequired(Messages.StockRequiredErrorMessage);
        }
    }
}
