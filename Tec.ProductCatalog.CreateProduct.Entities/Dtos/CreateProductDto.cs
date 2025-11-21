namespace Tec.ProductCatalog.CreateProduct.Entities.Dtos
{
    public class CreateProductDto(
        string name,
        string description,
        double price,
        int stock,
        string imageUrl,
        string status
        )
    {
        public string Name => name;
        public string Description => description;
        public double Price => price;
        public int Stock => stock;
        public string ImageUrl => imageUrl;
        public string Status => status;
    }
}
