
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
                .HasMinLength (3, Messages.DescriptionMinimumLengthErrorMessage)
                .HasMaxLength (500, Messages.DescriptionMaximumLengthErrorMessage);

            Property(p=>p.Price)
                .IsRequired (Messages.PriceRequiredErrorMessage)
                .Matches("^[+-]?\\d+([.,]\\d+)?$", Messages.PriceInvalidErrorMessage);

            Property(p => p.ImageUrl)
                .HasMinLength(3, Messages.ImageUrlMinimumLengthErrorMessage)
                .HasMaxLength(500, Messages.ImageUrlMaximumLengthErrorMessage);

            Property(p => p.Status)
              .HasMinLength(3, Messages.StatusMinimumLengthErrorMessage)
              .HasMaxLength(500, Messages.ImageUrlMaximumLengthErrorMessage);

            Property(p => p.Stock)
                .IsRequired(Messages.StockRequiredErrorMessage);
        }
    }
}
