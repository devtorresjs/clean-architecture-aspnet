namespace Tec.ProductCatalog.GetProduct.Entities.Dtos
{
    public class GetProductDto(
        int id, 
        string name, 
        string description, 
        decimal price, 
        int stock, 
        string imageUrl, 
        string status,
        DateTime createdAt)
    {
        public int Id => id;
        public string Name => name;
        public string Description => description;
        public decimal Price => price;
        public int Stock => stock;
        public string ImageUrl => imageUrl;
        public string Status => status;
        public DateTime CreatedAt => createdAt;
    }
}
