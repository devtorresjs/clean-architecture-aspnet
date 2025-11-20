namespace Tec.ProductCatalog.EFCore.Repositories.Options
{
    public class ProductCatalogDbOptions
    {
        public const string SectionKey = nameof(ProductCatalogDbOptions);
        public string ConnectionString { get; set; }
    }
}
